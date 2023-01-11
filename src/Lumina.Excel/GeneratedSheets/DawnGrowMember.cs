// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DawnGrowMember", columnHash: 0xa0995e80 )]
    public partial class DawnGrowMember : ExcelRow
    {
        
        public uint[] SelectImage { get; set; }
        public uint[] PortraitImage { get; set; }
        public LazyRow< DawnMemberUIParam > Class { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            SelectImage = new uint[ 3 ];
            for( var i = 0; i < 3; i++ )
                SelectImage[ i ] = parser.ReadColumn< uint >( 0 + i );
            PortraitImage = new uint[ 3 ];
            for( var i = 0; i < 3; i++ )
                PortraitImage[ i ] = parser.ReadColumn< uint >( 3 + i );
            Class = new LazyRow< DawnMemberUIParam >( gameData, parser.ReadColumn< byte >( 6 ), language );
        }
    }
}