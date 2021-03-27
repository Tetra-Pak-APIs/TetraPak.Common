using System;
using System.Reflection;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace tetrapak.auth
{
    
    public class TetraPakAuthConfig
    {
        const string DefaultSectionKey = "Auth-TetraPak";
        const string KeyDiscoveryDocumentUrl = "DiscoveryDocumentUrl";
        const string KeyAuthorityUrl = "KeyAuthorityUrl";
        const string KeyTokenIssuerUrl = "TokenIssuerUrl";
        const string KeyUserInfoUrl = "UserInfoUrl";

        readonly IConfigurationSection _section;
        readonly string _clientId;
        readonly string _clientSecret;
        readonly string _callbackPath;
        readonly string _callbackUrl;
        readonly string _audience;
        readonly ILogger<TetraPakAuthConfig> _logger;
        readonly AuthConfigAutomaticDiscoveryStrategy _discoveryStrategy;
        string[] _scope;
        string _authorityUrl;
        string _tokenIssuerUrl;
        string _userInfoUrl;
        bool _validateLifetime = true;
        string _authDomain;
        OpenIdDiscoveryDocument _discoveryDocument;

        public bool IsInitialized { get; private set; }

        public async Task<OpenIdDiscoveryDocument> GetDiscoveryDocumentAsync()
        {
            if (_discoveryDocument is { })
                return _discoveryDocument; 
                
            _discoveryDocument = await discoverAsync();
            return _discoveryDocument;
        }
    
        public RuntimeEnvironment Environment { get; }

        public string AuthDomain
        {
            get
            {
                if (_authDomain is { })
                    return _authDomain;

                return Environment switch
                {
                    RuntimeEnvironment.Production => "https://api.tetrapak.com",
                    RuntimeEnvironment.Migration => "https://api-mig.tetrapak.com",
                    RuntimeEnvironment.Development => "https://api-dev.tetrapak.com",
                    RuntimeEnvironment.Sandbox => "https://api-sb.tetrapak.com",
                    _ => throw new NotSupportedException($"Unsupported runtime environment: {Environment}")
                };
            }
            set => _authDomain = value;
        }
        
        public string DiscoveryDocumentUrl => _section[nameof(DiscoveryDocumentUrl)] 
                                              ?? $"{AuthDomain}{OpenIdDiscoveryDocument.DefaultPath}";
        
        public async Task<string> GetAuthorityUrlAsync()
        {
            var url = _authorityUrl ?? _section[KeyAuthorityUrl];
            if (url is {})
                return url;

            var document = await GetDiscoveryDocumentAsync();
            return document.AuthorizationEndpoint;
        }

        public async Task<string> GetTokenIssuerUrlAsync()
        {
            var url = _tokenIssuerUrl ?? _section[KeyTokenIssuerUrl];
            if (url is {})
                return url;

            var document = await GetDiscoveryDocumentAsync();
            return document.TokenEndpoint;
        }

        public async Task<string> GetUserInfoUrlAsync()
        {
            var url = _userInfoUrl ?? _section[KeyUserInfoUrl];
            if (url is {})
                return url;

            var document = await GetDiscoveryDocumentAsync();
            return document.UserInfoEndpoint;
        }

        public string ClientId => _clientId ?? _section[nameof(ClientId)];

        [RestrictedValue]
        public string ClientSecret => _clientSecret ?? _section[nameof(ClientSecret)];

        public string CallbackPath => _callbackPath ?? _section[nameof(CallbackPath)];
        
        public string CallbackUrl => _callbackUrl ?? _section[nameof(CallbackUrl)];

        public string ValidAudience => _audience ?? _section[nameof(ValidAudience)];
        
        public string ValidIssuer => _audience ?? _section[nameof(ValidIssuer)];

        public bool ValidateLifetime => _section.GetNullableBool(nameof(ValidateLifetime)) ?? _validateLifetime; 

        public string[] Scope => _scope ?? _section["Scope"]?.Split(" ");

        public bool IsAuthDomainAssigned => !string.IsNullOrWhiteSpace(_authDomain);

        public TetraPakAuthConfig WithScope(params string[] scope)
        {
            _scope = scope;
            return this;
        }

        void logSettings()
        {
            if (_logger is null)
                return;
            
            var sb = new StringBuilder();
            foreach (var property in GetType().GetProperties())
            {
                var jsonProperty = property.GetCustomAttribute<JsonPropertyNameAttribute>();
                var isRestricted = property.GetCustomAttribute<RestrictedValueAttribute>() is { }; 
                var key = jsonProperty?.Name ?? property.Name;
                var value = isRestricted ? "**********" : property.GetValue(this);
                sb.AppendLine($"  {key}: {getValue(value)}");
            }
            _logger.LogInformation("Auth Configuration:\n{Configuration}", sb.ToString());

            static string getValue(object value)
            {
                if (value is string s)
                    return s;

                return value.IsCollectionOf<string>(out var items) 
                    ? items.ConcatCollection(" ") 
                    : value?.ToString();
            }
        }
        
        async Task<OpenIdDiscoveryDocument> discoverAsync()
        {
            using (_logger?.BeginScope("Downloading Tetra Pak Auth configuration from discovery document"))
            {
                var discoveryDocumentOutcome = await OpenIdDiscoveryDocument.LoadAsync(DiscoveryDocumentUrl);
                if (!discoveryDocumentOutcome)
                {
                    IsInitialized = _discoveryStrategy == AuthConfigAutomaticDiscoveryStrategy.SafeDiscovery;
                    return null;
                }

                var disco = discoveryDocumentOutcome.Value;
                _authorityUrl = disco.AuthorizationEndpoint;
                _tokenIssuerUrl = disco.TokenEndpoint;
                _userInfoUrl = disco.UserInfoEndpoint;
                logSettings();
                IsInitialized = true;
                return disco;
            }
        }
        
        static RuntimeEnvironment? runtimeEnvironment()
        {
            var environment = System.Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            if (!string.IsNullOrEmpty(environment))
                return mapEnvironment(environment);
            
            environment = System.Environment.GetEnvironmentVariable("DOTNET_ENVIRONMENT");
            return !string.IsNullOrEmpty(environment) 
                ? mapEnvironment(environment)
                : null;
        }
        
        static RuntimeEnvironment? mapEnvironment(string environment)
        {
            return Enum.TryParse<RuntimeEnvironment>(environment, true, out var result)
                ? result
                : (RuntimeEnvironment?) null;
        }

        public TetraPakAuthConfig(
            IConfiguration configuration, 
            ILogger<TetraPakAuthConfig> logger,
            AuthConfigAutomaticDiscoveryStrategy discoveryStrategy = AuthConfigAutomaticDiscoveryStrategy.SafeDiscovery,            
            string sectionName = DefaultSectionKey)
        {
            _section = configuration.GetSection(sectionName);
            _logger = logger;
            _discoveryStrategy = discoveryStrategy;
            var s = _section["Environment"];
            Environment = s is { } 
                ? Enum.Parse<RuntimeEnvironment>(s) 
                : runtimeEnvironment() ?? RuntimeEnvironment.Production;
            if (discoveryStrategy == AuthConfigAutomaticDiscoveryStrategy.None)
            {
                logSettings();
            }
        }

        public TetraPakAuthConfig(
            RuntimeEnvironment environment, 
            string clientId, 
            string clientSecret, 
            string callbackPath, 
            string callbackUrl,
            string audience,
            params string[] scope)
        {
            Environment = environment;
            _clientId = clientId;
            _clientSecret = clientSecret;
            _callbackPath = callbackPath;
            _callbackUrl = callbackUrl;
            _audience = audience;
            _scope = scope;
        }
    }

    public enum AuthConfigAutomaticDiscoveryStrategy
    {
        /// <summary>
        ///   No automatic discovery. Default values will be used.
        /// </summary>
        None,
        
        /// <summary>
        ///   Will attempt automatic discovery. 
        /// </summary>
        Discovery,

        /// <summary>
        ///   Will attempt automatic discovery and fall back to defaults on failure. 
        /// </summary>
        SafeDiscovery
    }
    
    public enum RuntimeEnvironment
    {
        Production,
        Migration,
        Development,
        Sandbox
    }
}