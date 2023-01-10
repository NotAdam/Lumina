// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GilShop", columnHash: 0x4a239844 )]
    public partial class GilShop : ExcelRow
    {
        
        public SeString Name { get; set; }
        public uint Icon { get; set; }
        public LazyRow< Quest > Quest { get; set; }
        public LazyRow< DefaultTalk > AcceptTalk { get; set; }
        public LazyRow< DefaultTalk > FailTalk { get; set; }
        public bool Unknown5 { get; set; }
        public ushort Unknown6 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            Icon = parser.ReadColumn< uint >( 1 );
            Quest = new LazyRow< Quest >( gameData, parser.ReadColumn< uint >( 2 ), language );
            AcceptTalk = new LazyRow< DefaultTalk >( gameData, parser.ReadColumn< int >( 3 ), language );
            FailTalk = new LazyRow< DefaultTalk >( gameData, parser.ReadColumn< int >( 4 ), language );
            Unknown5 = parser.ReadColumn< bool >( 5 );
            Unknown6 = parser.ReadColumn< ushort >( 6 );
        }
    }
}