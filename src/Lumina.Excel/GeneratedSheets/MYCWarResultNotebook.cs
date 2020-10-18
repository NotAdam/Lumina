// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MYCWarResultNotebook", columnHash: 0x3b1d3c28 )]
    public class MYCWarResultNotebook : IExcelRow
    {
        
        public byte Number;
        public int Icon;
        public int Image;
        public byte Rarity;
        public SeString NameJP;
        public SeString Name;
        public SeString Description;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Number = parser.ReadColumn< byte >( 0 );
            Icon = parser.ReadColumn< int >( 1 );
            Image = parser.ReadColumn< int >( 2 );
            Rarity = parser.ReadColumn< byte >( 3 );
            NameJP = parser.ReadColumn< SeString >( 4 );
            Name = parser.ReadColumn< SeString >( 5 );
            Description = parser.ReadColumn< SeString >( 6 );
        }
    }
}