// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ActionComboRoute", columnHash: 0xe732fd5b )]
    public partial class ActionComboRoute : ExcelRow
    {
        
        public SeString Name { get; set; }
        public sbyte Unknown1 { get; set; }
        public LazyRow< Action >[] Action { get; set; }
        public ushort Unknown6 { get; set; }
        public ushort Unknown7 { get; set; }
        public ushort Unknown8 { get; set; }
        public bool Unknown9 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            Unknown1 = parser.ReadColumn< sbyte >( 1 );
            Action = new LazyRow< Action >[ 4 ];
            for( var i = 0; i < 4; i++ )
                Action[ i ] = new LazyRow< Action >( gameData, parser.ReadColumn< ushort >( 2 + i ), language );
            Unknown6 = parser.ReadColumn< ushort >( 6 );
            Unknown7 = parser.ReadColumn< ushort >( 7 );
            Unknown8 = parser.ReadColumn< ushort >( 8 );
            Unknown9 = parser.ReadColumn< bool >( 9 );
        }
    }
}