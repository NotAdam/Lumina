using System;

namespace Lumina.Data.Attributes
{
    [AttributeUsage( AttributeTargets.Class )]
    public class FileOptionsAttribute : Attribute
    {
        /// <summary>
        /// The current cache behaviour
        /// </summary>
        public FileCacheBehaviour CacheBehaviour { get; }

        public FileOptionsAttribute(FileCacheBehaviour cacheBehaviour)
        {
            CacheBehaviour = cacheBehaviour;
        }

        /// <summary>
        /// Changes the behaviour for file caching
        /// </summary>
        public enum FileCacheBehaviour
        {
            /// <summary>
            /// The default lumina option is used from <see cref="LuminaOptions"/>
            /// </summary>
            None,
            /// <summary>
            /// The file is always cached
            /// </summary>
            Always,
            /// <summary>
            /// The file is never cached
            /// </summary>
            Never
        }
    }
}