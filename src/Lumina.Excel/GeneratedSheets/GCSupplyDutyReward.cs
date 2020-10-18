// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GCSupplyDutyReward", columnHash: 0x6be0e840 )]
    public class GCSupplyDutyReward : IExcelRow
    {
        
        public uint ExperienceSupply;
        public uint ExperienceProvisioning;
        public uint SealsExpertDelivery;
        public uint SealsSupply;
        public uint SealsProvisioning;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            ExperienceSupply = parser.ReadColumn< uint >( 0 );
            ExperienceProvisioning = parser.ReadColumn< uint >( 1 );
            SealsExpertDelivery = parser.ReadColumn< uint >( 2 );
            SealsSupply = parser.ReadColumn< uint >( 3 );
            SealsProvisioning = parser.ReadColumn< uint >( 4 );
        }
    }
}