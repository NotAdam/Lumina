namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PhysicsWind", columnHash: 0x3bc4120f )]
    public class PhysicsWind : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT

        /* offset: 0000 col: 0
         *  name: Threshold
         *  type: 
         */

        /* offset: 0004 col: 1
         *  name: Amplitude
         *  type: 
         */

        /* offset: 0008 col: 2
         *  name: AmplitudeFrequency
         *  type: 
         */

        /* offset: 000c col: 3
         *  name: PowerMin
         *  type: 
         */

        /* offset: 0010 col: 4
         *  name: PowerMax
         *  type: 
         */

        /* offset: 0014 col: 5
         *  name: PowerFrequency
         *  type: 
         */



        // col: 00 offset: 0000
        public float Threshold;

        // col: 01 offset: 0004
        public float Amplitude;

        // col: 02 offset: 0008
        public float AmplitudeFrequency;

        // col: 03 offset: 000c
        public float PowerMin;

        // col: 04 offset: 0010
        public float PowerMax;

        // col: 05 offset: 0014
        public float PowerFrequency;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Threshold = parser.ReadOffset< float >( 0x0 );

            // col: 1 offset: 0004
            Amplitude = parser.ReadOffset< float >( 0x4 );

            // col: 2 offset: 0008
            AmplitudeFrequency = parser.ReadOffset< float >( 0x8 );

            // col: 3 offset: 000c
            PowerMin = parser.ReadOffset< float >( 0xc );

            // col: 4 offset: 0010
            PowerMax = parser.ReadOffset< float >( 0x10 );

            // col: 5 offset: 0014
            PowerFrequency = parser.ReadOffset< float >( 0x14 );


        }
    }
}