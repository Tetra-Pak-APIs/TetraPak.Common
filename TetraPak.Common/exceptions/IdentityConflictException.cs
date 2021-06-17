using System;

namespace TetraPak
{
    /// <summary>
    ///   To be thrown when there is a conflict of identities.
    /// </summary>
    public class IdentityConflictException : Exception
    {
        /// <summary>
        ///   Gets the conflicting identity.
        /// </summary>
        public string Identity { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="identity">
        ///   Sets the <see cref="Identity"/>
        /// </param>
        /// <param name="message">
        ///   <inheritdoc cref="message"/>
        /// </param>
        /// <param name="innerException">
        ///   <inheritdoc cref="innerException"/>
        /// </param>
        public IdentityConflictException(string identity, string message = null, Exception innerException = null)
        : base(message, innerException)
        {
            Identity = identity;
        }
    }
}