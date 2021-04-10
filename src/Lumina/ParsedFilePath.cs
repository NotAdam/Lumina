namespace Lumina
{
    public record ParsedFilePath
    {
        /// <summary>
        /// The repository (or expansion) that a file belongs to.
        ///
        /// e.g. ffxiv, ex1, ex2, ...
        /// </summary>
        public string Repository { get; internal set; }
        
        public string Category { get; internal set; }
        
        /// <summary>
        /// Index hash
        /// </summary>
        public ulong IndexHash { get; internal set; }
        
        /// <summary>
        /// Index2 hash
        /// </summary>
        public uint Index2Hash { get; internal set; }

        /// <summary>
        /// The portion of an <see cref="IndexHash"/> that represents the folders in the path only
        /// </summary>
        public uint FolderHash => (uint)(IndexHash >> 32);

        /// <summary>
        /// The portion of an <see cref="IndexHash"/> that represents the filename in the path only
        /// </summary>
        public uint FileHash => (uint)IndexHash;
        
        /// <summary>
        /// The raw path provided when parsing the initial path
        /// </summary>
        public string Path { get; internal set; }
        
        public static implicit operator string( ParsedFilePath obj ) => obj.Path;
    }
}