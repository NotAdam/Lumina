// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HowToPage", columnHash: 0x006e1eac )]
    public class HowToPage : IExcelRow
    {
        
        public byte Unknown0;
        public byte Unknown1;
        public int Image;
        public byte Unknown3;
        public string Unknown4;
        public string Unknown5;
        public string Unknown6;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            Image = parser.ReadColumn< int >( 2 );
            Unknown3 = parser.ReadColumn< byte >( 3 );
            Unknown4 = parser.ReadColumn< string >( 4 );
            Unknown5 = parser.ReadColumn< string >( 5 );
            Unknown6 = parser.ReadColumn< string >( 6 );
        }
    }
}