// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "SnipeTalk", columnHash: 0xcea69cac )]
    public class SnipeTalk : ExcelRow
    {
        
        public byte Unknown0;
        public byte Unknown1;
        public LazyRow< SnipeTalkName > Name;
        public SeString Text;
        public SeString Unknown4;
        public SeString Unknown5;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            Name = new LazyRow< SnipeTalkName >( gameData, parser.ReadColumn< ushort >( 2 ), language );
            Text = parser.ReadColumn< SeString >( 3 );
            Unknown4 = parser.ReadColumn< SeString >( 4 );
            Unknown5 = parser.ReadColumn< SeString >( 5 );
        }
    }
}