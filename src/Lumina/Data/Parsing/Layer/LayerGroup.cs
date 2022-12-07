// ReSharper disable InconsistentNaming

using System.Runtime.InteropServices;
using System;
using System.Diagnostics;
using System.IO;

using Lumina.Extensions;

namespace Lumina.Data.Parsing.Layer
{
    public struct LayerGroup
    {
        public uint LayerGroupID;
        public string Name;
        public LayerCommon.Layer[] Layers;

        public static LayerGroup Read( LuminaBinaryReader br )
        {
            LayerGroup ret = new LayerGroup();

            long start = br.BaseStream.Position;
            ret.LayerGroupID = br.ReadUInt32();
            ret.Name = br.ReadStringOffset( start );

            int layerOffsetsStart = br.ReadInt32();
            int layerOffsetsCount = br.ReadInt32();
            ret.Layers = new LayerCommon.Layer[layerOffsetsCount];

            // reset stream to end of current struct once done reading layers
            long end = br.BaseStream.Position;
            for( int i = 0; i < layerOffsetsCount; ++i )
            {
                br.Seek( start + layerOffsetsStart + ( i * 4 ) );
                br.Seek( start + layerOffsetsStart + br.ReadInt32() );
                ret.Layers[ i ] = LayerCommon.Layer.Read( br );
            }
            br.Seek( end );
            
            return ret;
        }
    }
}