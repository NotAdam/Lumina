// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "RideShootingTargetType", columnHash: 0x213f343d )]
    public partial class RideShootingTargetType : ExcelRow
    {
        
        public LazyRow< EObj > EObj { get; set; }
        public short Score { get; set; }
        public short Unknown2 { get; set; }
        public short Unknown3 { get; set; }
        public short Unknown4 { get; set; }
        public short Unknown5 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            EObj = new LazyRow< EObj >( gameData, parser.ReadColumn< uint >( 0 ), language );
            Score = parser.ReadColumn< short >( 1 );
            Unknown2 = parser.ReadColumn< short >( 2 );
            Unknown3 = parser.ReadColumn< short >( 3 );
            Unknown4 = parser.ReadColumn< short >( 4 );
            Unknown5 = parser.ReadColumn< short >( 5 );
        }
    }
}