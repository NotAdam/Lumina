// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DpsChallengeTransient", columnHash: 0xd870e208 )]
    public partial class DpsChallengeTransient : ExcelRow
    {
        
        public LazyRow< InstanceContent > InstanceContent { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            InstanceContent = new LazyRow< InstanceContent >( gameData, parser.ReadColumn< ushort >( 0 ), language );
        }
    }
}