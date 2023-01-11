// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MJIGatheringObject", columnHash: 0xa8f1a0a0 )]
    public partial class MJIGatheringObject : ExcelRow
    {
        
        public LazyRow< ExportedSG > SGB { get; set; }
        public uint MapIcon { get; set; }
        public uint Unknown2 { get; set; }
        public LazyRow< EObjName > Name { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            SGB = new LazyRow< ExportedSG >( gameData, parser.ReadColumn< ushort >( 0 ), language );
            MapIcon = parser.ReadColumn< uint >( 1 );
            Unknown2 = parser.ReadColumn< uint >( 2 );
            Name = new LazyRow< EObjName >( gameData, parser.ReadColumn< uint >( 3 ), language );
        }
    }
}