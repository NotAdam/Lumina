namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MateriaJoinRateGatherCraft", columnHash: 0xab31b42e )]
    public class MateriaJoinRateGatherCraft : IExcelRow
    {
        // column defs from Wed, 31 Jul 2019 22:24:05 GMT

        /* offset: 0000 col: 0
         *  name: [NQ]Overmeld%Slot
         *  repeat count: 4
         */

        /* offset: 0004 col: 1
         *  no SaintCoinach definition found
         */

        /* offset: 0008 col: 2
         *  no SaintCoinach definition found
         */

        /* offset: 000c col: 3
         *  no SaintCoinach definition found
         */

        /* offset: 0010 col: 4
         *  name: [HQ]Overmeld%Slot
         *  repeat count: 4
         */

        /* offset: 0014 col: 5
         *  no SaintCoinach definition found
         */

        /* offset: 0018 col: 6
         *  no SaintCoinach definition found
         */

        /* offset: 001c col: 7
         *  no SaintCoinach definition found
         */



        // col: 00 offset: 0000
        public float[] NQOvermeldPctSlot;

        // col: 04 offset: 0010
        public float[] HQOvermeldPctSlot;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            NQOvermeldPctSlot = new float[4];
            NQOvermeldPctSlot[0] = parser.ReadOffset< float >( 0x0 );
            NQOvermeldPctSlot[1] = parser.ReadOffset< float >( 0x4 );
            NQOvermeldPctSlot[2] = parser.ReadOffset< float >( 0x8 );
            NQOvermeldPctSlot[3] = parser.ReadOffset< float >( 0xc );

            // col: 4 offset: 0010
            HQOvermeldPctSlot = new float[4];
            HQOvermeldPctSlot[0] = parser.ReadOffset< float >( 0x10 );
            HQOvermeldPctSlot[1] = parser.ReadOffset< float >( 0x14 );
            HQOvermeldPctSlot[2] = parser.ReadOffset< float >( 0x18 );
            HQOvermeldPctSlot[3] = parser.ReadOffset< float >( 0x1c );


        }
    }
}