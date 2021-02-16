// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GardeningSeed", columnHash: 0xa8a6cb9c )]
    public class GardeningSeed : ExcelRow
    {
        
        public LazyRow< Item > Item;
        public ushort ModelID;
        public uint Icon;
        public bool SE;
        public bool Unknown4;
        public byte Unknown5;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Item = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 0 ), language );
            ModelID = parser.ReadColumn< ushort >( 1 );
            Icon = parser.ReadColumn< uint >( 2 );
            SE = parser.ReadColumn< bool >( 3 );
            Unknown4 = parser.ReadColumn< bool >( 4 );
            Unknown5 = parser.ReadColumn< byte >( 5 );
        }
    }
}