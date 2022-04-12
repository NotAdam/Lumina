// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MJIRecipe", columnHash: 0x6885c474 )]
    public class MJIRecipe : ExcelRow
    {
        
        public int Unknown0 { get; set; }
        public byte Unknown1 { get; set; }
        public int Unknown2 { get; set; }
        public byte Unknown3 { get; set; }
        public int Unknown4 { get; set; }
        public byte Unknown5 { get; set; }
        public int Unknown6 { get; set; }
        public byte Unknown7 { get; set; }
        public int Unknown8 { get; set; }
        public byte Unknown9 { get; set; }
        public int Unknown10 { get; set; }
        public byte Unknown11 { get; set; }
        public int Unknown12 { get; set; }
        public byte Unknown13 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< int >( 0 );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            Unknown2 = parser.ReadColumn< int >( 2 );
            Unknown3 = parser.ReadColumn< byte >( 3 );
            Unknown4 = parser.ReadColumn< int >( 4 );
            Unknown5 = parser.ReadColumn< byte >( 5 );
            Unknown6 = parser.ReadColumn< int >( 6 );
            Unknown7 = parser.ReadColumn< byte >( 7 );
            Unknown8 = parser.ReadColumn< int >( 8 );
            Unknown9 = parser.ReadColumn< byte >( 9 );
            Unknown10 = parser.ReadColumn< int >( 10 );
            Unknown11 = parser.ReadColumn< byte >( 11 );
            Unknown12 = parser.ReadColumn< int >( 12 );
            Unknown13 = parser.ReadColumn< byte >( 13 );
        }
    }
}