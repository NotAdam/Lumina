namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CraftAction", columnHash: 0x6057073b )]
    public class CraftAction : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0000 col: 0
         *  name: Name
         *  type: 
         */

        /* offset: 0004 col: 1
         *  name: Description
         *  type: 
         */

        /* offset: 002c col: 2
         *  name: Animation{Start}
         *  type: 
         */

        /* offset: 002e col: 3
         *  name: Animation{End}
         *  type: 
         */

        /* offset: 0030 col: 4
         *  name: Icon
         *  type: 
         */

        /* offset: 0037 col: 5
         *  name: ClassJob
         *  type: 
         */

        /* offset: 0034 col: 6
         *  name: ClassJobCategory
         *  type: 
         */

        /* offset: 0035 col: 7
         *  name: ClassJobLevel
         *  type: 
         */

        /* offset: 0008 col: 8
         *  name: QuestRequirement
         *  type: 
         */

        /* offset: 0038 col: 9
         *  name: Specialist
         *  type: 
         */

        /* offset: 0032 col: 10
         *  no SaintCoinach definition found
         */

        /* offset: 0036 col: 11
         *  name: Cost
         *  type: 
         */

        /* offset: 000c col: 12
         *  name: CRP
         *  type: 
         */

        /* offset: 0010 col: 13
         *  name: BSM
         *  type: 
         */

        /* offset: 0014 col: 14
         *  name: ARM
         *  type: 
         */

        /* offset: 0018 col: 15
         *  name: GSM
         *  type: 
         */

        /* offset: 001c col: 16
         *  name: LTW
         *  type: 
         */

        /* offset: 0020 col: 17
         *  name: WVR
         *  type: 
         */

        /* offset: 0024 col: 18
         *  name: ALC
         *  type: 
         */

        /* offset: 0028 col: 19
         *  name: CUL
         *  type: 
         */



        // col: 00 offset: 0000
        public string Name;

        // col: 01 offset: 0004
        public string Description;

        // col: 08 offset: 0008
        public uint QuestRequirement;

        // col: 12 offset: 000c
        public int CRP;

        // col: 13 offset: 0010
        public int BSM;

        // col: 14 offset: 0014
        public int ARM;

        // col: 15 offset: 0018
        public int GSM;

        // col: 16 offset: 001c
        public int LTW;

        // col: 17 offset: 0020
        public int WVR;

        // col: 18 offset: 0024
        public int ALC;

        // col: 19 offset: 0028
        public int CUL;

        // col: 02 offset: 002c
        public ushort AnimationStart;

        // col: 03 offset: 002e
        public ushort AnimationEnd;

        // col: 04 offset: 0030
        public ushort Icon;

        // col: 10 offset: 0032
        public ushort unknown32;

        // col: 06 offset: 0034
        public byte ClassJobCategory;

        // col: 07 offset: 0035
        public byte ClassJobLevel;

        // col: 11 offset: 0036
        public byte Cost;

        // col: 05 offset: 0037
        public sbyte ClassJob;

        // col: 09 offset: 0038
        private byte packed38;
        public bool Specialist => ( packed38 & 0x1 ) == 0x1;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            Description = parser.ReadOffset< string >( 0x4 );

            // col: 8 offset: 0008
            QuestRequirement = parser.ReadOffset< uint >( 0x8 );

            // col: 12 offset: 000c
            CRP = parser.ReadOffset< int >( 0xc );

            // col: 13 offset: 0010
            BSM = parser.ReadOffset< int >( 0x10 );

            // col: 14 offset: 0014
            ARM = parser.ReadOffset< int >( 0x14 );

            // col: 15 offset: 0018
            GSM = parser.ReadOffset< int >( 0x18 );

            // col: 16 offset: 001c
            LTW = parser.ReadOffset< int >( 0x1c );

            // col: 17 offset: 0020
            WVR = parser.ReadOffset< int >( 0x20 );

            // col: 18 offset: 0024
            ALC = parser.ReadOffset< int >( 0x24 );

            // col: 19 offset: 0028
            CUL = parser.ReadOffset< int >( 0x28 );

            // col: 2 offset: 002c
            AnimationStart = parser.ReadOffset< ushort >( 0x2c );

            // col: 3 offset: 002e
            AnimationEnd = parser.ReadOffset< ushort >( 0x2e );

            // col: 4 offset: 0030
            Icon = parser.ReadOffset< ushort >( 0x30 );

            // col: 10 offset: 0032
            unknown32 = parser.ReadOffset< ushort >( 0x32 );

            // col: 6 offset: 0034
            ClassJobCategory = parser.ReadOffset< byte >( 0x34 );

            // col: 7 offset: 0035
            ClassJobLevel = parser.ReadOffset< byte >( 0x35 );

            // col: 11 offset: 0036
            Cost = parser.ReadOffset< byte >( 0x36 );

            // col: 5 offset: 0037
            ClassJob = parser.ReadOffset< sbyte >( 0x37 );

            // col: 9 offset: 0038
            packed38 = parser.ReadOffset< byte >( 0x38 );


        }
    }
}