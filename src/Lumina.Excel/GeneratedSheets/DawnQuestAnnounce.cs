// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DawnQuestAnnounce", columnHash: 0x0ef364de )]
    public partial class DawnQuestAnnounce : ExcelRow
    {
        
        public LazyRow< Quest > Quest { get; set; }
        public LazyRow< DawnContent > Content { get; set; }
        public LazyRow< ENpcResident >[] ENPC { get; set; }
        public uint Unknown8 { get; set; }
        public uint Unknown9 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Quest = new LazyRow< Quest >( gameData, parser.ReadColumn< uint >( 0 ), language );
            Content = new LazyRow< DawnContent >( gameData, parser.ReadColumn< byte >( 1 ), language );
            ENPC = new LazyRow< ENpcResident >[ 6 ];
            for( var i = 0; i < 6; i++ )
                ENPC[ i ] = new LazyRow< ENpcResident >( gameData, parser.ReadColumn< uint >( 2 + i ), language );
            Unknown8 = parser.ReadColumn< uint >( 8 );
            Unknown9 = parser.ReadColumn< uint >( 9 );
        }
    }
}