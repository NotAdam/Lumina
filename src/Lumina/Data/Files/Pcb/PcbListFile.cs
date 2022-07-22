using System;
using Lumina.Data.Attributes;
using Lumina.Data.Parsing;

namespace Lumina.Data.Files.Pcb
{
    [FileExtension( "list.pcb" )]
    public class PcbListFile : FileResource
    {
        public struct PcbNodeList
        {
            public Common.BoundingBox BoundingBox;
            public ListNode[] Children;

            public static PcbNodeList Read( LuminaBinaryReader reader )
            {
                var nodeList = new PcbNodeList
                {
                    Children = new ListNode[reader.ReadUInt32()],
                    BoundingBox = Common.BoundingBox.Read( reader )
                };

                // Padding
                reader.BaseStream.Position += 4;

                for( var i = 0; i < nodeList.Children.Length; i++ )
                {
                    nodeList.Children[ i ] = ListNode.Read( reader );
                }

                return nodeList;
            }
        }

        public struct ListNode
        {
            public uint Id;
            public Common.BoundingBox BoundingBox;

            public static ListNode Read( LuminaBinaryReader reader )
            {
                var node = new ListNode
                {
                    Id = reader.ReadUInt32(),
                    BoundingBox = Common.BoundingBox.Read( reader )
                };

                // Padding
                reader.BaseStream.Position += 4;

                return node;
            }
        }

        public PcbNodeList Nodes;

        public override void LoadFile()
        {
            var streamStart = Reader.BaseStream.Position;
            var isList = Reader.ReadUInt32() != 0;
            Reader.BaseStream.Position = streamStart;

            if( !isList )
            {
                throw new InvalidOperationException( "Error parsing pcb list" );
            }

            Nodes = PcbNodeList.Read( Reader );
        }
    }
}