// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ResistanceWeaponAdjust", columnHash: 0x8fc095f4 )]
    public partial class ResistanceWeaponAdjust : ExcelRow
    {
        
        public ushort MaxTotalStats { get; set; }
        public ushort MaxEachStat { get; set; }
        public LazyRow< BaseParam >[] BaseParam { get; set; }
        public uint Image { get; set; }
        public byte Unknown7 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            MaxTotalStats = parser.ReadColumn< ushort >( 0 );
            MaxEachStat = parser.ReadColumn< ushort >( 1 );
            BaseParam = new LazyRow< BaseParam >[ 4 ];
            for( var i = 0; i < 4; i++ )
                BaseParam[ i ] = new LazyRow< BaseParam >( gameData, parser.ReadColumn< byte >( 2 + i ), language );
            Image = parser.ReadColumn< uint >( 6 );
            Unknown7 = parser.ReadColumn< byte >( 7 );
        }
    }
}