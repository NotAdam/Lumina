// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MacroIconRedirectOld", columnHash: 0x5c9aa6b3 )]
    public partial class MacroIconRedirectOld : ExcelRow
    {
        
        public uint IconOld { get; set; }
        public int IconNew { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            IconOld = parser.ReadColumn< uint >( 0 );
            IconNew = parser.ReadColumn< int >( 1 );
        }
    }
}