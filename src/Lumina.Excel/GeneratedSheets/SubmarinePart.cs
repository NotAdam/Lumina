// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "SubmarinePart", columnHash: 0xc971f464 )]
    public partial class SubmarinePart : ExcelRow
    {
        
        public byte Slot { get; set; }
        public byte Rank { get; set; }
        public byte Components { get; set; }
        public short Surveillance { get; set; }
        public short Retrieval { get; set; }
        public short Speed { get; set; }
        public short Range { get; set; }
        public short Favor { get; set; }
        public ushort Class { get; set; }
        public byte RepairMaterials { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Slot = parser.ReadColumn< byte >( 0 );
            Rank = parser.ReadColumn< byte >( 1 );
            Components = parser.ReadColumn< byte >( 2 );
            Surveillance = parser.ReadColumn< short >( 3 );
            Retrieval = parser.ReadColumn< short >( 4 );
            Speed = parser.ReadColumn< short >( 5 );
            Range = parser.ReadColumn< short >( 6 );
            Favor = parser.ReadColumn< short >( 7 );
            Class = parser.ReadColumn< ushort >( 8 );
            RepairMaterials = parser.ReadColumn< byte >( 9 );
        }
    }
}