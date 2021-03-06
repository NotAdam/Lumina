using System;

namespace Lumina.Data.Attributes
{
    [AttributeUsage( AttributeTargets.Class )]
    public class FileExtensionAttribute : Attribute
    {
        public readonly string Extension;

        public FileExtensionAttribute( string extension )
        {
            Extension = extension;
        }
    }
}