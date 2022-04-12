// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DawnQuestMember", columnHash: 0x02b57802 )]
    public class DawnQuestMember : ExcelRow
    {
        
        public LazyRow< ENpcResident > Member { get; set; }
        public uint BigImageOld { get; set; }
        public uint BigImageNew { get; set; }
        public LazyRow< DawnMemberUIParam > Class { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Member = new LazyRow< ENpcResident >( gameData, parser.ReadColumn< uint >( 0 ), language );
            BigImageOld = parser.ReadColumn< uint >( 1 );
            BigImageNew = parser.ReadColumn< uint >( 2 );
            Class = new LazyRow< DawnMemberUIParam >( gameData, parser.ReadColumn< byte >( 3 ), language );
        }
    }
}