// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DawnGrowMember", columnHash: 0x1f26e13f )]
    public partial class DawnGrowMember : ExcelRow
    {
        
        public LazyRow< ENpcResident > Member { get; set; }
        public uint ImageName { get; set; }
        public uint BigImageOld { get; set; }
        public uint BigImageNew { get; set; }
        public uint SmallImageOld { get; set; }
        public uint SmallImageNew { get; set; }
        public LazyRow< DawnMemberUIParam > Class { get; set; }
        public byte Unknown7 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Member = new LazyRow< ENpcResident >( gameData, parser.ReadColumn< uint >( 0 ), language );
            ImageName = parser.ReadColumn< uint >( 1 );
            BigImageOld = parser.ReadColumn< uint >( 2 );
            BigImageNew = parser.ReadColumn< uint >( 3 );
            SmallImageOld = parser.ReadColumn< uint >( 4 );
            SmallImageNew = parser.ReadColumn< uint >( 5 );
            Class = new LazyRow< DawnMemberUIParam >( gameData, parser.ReadColumn< uint >( 6 ), language );
            Unknown7 = parser.ReadColumn< byte >( 7 );
        }
    }
}