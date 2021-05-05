using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Lumina.Data.Attributes;
using Lumina.Data.Parsing;

namespace Lumina.Data.Files.Pcb
{
    [FileExtension( ".pcb" )]
    public class PcbResourceFile : FileResource
    {
        public struct PcbResourceHeader {
            public uint Magic;
            public uint Version;
            public uint TotalNodes;
            public uint TotalPolygons;

            public List<ResourceNode> Children;
            
            public static PcbResourceHeader Read( BinaryReader reader )
            {
                var header = new PcbResourceHeader
                {
                    Magic = reader.ReadUInt32(),
                    Version = reader.ReadUInt32(),
                    TotalNodes = reader.ReadUInt32(),
                    TotalPolygons = reader.ReadUInt32()
                };

                if( header.TotalNodes == 0 )
                    return header;
                
                header.Children = new List<ResourceNode>();

                var totalNodesRead = 0;
                while( totalNodesRead <= header.TotalNodes )
                {
                    header.Children.Add( ResourceNode.ReadWithCount( reader, out var nodesRead ) );
                    totalNodesRead += nodesRead;
                }
                
                return header;
            }
        }
        
        public struct ResourceNode
        {
            public uint Magic;
            public uint Version;
            public uint HeaderSkip;
            public uint GroupLength;
            public Common.BoundingBox BoundingBox;

            public Common.Vector3[] Vertices;
            public Polygon[] Polygons;

            public List<ResourceNode> Children;
            
            public static ResourceNode ReadWithCount( BinaryReader reader, out int totalNodesRead )
            {
                totalNodesRead = 1;

                var initialPosition = reader.BaseStream.Position;
                
                var header = new ResourceNode
                {
                    Magic = reader.ReadUInt32(),
                    Version = reader.ReadUInt32(),
                    HeaderSkip = reader.ReadUInt32(),
                    GroupLength = reader.ReadUInt32(),
                    BoundingBox = Common.BoundingBox.Read( reader )
                };
                var numVertFloat16 = reader.ReadUInt16();
                header.Polygons = new Polygon[reader.ReadUInt16()];
                var numVertFloat32 = reader.ReadUInt16();
                
                header.Vertices = new Common.Vector3[numVertFloat16 + numVertFloat32];

                // Padding
                reader.BaseStream.Position += 2;
                
                
                if( header.GroupLength != 0 )
                {
                    header.Children = new List<ResourceNode>();

                    var finalPosition = initialPosition + header.GroupLength;
                    while( reader.BaseStream.Position + header.HeaderSkip < finalPosition )
                    {
                        header.Children.Add( ResourceNode.ReadWithCount( reader, out var nodesRead ) );
                        totalNodesRead += nodesRead;
                    }

                    reader.BaseStream.Position = finalPosition;
                }

                for( var i = 0; i < numVertFloat32; i++ )
                {
                    header.Vertices[ i ] = Common.Vector3.Read( reader );
                }
                
                for( var i = numVertFloat32; i < numVertFloat32 + numVertFloat16; i++ )
                {
                    header.Vertices[ i ] = Common.Vector3.Read16( reader );
                }

                for( var i = 0; i < header.Polygons.Length; i++ )
                {
                    header.Polygons[i] = Polygon.Read( reader );
                }
                
                
                return header;
            }
        }
        
        public struct Polygon
        {
            public byte[] VertexIndex;
            public ushort Unknown;
            
            public static Polygon Read( BinaryReader reader )
            {
                var polygon = new Polygon
                {
                    VertexIndex = reader.ReadBytes( 3 ),
                };

                // Padding
                reader.BaseStream.Position += 2;

                polygon.Unknown = reader.ReadUInt16();

                // Padding
                reader.BaseStream.Position += 5;

                return polygon;
            }
        }

        public PcbResourceHeader Nodes;

        public override void LoadFile()
        {
            var streamStart = Reader.BaseStream.Position;
            var isList = Reader.ReadUInt32() != 0;
            Reader.BaseStream.Position = streamStart;

            if( isList ) return;
            
            Nodes = PcbResourceHeader.Read( Reader );
        }

        public override string ToString()
        {
            var sb = new StringBuilder($"Total Nodes: {Nodes.TotalNodes}; Total Polygons: {Nodes.TotalPolygons}.");
            
            foreach (var n in Nodes.Children)
            {
                Stringify( sb, n, "" );
            }

            return sb.ToString();
        }

        private static void Stringify( StringBuilder sb, ResourceNode r, string tabs )
        {
            sb.AppendLine( $"{tabs}Bounding Box: " +
                           $"({r.BoundingBox.Min.X}, {r.BoundingBox.Min.Y}, {r.BoundingBox.Min.Z}) => " +
                           $"({r.BoundingBox.Max.X}, {r.BoundingBox.Max.Y}, {r.BoundingBox.Max.Z})" );
            
            if( r.Polygons.Length > 0 )
            {
                sb.AppendLine( $"{tabs}Polygons:" );
                foreach( var p in r.Polygons )
                {
                    sb.AppendLine(
                        $"{tabs}" +
                        $"({r.Vertices[ p.VertexIndex[ 0 ] ].X}, {r.Vertices[ p.VertexIndex[ 0 ] ].Y}, {r.Vertices[ p.VertexIndex[ 0 ] ].Z}), " +
                        $"({r.Vertices[ p.VertexIndex[ 1 ] ].X}, {r.Vertices[ p.VertexIndex[ 1 ] ].Y}, {r.Vertices[ p.VertexIndex[ 1 ] ].Z}), " +
                        $"({r.Vertices[ p.VertexIndex[ 2 ] ].X}, {r.Vertices[ p.VertexIndex[ 2 ] ].Y}, {r.Vertices[ p.VertexIndex[ 2 ] ].Z}) - {p.Unknown:X}"
                    );
                }
            }

            if( !( r.Children?.Count > 0 ) ) return;
            
            sb.AppendLine( $"{tabs}Children:" );
            foreach( var c in r.Children )
            {
                Stringify( sb, c, tabs + "  " );
            }
        }
    }
}