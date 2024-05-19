using System;

namespace Lumina.Excel
{
    /// <summary>
    /// Class that allows to skip the caching of Excel rows when they are read.
    /// </summary>
    public sealed class NoCache : IDisposable
    {
        [field: ThreadStatic]
        internal static bool IsEnabled { get; private set; }
        
        /// <summary>
        /// Disables the caching of Excel rows when they are read.
        /// </summary>
        public NoCache()
        {
            IsEnabled = true;
        }
        
        /// <summary>
        /// Re-enables the caching of Excel rows when they are read.
        /// </summary>
        public void Dispose()
        {
            IsEnabled = false;
        }
    }
}