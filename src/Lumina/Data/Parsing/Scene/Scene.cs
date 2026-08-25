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

        public int OffsetGeneral;
        public int OffsetFilters;
        public int OffsetTimelines;
        public int OffsetLayerGroupResources;
        public int NumLayerGroupResources;
        public int Unknown24;
        public int OffsetAnimationHandlers;
        public int Unknown2C;
        public int Unknown30;
        
        public HousingSettings? HousingSettings;
        
        public int Unknown38;
        // 3
        public int Padding3C;
        public int Padding40;
        public int Padding44;

        public static SceneChunk Read( LuminaBinaryReader br )
        {
            SceneChunk ret = new SceneChunk();
            long start = br.BaseStream.Position;

            ret.ChunkID = br.ReadChars( 4 );
            ret.ChunkSize = br.ReadInt32();

            long rewind = br.BaseStream.Position;
            int layerGroupOffset = br.ReadInt32();
            int layerGroupCount = br.ReadInt32();

            ret.OffsetGeneral = br.ReadInt32();
            ret.OffsetFilters = br.ReadInt32();
            ret.OffsetTimelines = br.ReadInt32();
            ret.OffsetLayerGroupResources = br.ReadInt32();
            ret.NumLayerGroupResources = br.ReadInt32();
            ret.Unknown24 = br.ReadInt32();
            ret.OffsetAnimationHandlers = br.ReadInt32();
            ret.Unknown2C = br.ReadInt32();
            ret.Unknown30 = br.ReadInt32();
            
            int housingOffset = br.ReadInt32();
            
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
            if( housingOffset != 0 )
            {
                br.Seek( rewind + housingOffset );
                ret.HousingSettings = Scene.HousingSettings.Read( br );
            }
            return ret;
        }
    };
}