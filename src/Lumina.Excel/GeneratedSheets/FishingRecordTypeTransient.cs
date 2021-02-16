// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FishingRecordTypeTransient", columnHash: 0xda365c51 )]
    public class FishingRecordTypeTransient : ExcelRow
    {
        
        public int Image;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Image = parser.ReadColumn< int >( 0 );
        }
    }
}