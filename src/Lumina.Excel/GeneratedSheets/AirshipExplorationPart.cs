// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AirshipExplorationPart", columnHash: 0xc971f464 )]
    public class AirshipExplorationPart : ExcelRow
    {
        
        public byte Slot;
        public byte Rank;
        public byte Components;
        public short Surveillance;
        public short Retrieval;
        public short Speed;
        public short Range;
        public short Favor;
        public ushort Class;
        public byte RepairMaterials;
        

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