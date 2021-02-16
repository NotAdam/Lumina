// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Weather", columnHash: 0x02cf2541 )]
    public class Weather : ExcelRow
    {
        
        public int Icon;
        public SeString Name;
        public SeString Description;
        public SeString Unknown3;
        public SeString Unknown4;
        public SeString Unknown5;
        public SeString Unknown6;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Icon = parser.ReadColumn< int >( 0 );
            Name = parser.ReadColumn< SeString >( 1 );
            Description = parser.ReadColumn< SeString >( 2 );
            Unknown3 = parser.ReadColumn< SeString >( 3 );
            Unknown4 = parser.ReadColumn< SeString >( 4 );
            Unknown5 = parser.ReadColumn< SeString >( 5 );
            Unknown6 = parser.ReadColumn< SeString >( 6 );
        }
    }
}