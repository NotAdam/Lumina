using System;

namespace Lumina.Data.Attributes
{
    /// <summary>
    /// Allows for a <see cref="FileResource"/> to indicate what the extension of the file it reads is
    /// </summary>
    [AttributeUsage( AttributeTargets.Class )]
    public class FileExtensionAttribute : Attribute
    {
        /// <summary>
        /// The extension of the file that the <see cref="FileResource"/> handles. Includes the leading <code>.</code>
        /// </summary>
        public readonly string Extension;

        /// <summary>
        /// Allows for a <see cref="FileResource"/> to indicate what the extension of the file it reads is
        /// </summary>
        /// <param name="extension">The extension that the <see cref="FileResource"/> supports. Include the leading period <code>.</code></param>
        public FileExtensionAttribute( string extension )
        {
            Extension = extension;
        }
    }
}