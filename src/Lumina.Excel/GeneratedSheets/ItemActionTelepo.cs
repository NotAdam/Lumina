// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ItemActionTelepo", columnHash: 0x5d58cc84 )]
    public partial class ItemActionTelepo : ExcelRow
    {
        
        public uint Requirement { get; set; }
        public LazyRow< LogMessage > DenyMessage { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Requirement = parser.ReadColumn< uint >( 0 );
            DenyMessage = new LazyRow< LogMessage >( gameData, parser.ReadColumn< uint >( 1 ), language );
        }
    }
}