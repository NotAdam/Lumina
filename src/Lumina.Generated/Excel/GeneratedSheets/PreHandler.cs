// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PreHandler", columnHash: 0x724c1806 )]
    public class PreHandler : IExcelRow
    {
        
        public string Unknown0;
        public uint Unknown1;
        public uint Target;
        public uint Unknown3;
        public uint Unknown4;
        public uint Unknown5;
        public byte Unknown6;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< string >( 0 );
            Unknown1 = parser.ReadColumn< uint >( 1 );
            Target = parser.ReadColumn< uint >( 2 );
            Unknown3 = parser.ReadColumn< uint >( 3 );
            Unknown4 = parser.ReadColumn< uint >( 4 );
            Unknown5 = parser.ReadColumn< uint >( 5 );
            Unknown6 = parser.ReadColumn< byte >( 6 );
        }
    }
}