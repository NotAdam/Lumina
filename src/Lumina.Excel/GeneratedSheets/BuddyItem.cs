// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BuddyItem", columnHash: 0xfa9fc03d )]
    public class BuddyItem : ExcelRow
    {
        
        public LazyRow< Item > Item;
        public bool UseField;
        public bool UseTraining;
        public bool Unknown3;
        public byte Status;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Item = new LazyRow< Item >( gameData, parser.ReadColumn< ushort >( 0 ), language );
            UseField = parser.ReadColumn< bool >( 1 );
            UseTraining = parser.ReadColumn< bool >( 2 );
            Unknown3 = parser.ReadColumn< bool >( 3 );
            Status = parser.ReadColumn< byte >( 4 );
        }
    }
}