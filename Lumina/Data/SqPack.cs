using System;
using System.Diagnostics.Contracts;
using System.IO;
using Lumina.Data.Structs;
using Lumina.Extensions;

namespace Lumina.Data
{
    public class SqPack
    {
        /// <summary>
        /// Where the actual file is located on disk
        /// </summary>
        public FileInfo File { get; }
        
        public SqPackHeader SqPackHeader { get; private set; }

        /// <summary>
        /// PC and PS4 are LE, PS3 is BE
        /// </summary>
        public bool ShouldConvertEndianness
        {
            // todo: what about reading LE files on BE device? do we even care?
            get => BitConverter.IsLittleEndian && SqPackHeader.platformId == PlatformId.PS3;
        }

        public SqPack( FileInfo file )
        {
            Contract.Requires( file != null );
            Contract.Requires( file.Exists );
            
            File = file;

            using var fs = file.OpenRead();
            using var br = new BinaryReader( fs );
            
            SqPackHeader = br.ReadStructure< SqPackHeader >();

            //fs.Position = SqPackHeader.size;
        }
    }
}