// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DawnGrowMember", columnHash: 0xa0995e80 )]
    public class DawnGrowMember : ExcelRow
    {
        
        public LazyRow< ENpcResident > Member;
        public uint ImageName;
        public uint BigImageOld;
        public uint BigImageNew;
        public uint SmallImageOld;
        public uint SmallImageNew;
        public LazyRow< DawnMemberUIParam > Class;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Member = new LazyRow< ENpcResident >( gameData, parser.ReadColumn< uint >( 0 ), language );
            ImageName = parser.ReadColumn< uint >( 1 );
            BigImageOld = parser.ReadColumn< uint >( 2 );
            BigImageNew = parser.ReadColumn< uint >( 3 );
            SmallImageOld = parser.ReadColumn< uint >( 4 );
            SmallImageNew = parser.ReadColumn< uint >( 5 );
            Class = new LazyRow< DawnMemberUIParam >( gameData, parser.ReadColumn< byte >( 6 ), language );
        }
    }
}