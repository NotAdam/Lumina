using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "SnipeTalk", columnHash: 0xcea69cac )]
    public class SnipeTalk : IExcelRow
    {
        
        public byte Unknown0;
        public byte Unknown1;
        public LazyRow< SnipeTalkName > Name;
        public string Text;
        public string Unknown4;
        public string Unknown5;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            Name = new LazyRow< SnipeTalkName >( lumina, parser.ReadColumn< ushort >( 2 ) );
            Text = parser.ReadColumn< string >( 3 );
            Unknown4 = parser.ReadColumn< string >( 4 );
            Unknown5 = parser.ReadColumn< string >( 5 );
        }
    }
}