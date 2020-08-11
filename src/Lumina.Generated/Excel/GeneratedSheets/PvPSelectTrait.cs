// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PvPSelectTrait", columnHash: 0xbddf8130 )]
    public class PvPSelectTrait : IExcelRow
    {
        
        public string Effect;
        public uint Icon;
        public short Value;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Effect = parser.ReadColumn< string >( 0 );
            Icon = parser.ReadColumn< uint >( 1 );
            Value = parser.ReadColumn< short >( 2 );
        }
    }
}