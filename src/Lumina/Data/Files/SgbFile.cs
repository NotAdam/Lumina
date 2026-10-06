using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Lumina.Data.Attributes;
using Lumina.Data.Parsing.Layer;

// field assigned but not read warning
#pragma warning disable 414

namespace Lumina.Data.Files
{
    [FileExtension( ".sgb" )]
    public class SgbFile : FileResource
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
                    TotalChunkCount = br.ReadInt32(),
                };
            }
        }

        public struct SceneTimeline
        {
            public int SubId;
            public string Name;
        }

        public FileHeader Header { get; private set; }
        public Parsing.Scene.SceneChunk ChunkHeader { get; private set; }
        public LayerGroup[] LayerGroups { get; private set; }

        public SceneTimeline[] Timelines { get; private set; } = [];

        /// <summary>
        /// 16-byte MapEffect bit-to-SubId table from the animation handler section.
        /// Index = bit position (0–15) in the MapEffect state word;
        /// value = SubId of the triggered <see cref="SceneTimeline"/> (0 = unused bit).
        /// </summary>
        public byte[]? BitSubIdTable { get; private set; }

        /// <summary>
        /// Mapping from MapEffect state values to TMLB names.
        /// </summary>
        public (ushort State, string Name)[] StateMappings { get; private set; } = [];

        public override void LoadFile()
        {
            Header = FileHeader.Read( Reader );
            ChunkHeader = Parsing.Scene.SceneChunk.Read( Reader );
            LayerGroups = ChunkHeader.LayerGroups;

            if( Data != null )
            {
                Timelines    = ParseTimelines( Data, ChunkHeader.OffsetTimelines );
                BitSubIdTable = ParseBitSubIdTable( Data, ChunkHeader.OffsetAnimationHandlers );
                StateMappings = BuildStateMappings( Timelines, BitSubIdTable );
            }
        }

        private static SceneTimeline[] ParseTimelines( byte[] data, int offsetTimelines )
        {
            if( offsetTimelines <= 0 ) return [];
            int fileDataBase = 20 + offsetTimelines;
            if( fileDataBase + 8 > data.Length ) return [];

            int entryOffset = BitConverter.ToInt32( data, fileDataBase );
            int count       = BitConverter.ToInt32( data, fileDataBase + 4 );
            if( count <= 0 || count > 128 ) return [];

            var names  = ReadStringTableFromEnd( data, count );
            var result = new SceneTimeline[count];
            for( int n = 0; n < count; n++ )
            {
                int entryStart = fileDataBase + entryOffset + n * 44;
                if( entryStart + 4 > data.Length ) break;
                result[n] = new SceneTimeline
                {
                    SubId = BitConverter.ToInt32( data, entryStart ),
                    Name  = n < names.Length ? names[n] : string.Empty,
                };
            }
            return result;
        }

        private static byte[]? ParseBitSubIdTable( byte[] data, int offsetAnimHandlers )
        {
            if( offsetAnimHandlers <= 0 ) return null;
            int sectionBase = 20 + offsetAnimHandlers;
            if( sectionBase + 21 > data.Length ) return null;
            var table = new byte[16];
            System.Buffer.BlockCopy( data, sectionBase + 5, table, 0, 16 );
            return table;
        }

        private static (ushort State, string Name)[] BuildStateMappings( SceneTimeline[] timelines, byte[]? bitSubIdTable )
        {
            if( bitSubIdTable == null || timelines.Length == 0 ) return [];

            var subIdToName = new Dictionary<int, string>( timelines.Length );
            foreach( var t in timelines )
                if( t.SubId > 0 && !subIdToName.ContainsKey( t.SubId ) )
                    subIdToName[t.SubId] = t.Name;

            var result = new List<(ushort, string)>( 16 );
            for( int i = 0; i < 16; i++ )
            {
                int subId = bitSubIdTable[i];
                if( subId == 0 ) continue;
                ushort state = (ushort)( 1 << i );
                var name = subIdToName.TryGetValue( subId, out var n ) ? n : $"SubId={subId}";
                result.Add( (state, name) );
            }
            return result.ToArray();
        }

        private static string[] ReadStringTableFromEnd( byte[] data, int limit )
        {
            int markerPos = -1;
            for( int i = data.Length - 1; i >= 0; i-- )
            {
                if( data[i] == 0xFF ) { markerPos = i; break; }
            }
            if( markerPos < 0 || markerPos >= data.Length - 1 ) return [];

            var names = new List<string>( limit );
            int pos   = markerPos + 1;
            while( pos < data.Length && names.Count < limit )
            {
                int start = pos;
                while( pos < data.Length && data[pos] != 0 ) pos++;
                if( pos > start )
                    names.Add( Encoding.UTF8.GetString( data, start, pos - start ) );
                pos++;
            }
            return names.ToArray();
        }
    }
}
