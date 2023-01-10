// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ActionProcStatus", columnHash: 0xd870e208 )]
    public partial class ActionProcStatus : ExcelRow
    {
        
        public LazyRow< Status > Status { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Status = new LazyRow< Status >( gameData, parser.ReadColumn< ushort >( 0 ), language );
        }
    }
}