using System.Linq;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Tetrapak.Configuration
{
    /// <summary>
    ///   Provides access to the configuration framework through a POCO class. 
    /// </summary>
    public abstract class ConfigurationSection
    {
        /// <summary>
        ///   Gets a value that indicates whether the configuration section contains no information. 
        /// </summary>
        public bool IsEmpty { get; }

        /// <summary>
        ///   Must be overridden. Returns the expected configuration section identifier like in this example:<br/>
        ///   <code>
        ///   "MySection": {
        ///     :
        ///   }
        ///   </code>
        /// </summary>
        protected abstract string SectionIdentifier { get; }
        
        /// <summary>
        ///   Gets the encapsulated <see cref="IConfigurationSection"/>.  
        /// </summary>
        protected IConfigurationSection Section { get; }

        /// <summary>
        ///   Gets a logger.
        /// </summary>
        public ILogger Logger { get; } 

        string getSectionIdentifier() => SectionIdentifier;

        /// <summary>
        ///   Instantiates a <see cref="ConfigurationSection"/>.
        /// </summary>
        /// <param name="configuration">
        ///   The <see cref="IConfiguration"/> instance that contains the configuration section to be encapsulated.
        /// </param>
        /// <param name="logger">
        ///   Initializes the <see cref="Logger"/> value.
        /// </param>
        /// <param name="sectionIdentifier">
        ///   (optional; default=value from <see cref="SectionIdentifier"/>)<br/>
        ///   Specifies the configuration section to be encapsulated. 
        /// </param>
        public ConfigurationSection(
            IConfiguration configuration, 
            ILogger logger,
            string sectionIdentifier = null)
        {
            Section = configuration.GetSection(sectionIdentifier ?? getSectionIdentifier());
            IsEmpty = !Section.GetChildren().Any(); 
            Logger = logger;
        }
    }
}