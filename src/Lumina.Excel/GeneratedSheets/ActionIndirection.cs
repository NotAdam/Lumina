// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ActionIndirection", columnHash: 0xfde405db )]
    public class ActionIndirection : ExcelRow
    {
        
        public LazyRow< Action > Name { get; set; }
        public sbyte Unknown1 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = new LazyRow< Action >( gameData, parser.ReadColumn< int >( 0 ), language );
            Unknown1 = parser.ReadColumn< sbyte >( 1 );
        }
    }
}