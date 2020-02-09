namespace Lumina.Excel.GeneratedSheets
{
    [SheetName( "Achievement" )]
    public class Achievement : IExcelRow
    {
        // col: 1 offset: 0000
        public string Name;

        // col: 2 offset: 0004
        public string Description;

        // col: 5 offset: 0008
        public uint Item;

        // col: 9 offset: 000c
        public int Key;

        // col: 10 offset: 0010
        public int[] Data;

        // col: 4 offset: 0030
        public ushort Title;

        // col: 6 offset: 0032
        public ushort Icon;

        // col: 18 offset: 0034
        public ushort Order;

        // col: 0 offset: 0036
        public byte AchievementCategory;

        // col: 3 offset: 0037
        public byte Points;

        // col: 7 offset: 0038
        public byte unknown38;

        // col: 8 offset: 0039
        public byte Type;

        // col: 19 offset: 003a
        public byte Padding;

        // col: 20 offset: 003b
        public byte AchievementHideCondition;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 2 offset: 0004
            Description = parser.ReadOffset< string >( 0x4 );

            // col: 5 offset: 0008
            Item = parser.ReadOffset< uint >( 0x8 );

            // col: 9 offset: 000c
            Key = parser.ReadOffset< int >( 0xc );

            // col: 10 offset: 0010
            Data = new int[8];
            Data[0] = parser.ReadOffset< int >( 0x10 );
            Data[1] = parser.ReadOffset< int >( 0x14 );
            Data[2] = parser.ReadOffset< int >( 0x18 );
            Data[3] = parser.ReadOffset< int >( 0x1c );
            Data[4] = parser.ReadOffset< int >( 0x20 );
            Data[5] = parser.ReadOffset< int >( 0x24 );
            Data[6] = parser.ReadOffset< int >( 0x28 );
            Data[7] = parser.ReadOffset< int >( 0x2c );

            // col: 4 offset: 0030
            Title = parser.ReadOffset< ushort >( 0x30 );

            // col: 6 offset: 0032
            Icon = parser.ReadOffset< ushort >( 0x32 );

            // col: 18 offset: 0034
            Order = parser.ReadOffset< ushort >( 0x34 );

            // col: 0 offset: 0036
            AchievementCategory = parser.ReadOffset< byte >( 0x36 );

            // col: 3 offset: 0037
            Points = parser.ReadOffset< byte >( 0x37 );

            // col: 7 offset: 0038
            unknown38 = parser.ReadOffset< byte >( 0x38 );

            // col: 8 offset: 0039
            Type = parser.ReadOffset< byte >( 0x39 );

            // col: 19 offset: 003a
            Padding = parser.ReadOffset< byte >( 0x3a );

            // col: 20 offset: 003b
            AchievementHideCondition = parser.ReadOffset< byte >( 0x3b );


        }
    }
}
