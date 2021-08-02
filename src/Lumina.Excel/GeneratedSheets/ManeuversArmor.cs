// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ManeuversArmor", columnHash: 0xc8b98ed4 )]
    public partial class ManeuversArmor : ExcelRow
    {
        
        public ushort Unknown0 { get; set; }
        public LazyRow< BNpcName >[] BNpcBase { get; set; }
        public byte Unknown3 { get; set; }
        public bool Unknown4 { get; set; }
        public uint[] Icon { get; set; }
        public SeString Unknown10 { get; set; }
        public SeString Unknown11 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< ushort >( 0 );
            BNpcBase = new LazyRow< BNpcName >[ 2 ];
            for( var i = 0; i < 2; i++ )
                BNpcBase[ i ] = new LazyRow< BNpcName >( gameData, parser.ReadColumn< uint >( 1 + i ), language );
            Unknown3 = parser.ReadColumn< byte >( 3 );
            Unknown4 = parser.ReadColumn< bool >( 4 );
            Icon = new uint[ 5 ];
            for( var i = 0; i < 5; i++ )
                Icon[ i ] = parser.ReadColumn< uint >( 5 + i );
            Unknown10 = parser.ReadColumn< SeString >( 10 );
            Unknown11 = parser.ReadColumn< SeString >( 11 );
        }
    }
}