// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "RecommendContents", columnHash: 0xe79dd9d4 )]
    public class RecommendContents : IExcelRow
    {
        
        public LazyRow< Level > Level;
        public LazyRow< ClassJob > ClassJob;
        public byte MinLevel;
        public byte MaxLevel;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Level = new LazyRow< Level >( lumina, parser.ReadColumn< int >( 0 ), language );
            ClassJob = new LazyRow< ClassJob >( lumina, parser.ReadColumn< byte >( 1 ), language );
            MinLevel = parser.ReadColumn< byte >( 2 );
            MaxLevel = parser.ReadColumn< byte >( 3 );
        }
    }
}