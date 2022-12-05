using System.IO;
using Lumina.Data.Attributes;
using Lumina.Data.Parsing.Layer;
using Lumina.Extensions;

namespace Lumina.Data.Parsing.Scene
{
    public struct SceneChunk
    {
        // 4
        public char[] ChunkID;
        public int ChunkSize;

        public Layer.LayerGroup[] LayerGroups;

        public int Unknown10;
        public int Unknown14;
        public int Unknown18;
        public int Unknown1C;
        public int Unknown20;
        public int Unknown24;
        public int Unknown28;
        public int Unknown2C;
        public int Unknown30;
        public int Unknown34;
        public int Unknown38;
        // 3
        public int Padding3C;
        public int Padding40;
        public int Padding44;

        public static SceneChunk Read( BinaryReader br )
        {
            SceneChunk ret = new SceneChunk();
            long start = br.BaseStream.Position;

            ret.ChunkID = br.ReadChars( 4 );
            ret.ChunkSize = br.ReadInt32();

            long rewind = br.BaseStream.Position;
            int layerGroupOffset = br.ReadInt32();
            int layerGroupCount = br.ReadInt32();

            ret.Unknown10 = br.ReadInt32();
            ret.Unknown14 = br.ReadInt32();
            ret.Unknown18 = br.ReadInt32();
            ret.Unknown1C = br.ReadInt32();
            ret.Unknown20 = br.ReadInt32();
            ret.Unknown24 = br.ReadInt32();
            ret.Unknown28 = br.ReadInt32();
            ret.Unknown2C = br.ReadInt32();
            ret.Unknown30 = br.ReadInt32();
            ret.Unknown34 = br.ReadInt32();
            ret.Unknown38 = br.ReadInt32();

            ret.Padding3C = br.ReadInt32();
            ret.Padding40 = br.ReadInt32();
            ret.Padding44 = br.ReadInt32();

            // read layer groups
            br.Seek( start + layerGroupOffset );
            ret.LayerGroups = new LayerGroup[layerGroupCount];
            for( int i = 0; i < layerGroupCount; ++i )
            {
                br.Seek( rewind + layerGroupOffset + ( i * 4 ) );
                ret.LayerGroups[i] = Layer.LayerGroup.Read( br );
            }
            return ret;
        }
    };
}