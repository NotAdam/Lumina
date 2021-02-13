// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DeepDungeonStatus", columnHash: 0xdc23efe7 )]
    public class DeepDungeonStatus : ExcelRow
    {
        
        public LazyRow< ScreenImage > ScreenImage;
        public LazyRow< LogMessage > LogMessage;
        public LazyRow< DeepDungeonFloorEffectUI > Name;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            ScreenImage = new LazyRow< ScreenImage >( lumina, parser.ReadColumn< ushort >( 0 ), language );
            LogMessage = new LazyRow< LogMessage >( lumina, parser.ReadColumn< ushort >( 1 ), language );
            Name = new LazyRow< DeepDungeonFloorEffectUI >( lumina, parser.ReadColumn< ushort >( 2 ), language );
        }
    }
}