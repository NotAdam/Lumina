// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MJIVillageAppearanceSG", columnHash: 0xfd578b22 )]
    public partial class MJIVillageAppearanceSG : ExcelRow
    {
        
        public LazyRow< ExportedSG >[] SGB { get; set; }
        public uint Unknown3 { get; set; }
        public uint Unknown4 { get; set; }
        public uint Unknown5 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            SGB = new LazyRow< ExportedSG >[ 3 ];
            for( var i = 0; i < 3; i++ )
                SGB[ i ] = new LazyRow< ExportedSG >( gameData, parser.ReadColumn< ushort >( 0 + i ), language );
            Unknown3 = parser.ReadColumn< uint >( 3 );
            Unknown4 = parser.ReadColumn< uint >( 4 );
            Unknown5 = parser.ReadColumn< uint >( 5 );
        }
    }
}