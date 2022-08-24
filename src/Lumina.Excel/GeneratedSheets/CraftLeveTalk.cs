// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CraftLeveTalk", columnHash: 0x000c7d93 )]
    public partial class CraftLeveTalk : ExcelRow
    {
        
        public bool Unknown0 { get; set; }
        public bool Unknown1 { get; set; }
        public bool Unknown2 { get; set; }
        public bool Unknown3 { get; set; }
        public bool Unknown4 { get; set; }
        public bool Unknown5 { get; set; }
        public byte Unknown6 { get; set; }
        public byte Unknown7 { get; set; }
        public byte Unknown8 { get; set; }
        public byte Unknown9 { get; set; }
        public byte Unknown10 { get; set; }
        public byte Unknown11 { get; set; }
        public uint Unknown12 { get; set; }
        public uint Unknown13 { get; set; }
        public uint Unknown14 { get; set; }
        public uint Unknown15 { get; set; }
        public uint Unknown16 { get; set; }
        public uint Unknown17 { get; set; }
        public sbyte Unknown18 { get; set; }
        public sbyte Unknown19 { get; set; }
        public sbyte Unknown20 { get; set; }
        public sbyte Unknown21 { get; set; }
        public sbyte Unknown22 { get; set; }
        public sbyte Unknown23 { get; set; }
        public sbyte Unknown24 { get; set; }
        public sbyte Unknown25 { get; set; }
        public sbyte Unknown26 { get; set; }
        public sbyte Unknown27 { get; set; }
        public sbyte Unknown28 { get; set; }
        public sbyte Unknown29 { get; set; }
        public int Unknown30 { get; set; }
        public int Unknown31 { get; set; }
        public int Unknown32 { get; set; }
        public int Unknown33 { get; set; }
        public int Unknown34 { get; set; }
        public int Unknown35 { get; set; }
        public SeString[] Talk { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< bool >( 0 );
            Unknown1 = parser.ReadColumn< bool >( 1 );
            Unknown2 = parser.ReadColumn< bool >( 2 );
            Unknown3 = parser.ReadColumn< bool >( 3 );
            Unknown4 = parser.ReadColumn< bool >( 4 );
            Unknown5 = parser.ReadColumn< bool >( 5 );
            Unknown6 = parser.ReadColumn< byte >( 6 );
            Unknown7 = parser.ReadColumn< byte >( 7 );
            Unknown8 = parser.ReadColumn< byte >( 8 );
            Unknown9 = parser.ReadColumn< byte >( 9 );
            Unknown10 = parser.ReadColumn< byte >( 10 );
            Unknown11 = parser.ReadColumn< byte >( 11 );
            Unknown12 = parser.ReadColumn< uint >( 12 );
            Unknown13 = parser.ReadColumn< uint >( 13 );
            Unknown14 = parser.ReadColumn< uint >( 14 );
            Unknown15 = parser.ReadColumn< uint >( 15 );
            Unknown16 = parser.ReadColumn< uint >( 16 );
            Unknown17 = parser.ReadColumn< uint >( 17 );
            Unknown18 = parser.ReadColumn< sbyte >( 18 );
            Unknown19 = parser.ReadColumn< sbyte >( 19 );
            Unknown20 = parser.ReadColumn< sbyte >( 20 );
            Unknown21 = parser.ReadColumn< sbyte >( 21 );
            Unknown22 = parser.ReadColumn< sbyte >( 22 );
            Unknown23 = parser.ReadColumn< sbyte >( 23 );
            Unknown24 = parser.ReadColumn< sbyte >( 24 );
            Unknown25 = parser.ReadColumn< sbyte >( 25 );
            Unknown26 = parser.ReadColumn< sbyte >( 26 );
            Unknown27 = parser.ReadColumn< sbyte >( 27 );
            Unknown28 = parser.ReadColumn< sbyte >( 28 );
            Unknown29 = parser.ReadColumn< sbyte >( 29 );
            Unknown30 = parser.ReadColumn< int >( 30 );
            Unknown31 = parser.ReadColumn< int >( 31 );
            Unknown32 = parser.ReadColumn< int >( 32 );
            Unknown33 = parser.ReadColumn< int >( 33 );
            Unknown34 = parser.ReadColumn< int >( 34 );
            Unknown35 = parser.ReadColumn< int >( 35 );
            Talk = new SeString[ 6 ];
            for( var i = 0; i < 6; i++ )
                Talk[ i ] = parser.ReadColumn< SeString >( 36 + i );
        }
    }
}