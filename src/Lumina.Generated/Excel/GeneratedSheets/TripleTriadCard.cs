using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "TripleTriadCard", columnHash: 0x45c06ae0 )]
    public class TripleTriadCard : IExcelRow
    {
        
        public string Name;
        public sbyte Unknown1;
        public string Unknown2;
        public sbyte Unknown3;
        public sbyte StartsWithVowel;
        public sbyte Unknown5;
        public sbyte Unknown6;
        public sbyte Unknown7;
        public string Description;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = parser.ReadColumn< string >( 0 );
            Unknown1 = parser.ReadColumn< sbyte >( 1 );
            Unknown2 = parser.ReadColumn< string >( 2 );
            Unknown3 = parser.ReadColumn< sbyte >( 3 );
            StartsWithVowel = parser.ReadColumn< sbyte >( 4 );
            Unknown5 = parser.ReadColumn< sbyte >( 5 );
            Unknown6 = parser.ReadColumn< sbyte >( 6 );
            Unknown7 = parser.ReadColumn< sbyte >( 7 );
            Description = parser.ReadColumn< string >( 8 );
        }
    }
}