// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MJIBuilding", columnHash: 0x6d809733 )]
    public partial class MJIBuilding : ExcelRow
    {
        
        public byte Unknown0 { get; set; }
        public LazyRow< ExportedSG > sgb0 { get; set; }
        public byte Unknown2 { get; set; }
        public byte Unknown3 { get; set; }
        public LazyRow< ExportedSG > sgb1 { get; set; }
        public byte Unknown5 { get; set; }
        public LazyRow< ExportedSG > sgb2 { get; set; }
        public byte Unknown7 { get; set; }
        public LazyRow< ExportedSG > sgb3 { get; set; }
        public byte Unknown9 { get; set; }
        public LazyRow< ExportedSG > sgb4 { get; set; }
        public byte Unknown11 { get; set; }
        public byte Unknown12 { get; set; }
        public byte Unknown13 { get; set; }
        public byte Unknown14 { get; set; }
        public byte Unknown15 { get; set; }
        public byte Unknown16 { get; set; }
        public byte Unknown17 { get; set; }
        public byte Unknown18 { get; set; }
        public LazyRow< MJIItemPouch >[] Material { get; set; }
        public byte[] Amount { get; set; }
        public LazyRow< MJIText > Name { get; set; }
        public uint Unknown30 { get; set; }
        public uint Icon { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< byte >( 0 );
            sgb0 = new LazyRow< ExportedSG >( gameData, parser.ReadColumn< ushort >( 1 ), language );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            Unknown3 = parser.ReadColumn< byte >( 3 );
            sgb1 = new LazyRow< ExportedSG >( gameData, parser.ReadColumn< ushort >( 4 ), language );
            Unknown5 = parser.ReadColumn< byte >( 5 );
            sgb2 = new LazyRow< ExportedSG >( gameData, parser.ReadColumn< ushort >( 6 ), language );
            Unknown7 = parser.ReadColumn< byte >( 7 );
            sgb3 = new LazyRow< ExportedSG >( gameData, parser.ReadColumn< ushort >( 8 ), language );
            Unknown9 = parser.ReadColumn< byte >( 9 );
            sgb4 = new LazyRow< ExportedSG >( gameData, parser.ReadColumn< ushort >( 10 ), language );
            Unknown11 = parser.ReadColumn< byte >( 11 );
            Unknown12 = parser.ReadColumn< byte >( 12 );
            Unknown13 = parser.ReadColumn< byte >( 13 );
            Unknown14 = parser.ReadColumn< byte >( 14 );
            Unknown15 = parser.ReadColumn< byte >( 15 );
            Unknown16 = parser.ReadColumn< byte >( 16 );
            Unknown17 = parser.ReadColumn< byte >( 17 );
            Unknown18 = parser.ReadColumn< byte >( 18 );
            Material = new LazyRow< MJIItemPouch >[ 5 ];
            for( var i = 0; i < 5; i++ )
                Material[ i ] = new LazyRow< MJIItemPouch >( gameData, parser.ReadColumn< byte >( 19 + i ), language );
            Amount = new byte[ 5 ];
            for( var i = 0; i < 5; i++ )
                Amount[ i ] = parser.ReadColumn< byte >( 24 + i );
            Name = new LazyRow< MJIText >( gameData, parser.ReadColumn< uint >( 29 ), language );
            Unknown30 = parser.ReadColumn< uint >( 30 );
            Icon = parser.ReadColumn< uint >( 31 );
        }
    }
}