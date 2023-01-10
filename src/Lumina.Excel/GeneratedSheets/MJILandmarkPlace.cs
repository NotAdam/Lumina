// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MJILandmarkPlace", columnHash: 0x369fb53b )]
    public partial class MJILandmarkPlace : ExcelRow
    {
        
        public uint Unknown0 { get; set; }
        public LazyRow< EObjName > Name { get; set; }
        public LazyRow< ExportedSG > SGB { get; set; }
        public byte Unknown3 { get; set; }
        public short Unknown4 { get; set; }
        public short Unknown5 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< uint >( 0 );
            Name = new LazyRow< EObjName >( gameData, parser.ReadColumn< uint >( 1 ), language );
            SGB = new LazyRow< ExportedSG >( gameData, parser.ReadColumn< uint >( 2 ), language );
            Unknown3 = parser.ReadColumn< byte >( 3 );
            Unknown4 = parser.ReadColumn< short >( 4 );
            Unknown5 = parser.ReadColumn< short >( 5 );
        }
    }
}