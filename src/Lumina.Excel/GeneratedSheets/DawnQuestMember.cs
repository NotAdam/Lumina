// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DawnQuestMember", columnHash: 0x6ce9409c )]
    public partial class DawnQuestMember : ExcelRow
    {
        
        public LazyRow< ENpcResident > Member { get; set; }
        public uint ImageName { get; set; }
        public uint BigImageOld { get; set; }
        public uint BigImageNew { get; set; }
        public LazyRow< DawnMemberUIParam > Class { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Member = new LazyRow< ENpcResident >( gameData, parser.ReadColumn< uint >( 0 ), language );
            ImageName = parser.ReadColumn< uint >( 1 );
            BigImageOld = parser.ReadColumn< uint >( 2 );
            BigImageNew = parser.ReadColumn< uint >( 3 );
            Class = new LazyRow< DawnMemberUIParam >( gameData, parser.ReadColumn< byte >( 4 ), language );
        }
    }
}