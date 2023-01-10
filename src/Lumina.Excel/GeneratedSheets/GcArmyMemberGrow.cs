// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GcArmyMemberGrow", columnHash: 0xaf66261c )]
    public partial class GcArmyMemberGrow : ExcelRow
    {
        
        public LazyRow< ClassJob > ClassJob { get; set; }
        public LazyRow< Item > ClassBook { get; set; }
        public LazyRow< GcArmyEquipPreset >[] EquipPreset { get; set; }
        public ushort Unknown62 { get; set; }
        public byte[] Physical { get; set; }
        public byte Unknown123 { get; set; }
        public byte[] Mental { get; set; }
        public byte Unknown184 { get; set; }
        public byte[] Tactical { get; set; }
        public byte Unknown245 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            ClassJob = new LazyRow< ClassJob >( gameData, parser.ReadColumn< byte >( 0 ), language );
            ClassBook = new LazyRow< Item >( gameData, parser.ReadColumn< int >( 1 ), language );
            EquipPreset = new LazyRow< GcArmyEquipPreset >[ 60 ];
            for( var i = 0; i < 60; i++ )
                EquipPreset[ i ] = new LazyRow< GcArmyEquipPreset >( gameData, parser.ReadColumn< ushort >( 2 + i ), language );
            Unknown62 = parser.ReadColumn< ushort >( 62 );
            Physical = new byte[ 60 ];
            for( var i = 0; i < 60; i++ )
                Physical[ i ] = parser.ReadColumn< byte >( 63 + i );
            Unknown123 = parser.ReadColumn< byte >( 123 );
            Mental = new byte[ 60 ];
            for( var i = 0; i < 60; i++ )
                Mental[ i ] = parser.ReadColumn< byte >( 124 + i );
            Unknown184 = parser.ReadColumn< byte >( 184 );
            Tactical = new byte[ 60 ];
            for( var i = 0; i < 60; i++ )
                Tactical[ i ] = parser.ReadColumn< byte >( 185 + i );
            Unknown245 = parser.ReadColumn< byte >( 245 );
        }
    }
}