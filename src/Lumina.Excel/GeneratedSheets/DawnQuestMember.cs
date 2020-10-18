// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DawnQuestMember", columnHash: 0x6ce9409c )]
    public class DawnQuestMember : IExcelRow
    {
        
        public LazyRow< ENpcResident > Member;
        public uint ImageName;
        public uint BigImageOld;
        public uint BigImageNew;
        public LazyRow< DawnMemberUIParam > Class;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Member = new LazyRow< ENpcResident >( lumina, parser.ReadColumn< uint >( 0 ), language );
            ImageName = parser.ReadColumn< uint >( 1 );
            BigImageOld = parser.ReadColumn< uint >( 2 );
            BigImageNew = parser.ReadColumn< uint >( 3 );
            Class = new LazyRow< DawnMemberUIParam >( lumina, parser.ReadColumn< byte >( 4 ), language );
        }
    }
}