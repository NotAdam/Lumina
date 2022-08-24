// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CompanyCraftSequence", columnHash: 0x6d444cc1 )]
    public partial class CompanyCraftSequence : ExcelRow
    {
        
        public LazyRow< Item > ResultItem { get; set; }
        public int Category { get; set; }
        public LazyRow< CompanyCraftDraftCategory > CompanyCraftDraftCategory { get; set; }
        public LazyRow< CompanyCraftType > CompanyCraftType { get; set; }
        public LazyRow< CompanyCraftDraft > CompanyCraftDraft { get; set; }
        public LazyRow< CompanyCraftPart >[] CompanyCraftPart { get; set; }
        public uint Order { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            ResultItem = new LazyRow< Item >( gameData, parser.ReadColumn< int >( 0 ), language );
            Category = parser.ReadColumn< int >( 1 );
            CompanyCraftDraftCategory = new LazyRow< CompanyCraftDraftCategory >( gameData, parser.ReadColumn< int >( 2 ), language );
            CompanyCraftType = new LazyRow< CompanyCraftType >( gameData, parser.ReadColumn< int >( 3 ), language );
            CompanyCraftDraft = new LazyRow< CompanyCraftDraft >( gameData, parser.ReadColumn< int >( 4 ), language );
            CompanyCraftPart = new LazyRow< CompanyCraftPart >[ 8 ];
            for( var i = 0; i < 8; i++ )
                CompanyCraftPart[ i ] = new LazyRow< CompanyCraftPart >( gameData, parser.ReadColumn< ushort >( 5 + i ), language );
            Order = parser.ReadColumn< uint >( 13 );
        }
    }
}