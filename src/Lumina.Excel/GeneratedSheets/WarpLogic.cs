// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "WarpLogic", columnHash: 0x78e83215 )]
    public partial class WarpLogic : ExcelRow
    {
        
        public uint Unknown0 { get; set; }
        public SeString WarpName { get; set; }
        public bool CanSkipCutscene { get; set; }
        public SeString[] Function { get; set; }
        public uint[] Argument { get; set; }
        public SeString Question { get; set; }
        public SeString ResponseYes { get; set; }
        public SeString ResponseNo { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< uint >( 0 );
            WarpName = parser.ReadColumn< SeString >( 1 );
            CanSkipCutscene = parser.ReadColumn< bool >( 2 );
            Function = new SeString[ 10 ];
            for( var i = 0; i < 10; i++ )
                Function[ i ] = parser.ReadColumn< SeString >( 3 + i );
            Argument = new uint[ 10 ];
            for( var i = 0; i < 10; i++ )
                Argument[ i ] = parser.ReadColumn< uint >( 13 + i );
            Question = parser.ReadColumn< SeString >( 23 );
            ResponseYes = parser.ReadColumn< SeString >( 24 );
            ResponseNo = parser.ReadColumn< SeString >( 25 );
        }
    }
}