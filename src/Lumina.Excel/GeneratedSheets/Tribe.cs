// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Tribe", columnHash: 0xe74759fb )]
    public class Tribe : IExcelRow
    {
        
        public string Masculine;
        public string Feminine;
        public sbyte Hp;
        public sbyte Mp;
        public sbyte STR;
        public sbyte VIT;
        public sbyte DEX;
        public sbyte INT;
        public sbyte MND;
        public sbyte PIE;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Masculine = parser.ReadColumn< string >( 0 );
            Feminine = parser.ReadColumn< string >( 1 );
            Hp = parser.ReadColumn< sbyte >( 2 );
            Mp = parser.ReadColumn< sbyte >( 3 );
            STR = parser.ReadColumn< sbyte >( 4 );
            VIT = parser.ReadColumn< sbyte >( 5 );
            DEX = parser.ReadColumn< sbyte >( 6 );
            INT = parser.ReadColumn< sbyte >( 7 );
            MND = parser.ReadColumn< sbyte >( 8 );
            PIE = parser.ReadColumn< sbyte >( 9 );
        }
    }
}