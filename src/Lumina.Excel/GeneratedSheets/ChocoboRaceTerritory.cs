// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ChocoboRaceTerritory", columnHash: 0x39e8d543 )]
    public class ChocoboRaceTerritory : IExcelRow
    {
        
        public LazyRow< GoldSaucerTextData > Name;
        public int Icon;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = new LazyRow< GoldSaucerTextData >( lumina, parser.ReadColumn< ushort >( 0 ), language );
            Icon = parser.ReadColumn< int >( 1 );
        }
    }
}