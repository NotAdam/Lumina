// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Behavior", columnHash: 0x858a7450 )]
    public partial class Behavior : ExcelRow
    {
        
        public byte Unknown0 { get; set; }
        public byte Unknown1 { get; set; }
        public byte Condition0Target { get; set; }
        public byte Condition0Type { get; set; }
        public int Unknown4 { get; set; }
        public short Unknown5 { get; set; }
        public int Unknown6 { get; set; }
        public ushort Unknown7 { get; set; }
        public LazyRow< Balloon > Balloon { get; set; }
        public byte Condition1Target { get; set; }
        public byte Condition1Type { get; set; }
        public uint ContentArgument0 { get; set; }
        public byte ContentArgument1 { get; set; }
        public byte Unknown13 { get; set; }
        public byte Unknown14 { get; set; }
        public uint Unknown15 { get; set; }
        public ushort Unknown16 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            Condition0Target = parser.ReadColumn< byte >( 2 );
            Condition0Type = parser.ReadColumn< byte >( 3 );
            Unknown4 = parser.ReadColumn< int >( 4 );
            Unknown5 = parser.ReadColumn< short >( 5 );
            Unknown6 = parser.ReadColumn< int >( 6 );
            Unknown7 = parser.ReadColumn< ushort >( 7 );
            Balloon = new LazyRow< Balloon >( gameData, parser.ReadColumn< ushort >( 8 ), language );
            Condition1Target = parser.ReadColumn< byte >( 9 );
            Condition1Type = parser.ReadColumn< byte >( 10 );
            ContentArgument0 = parser.ReadColumn< uint >( 11 );
            ContentArgument1 = parser.ReadColumn< byte >( 12 );
            Unknown13 = parser.ReadColumn< byte >( 13 );
            Unknown14 = parser.ReadColumn< byte >( 14 );
            Unknown15 = parser.ReadColumn< uint >( 15 );
            Unknown16 = parser.ReadColumn< ushort >( 16 );
        }
    }
}