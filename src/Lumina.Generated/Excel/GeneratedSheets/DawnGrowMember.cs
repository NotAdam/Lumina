using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DawnGrowMember", columnHash: 0xa0995e80 )]
    public class DawnGrowMember : IExcelRow
    {
        
        public LazyRow< ENpcResident > Member;
        public uint ImageName;
        public uint BigImageOld;
        public uint BigImageNew;
        public uint SmallImageOld;
        public uint SmallImageNew;
        public LazyRow< DawnMemberUIParam > Class;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Member = new LazyRow< ENpcResident >( lumina, parser.ReadColumn< uint >( 0 ) );
            ImageName = parser.ReadColumn< uint >( 1 );
            BigImageOld = parser.ReadColumn< uint >( 2 );
            BigImageNew = parser.ReadColumn< uint >( 3 );
            SmallImageOld = parser.ReadColumn< uint >( 4 );
            SmallImageNew = parser.ReadColumn< uint >( 5 );
            Class = new LazyRow< DawnMemberUIParam >( lumina, parser.ReadColumn< byte >( 6 ) );
        }
    }
}