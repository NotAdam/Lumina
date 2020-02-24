namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GCSupplyDutyReward", columnHash: 0x6be0e840 )]
    public class GCSupplyDutyReward : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0000 col: 0
         *  name: Experience{Supply}
         *  type: 
         */

        /* offset: 0004 col: 1
         *  name: Experience{Provisioning}
         *  type: 
         */

        /* offset: 0008 col: 2
         *  name: Seals{ExpertDelivery}
         *  type: 
         */

        /* offset: 000c col: 3
         *  name: Seals{Supply}
         *  type: 
         */

        /* offset: 0010 col: 4
         *  name: Seals{Provisioning}
         *  type: 
         */



        // col: 00 offset: 0000
        public uint ExperienceSupply;

        // col: 01 offset: 0004
        public uint ExperienceProvisioning;

        // col: 02 offset: 0008
        public uint SealsExpertDelivery;

        // col: 03 offset: 000c
        public uint SealsSupply;

        // col: 04 offset: 0010
        public uint SealsProvisioning;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            ExperienceSupply = parser.ReadOffset< uint >( 0x0 );

            // col: 1 offset: 0004
            ExperienceProvisioning = parser.ReadOffset< uint >( 0x4 );

            // col: 2 offset: 0008
            SealsExpertDelivery = parser.ReadOffset< uint >( 0x8 );

            // col: 3 offset: 000c
            SealsSupply = parser.ReadOffset< uint >( 0xc );

            // col: 4 offset: 0010
            SealsProvisioning = parser.ReadOffset< uint >( 0x10 );


        }
    }
}