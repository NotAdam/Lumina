// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "SatisfactionArbitration", columnHash: 0x3f77b2e9 )]
    public class SatisfactionArbitration : ExcelRow
    {
        
        public byte Unknown0;
        public byte Unknown1;
        public LazyRow< Quest > Quest;
        public byte Unknown3;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            Quest = new LazyRow< Quest >( gameData, parser.ReadColumn< uint >( 2 ), language );
            Unknown3 = parser.ReadColumn< byte >( 3 );
        }
    }
}