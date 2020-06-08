using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "TextCommand", columnHash: 0x5d4b4e4b )]
    public class TextCommand : IExcelRow
    {
        
        public byte Unknown0;
        public byte Unknown1;
        public sbyte Unknown2;
        public sbyte Unknown3;
        public sbyte Unknown4;
        public string Command;
        public string ShortCommand;
        public string Description;
        public string Alias;
        public string ShortAlias;
        public ushort Unknown10;
        public uint Unknown11;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            Unknown2 = parser.ReadColumn< sbyte >( 2 );
            Unknown3 = parser.ReadColumn< sbyte >( 3 );
            Unknown4 = parser.ReadColumn< sbyte >( 4 );
            Command = parser.ReadColumn< string >( 5 );
            ShortCommand = parser.ReadColumn< string >( 6 );
            Description = parser.ReadColumn< string >( 7 );
            Alias = parser.ReadColumn< string >( 8 );
            ShortAlias = parser.ReadColumn< string >( 9 );
            Unknown10 = parser.ReadColumn< ushort >( 10 );
            Unknown11 = parser.ReadColumn< uint >( 11 );
        }
    }
}