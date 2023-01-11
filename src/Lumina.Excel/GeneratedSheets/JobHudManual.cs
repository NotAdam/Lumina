// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "JobHudManual", columnHash: 0x21d1dec2 )]
    public partial class JobHudManual : ExcelRow
    {
        
        public byte Unknown0 { get; set; }
        public byte Unknown1 { get; set; }
        public LazyRow< Action > Action { get; set; }
        public byte Unknown3 { get; set; }
        public uint Unknown4 { get; set; }
        public LazyRow< Guide > Guide { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            Action = new LazyRow< Action >( gameData, parser.ReadColumn< uint >( 2 ), language );
            Unknown3 = parser.ReadColumn< byte >( 3 );
            Unknown4 = parser.ReadColumn< uint >( 4 );
            Guide = new LazyRow< Guide >( gameData, parser.ReadColumn< ushort >( 5 ), language );
        }
    }
}