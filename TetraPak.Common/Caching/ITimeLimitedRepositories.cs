using System;
using System.Threading.Tasks;

namespace TetraPak.Caching
{
    public interface ITimeLimitedRepositories
    {
        /// <summary>
        ///   Gets a default lifespan for repository values. 
        /// </summary>
        TimeSpan DefaultLifeSpan { get; }
        
        /// <summary>
        ///   Gets a default extended lifespan for repository values. The extended lifespan
        ///   is applied to entities as they are read or updated.
        /// </summary>
        /// <remarks>
        ///   Set this value to zero ("0" or "0:0:0") to avoid extending entries' cache lifespan.
        /// </remarks>
        TimeSpan DefaultExtendedLifeSpan { get; }
        
        /// <summary>
        ///   Gets a default maximum lifespan for repository values.
        ///   The maximum lifespan can never be exceeded by dynamically extending cached entries' lifespan.  
        /// </summary>
        /// <seealso cref="DefaultLifeSpan"/>
        /// <seealso cref="DefaultExtendedLifeSpan"/>
        TimeSpan DefaultMaxLifeSpan { get; }
        
        /// <summary>
        ///   Gets or sets a value specifying whether value types should be validated when updated.
        ///   Attempts to update an existing value with a value that is type incompatible will
        ///   throw an <see cref="IdentityConflictException"/>. 
        /// </summary>
        bool IsTypeStrict { get; set; }
        
        /// <summary>
        ///   Gets the lifespan configured for a specified repository. 
        /// </summary>
        /// <param name="repository">
        ///   Identifies the repository.    
        /// </param>
        /// <returns>
        ///   A <see cref="TimeSpan"/> value.
        /// </returns>
        TimeSpan GetLifeSpan(string repository);

        /// <summary>
        ///   Gets the maximum allowed lifespan configured for a specified repository. 
        /// </summary>
        /// <param name="repository">
        ///   Identifies the repository.    
        /// </param>
        /// <returns>
        ///   A <see cref="TimeSpan"/> value.
        /// </returns>
        TimeSpan GetMaxLifeSpan(string repository);
        
        /// <summary>
        ///   Gets the extended lifespan configured for a specified repository.
        ///   The extended lifespan is applied every time a cached entity is read or updated.  
        /// </summary>
        /// <param name="repository">
        ///   Identifies the repository.    
        /// </param>
        /// <returns>
        ///   A <see cref="TimeSpan"/> value.
        /// </returns>
        TimeSpan GetExtendedLifeSpan(string repository);

        /// <summary>
        ///   Looks up a value in a repository.
        /// </summary>
        /// <param name="repository">
        ///   Identifies the repository where the value should exist.
        /// </param>
        /// <param name="key">
        ///     Identifies the requested value.
        /// </param>
        /// <typeparam name="T">
        ///   The requested value <see cref="Type"/>.
        /// </typeparam>
        /// <returns>
        ///   An <see cref="Outcome{T}"/> to indicate success/failure and also carry the requested value
        ///   (or an <see cref="Exception"/> on failure).
        /// </returns>
        Task<Outcome<T>> GetAsync<T>(string repository, string key);

        Task<Outcome<T>> GetAsync<T>(string repository, string key, out TimeSpan remainingLifeSpan);
        
        /// <summary>
        ///   Adds a new time limited value.
        /// </summary>
        /// <param name="repository">
        ///   Identifies the repository where the new value should exist.
        /// </param>
        /// <param name="key">
        ///   Value's unique identifier.
        /// </param>
        /// <param name="value">
        ///   The value to be added.
        /// </param>
        /// <param name="customLifeSpan">
        ///   (optional; default=<see cref="DefaultLifeSpan"/>)<br/>
        ///   A custom lifespan for the value.
        /// </param>
        /// <exception cref="IdentityConflictException">
        ///   A value with the same <paramref name="key"/> was already added.
        /// </exception>
        Task AddAsync(string repository, string key, object value, TimeSpan? customLifeSpan = null);

        /// <summary>
        ///   Updates an existing time limited value.
        /// </summary>
        /// <param name="repository">
        ///   Identifies the repository where the value should exist.
        /// </param>
        /// <param name="key">
        ///   Value's unique identifier.
        /// </param>
        /// <param name="value">
        ///   The value to be added.
        /// </param>
        /// <param name="customLifeSpan">
        ///   (optional; default=<see cref="DefaultLifeSpan"/>)<br/>
        ///   A custom lifespan for the value.
        /// </param>
        /// <exception cref="ArgumentOutOfRangeException">
        ///   A value could not be identified from the specified <paramref name="key"/>.
        /// </exception>
        Task UpdateAsync(string repository, string key, object value, TimeSpan? customLifeSpan = null);

        /// <summary>
        ///   Adds a new value or updated an existing one.
        /// </summary>
        /// <param name="repository">
        ///   Identifies the repository where the value should exist.
        /// </param>
        /// <param name="key">
        ///   Value's unique identifier.
        /// </param>
        /// <param name="value">
        ///   The value to be added or updated.
        /// </param>
        /// <param name="customLifeSpan">
        ///   (optional; default=<see cref="DefaultLifeSpan"/>)<br/>
        ///   A custom lifespan for the value.
        /// </param>
        /// <exception cref="InvalidCastException">
        ///   A value with the same <paramref name="key"/> was already added but its value is incompatible with the new value.
        /// </exception>
        Task AddOrUpdateAsync(string repository, string key, object value, TimeSpan? customLifeSpan = null);

        /// <summary>
        ///   Removes a time limited value.
        /// </summary>
        /// <param name="repository">
        ///   Identifies the repository to remove the value from.
        /// </param>
        /// <param name="key">
        ///   Value's unique identifier.
        /// </param>
        /// <exception cref="ArgumentOutOfRangeException">
        ///   The <paramref name="key"/> was not recognized.
        /// </exception>
        Task DeleteAsync(string repository, string key);

        /// <summary>
        ///   Creates or configures a time limited repository.
        /// </summary>
        /// <param name="repository">
        ///   Identifies the repository to remove the value from.
        /// </param>
        /// <param name="options">
        ///   Specifies the repository configuration.
        /// </param>
        public Task ConfigureAsync(string repository, ITimeLimitedRepositoryOptions options);
    }
}