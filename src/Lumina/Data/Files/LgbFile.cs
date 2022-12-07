using Lumina.Data.Attributes;
using Lumina.Data.Parsing.Layer;
// ReSharper disable InconsistentNaming

// field assigned but not read warning
#pragma warning disable 414

namespace Lumina.Data.Files
{
    [FileExtension( ".lgb" )]
    public class LgbFile : FileResource
    {
        public struct FileHeader
        {
            char[] FileID; //[4]
            int FileSize;
            int TotalChunkCount;

            public static FileHeader Read( LuminaBinaryReader br )
            {
                return new()
                {
                    FileID = br.ReadChars( 4 ),
                    FileSize = br.ReadInt32(),
                    TotalChunkCount = br.ReadInt32()
                };
            }
        }

        public FileHeader Header { get; private set; }
        public LayerCommon.LayerChunk ChunkHeader { get; private set; }
        public LayerCommon.Layer[] Layers { get; private set; }

        public override void LoadFile()
        {
            Header = FileHeader.Read( Reader );
            ChunkHeader = LayerCommon.LayerChunk.Read( Reader );
            Layers = new LayerCommon.Layer[ChunkHeader.LayersCount];

            var start = Reader.Position;
            var layerOffsets = Reader.ReadInt32Array( ChunkHeader.LayersCount );

            for( var i = 0; i < ChunkHeader.LayersCount; i++ )
            {
                Reader.Position = start + layerOffsets[ i ];
                Layers[ i ] = LayerCommon.Layer.Read( Reader );
            }
        }
    }
}