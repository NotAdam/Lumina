using System.IO;
using Lumina.Extensions;

namespace Lumina.Data.Parsing
{
    /// <summary>
    /// Encapsulates string reference fields to contain both its relative offset and actual string without needing to manage 2 objects inside a structure
    /// </summary>
    public class StringOffset
    {
        public StringOffset()
        {
        }

        public StringOffset( BinaryReader br, long start )
        {
            Offset = br.ReadUInt32();
            Read( br, start, Offset );
        }

        public uint Offset { get; set; }

        public string Data { get; set; }

        public void Read( BinaryReader br, long start, uint offset )
        {
            Data = br.ReadStringOffsetData( start + offset );
        }

        public static implicit operator string( StringOffset obj ) => obj.Data;
    }
}