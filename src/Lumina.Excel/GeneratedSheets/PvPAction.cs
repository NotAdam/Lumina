// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PvPAction", columnHash: 0x3818ca1d )]
    public partial class PvPAction : ExcelRow
    {
        
        public LazyRow< Action > Action { get; set; }
        public byte Unknown1 { get; set; }
        public ushort Unknown2 { get; set; }
        public ushort Unknown3 { get; set; }
        public ushort Unknown4 { get; set; }
        public bool[] GrandCompany { get; set; }
        public byte Unknown8 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Action = new LazyRow< Action >( gameData, parser.ReadColumn< ushort >( 0 ), language );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            Unknown2 = parser.ReadColumn< ushort >( 2 );
            Unknown3 = parser.ReadColumn< ushort >( 3 );
            Unknown4 = parser.ReadColumn< ushort >( 4 );
            GrandCompany = new bool[ 3 ];
            for( var i = 0; i < 3; i++ )
                GrandCompany[ i ] = parser.ReadColumn< bool >( 5 + i );
            Unknown8 = parser.ReadColumn< byte >( 8 );
        }
    }
}