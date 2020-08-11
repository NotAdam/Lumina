// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Weather", columnHash: 0x02cf2541 )]
    public class Weather : IExcelRow
    {
        
        public int Icon;
        public string Name;
        public string Description;
        public string Unknown3;
        public string Unknown4;
        public string Unknown5;
        public string Unknown6;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Icon = parser.ReadColumn< int >( 0 );
            Name = parser.ReadColumn< string >( 1 );
            Description = parser.ReadColumn< string >( 2 );
            Unknown3 = parser.ReadColumn< string >( 3 );
            Unknown4 = parser.ReadColumn< string >( 4 );
            Unknown5 = parser.ReadColumn< string >( 5 );
            Unknown6 = parser.ReadColumn< string >( 6 );
        }
    }
}