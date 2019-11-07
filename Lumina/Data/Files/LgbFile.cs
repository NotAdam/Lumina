using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Lumina.Data.Parsing.Layer;
using Lumina.Extensions;

namespace Lumina.Data.Files
{
    public class LgbFile : FileResource
    {
        public struct FileHeader
        {
            char[] FileID; //[4]
            int FileSize;
            int TotalChunkCount;

            public static FileHeader Read( BinaryReader br )
            {
                return new FileHeader
                {
                    FileID = br.ReadChars( 4 ), FileSize = br.ReadInt32(), TotalChunkCount = br.ReadInt32()
                };
            }
        }

        public FileHeader Header { get; private set; }
        public LayerCommon.LayerChunk ChunkHeader { get; private set; }
        public LayerCommon.Layer[] Layers { get; private set; }

        public override void LoadFile()
        {
            BinaryReader br = new BinaryReader(new MemoryStream(Data));

            Header = FileHeader.Read( br );
            ChunkHeader = LayerCommon.LayerChunk.Read( br );
            Layers = new LayerCommon.Layer[ChunkHeader.LayersCount];

            long start = br.BaseStream.Position;
            var layerOffsets = br.ReadStructures< Int32 >( ChunkHeader.LayersCount );

            for( int i = 0; i < ChunkHeader.LayersCount; i++ )
            {
                br.BaseStream.Position = start + layerOffsets[ i ];
                Layers[ i ] = LayerCommon.Layer.Read( br );
            }
        }
    }
}
