using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GeneralAction", columnHash: 0x5dffa8fa )]
    public class GeneralAction : IExcelRow
    {
        
        public string Name;
        public string Description;
        public byte Unknown2;
        public LazyRow< Action > Action;
        public ushort UnlockLink;
        public byte Recast;
        public byte UIPriority;
        public int Icon;
        public bool Unknown8;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = parser.ReadColumn< string >( 0 );
            Description = parser.ReadColumn< string >( 1 );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            Action = new LazyRow< Action >( lumina, parser.ReadColumn< ushort >( 3 ) );
            UnlockLink = parser.ReadColumn< ushort >( 4 );
            Recast = parser.ReadColumn< byte >( 5 );
            UIPriority = parser.ReadColumn< byte >( 6 );
            Icon = parser.ReadColumn< int >( 7 );
            Unknown8 = parser.ReadColumn< bool >( 8 );
        }
    }
}