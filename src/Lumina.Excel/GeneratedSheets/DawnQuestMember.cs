// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DawnQuestMember", columnHash: 0x9a909078 )]
    public partial class DawnQuestMember : ExcelRow
    {
        
        public ushort Unknown0 { get; set; }
        public byte Unknown1 { get; set; }
        public LazyRow< ENpcResident > Member { get; set; }
        public uint BigImageOld { get; set; }
        public uint BigImageNew { get; set; }
        public LazyRow< DawnMemberUIParam > Class { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< ushort >( 0 );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            Member = new LazyRow< ENpcResident >( gameData, parser.ReadColumn< uint >( 2 ), language );
            BigImageOld = parser.ReadColumn< uint >( 3 );
            BigImageNew = parser.ReadColumn< uint >( 4 );
            Class = new LazyRow< DawnMemberUIParam >( gameData, parser.ReadColumn< byte >( 5 ), language );
        }
    }
}