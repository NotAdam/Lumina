// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MJIRank", columnHash: 0x929748f4 )]
    public partial class MJIRank : ExcelRow
    {
        
        public uint ExpToNext { get; set; }
        public byte Unknown1 { get; set; }
        public LazyRow< LogMessage >[] LogMessage { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            ExpToNext = parser.ReadColumn< uint >( 0 );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            LogMessage = new LazyRow< LogMessage >[ 3 ];
            for( var i = 0; i < 3; i++ )
                LogMessage[ i ] = new LazyRow< LogMessage >( gameData, parser.ReadColumn< uint >( 2 + i ), language );
        }
    }
}