using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GilShop", columnHash: 0xa0969241 )]
    public class GilShop : IExcelRow
    {
        
        public string Name;
        public uint Icon;
        public LazyRow< Quest > Quest;
        public LazyRow< DefaultTalk > AcceptTalk;
        public LazyRow< DefaultTalk > FailTalk;
        public bool Unknown5;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = parser.ReadColumn< string >( 0 );
            Icon = parser.ReadColumn< uint >( 1 );
            Quest = new LazyRow< Quest >( lumina, parser.ReadColumn< uint >( 2 ) );
            AcceptTalk = new LazyRow< DefaultTalk >( lumina, parser.ReadColumn< int >( 3 ) );
            FailTalk = new LazyRow< DefaultTalk >( lumina, parser.ReadColumn< int >( 4 ) );
            Unknown5 = parser.ReadColumn< bool >( 5 );
        }
    }
}