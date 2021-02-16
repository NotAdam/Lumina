// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "TextCommand", columnHash: 0x5d4b4e4b )]
    public class TextCommand : ExcelRow
    {
        
        public byte Unknown0;
        public byte Unknown1;
        public sbyte Unknown2;
        public sbyte Unknown3;
        public sbyte Unknown4;
        public SeString Command;
        public SeString ShortCommand;
        public SeString Description;
        public SeString Alias;
        public SeString ShortAlias;
        public ushort Unknown10;
        public uint Unknown11;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            Unknown2 = parser.ReadColumn< sbyte >( 2 );
            Unknown3 = parser.ReadColumn< sbyte >( 3 );
            Unknown4 = parser.ReadColumn< sbyte >( 4 );
            Command = parser.ReadColumn< SeString >( 5 );
            ShortCommand = parser.ReadColumn< SeString >( 6 );
            Description = parser.ReadColumn< SeString >( 7 );
            Alias = parser.ReadColumn< SeString >( 8 );
            ShortAlias = parser.ReadColumn< SeString >( 9 );
            Unknown10 = parser.ReadColumn< ushort >( 10 );
            Unknown11 = parser.ReadColumn< uint >( 11 );
        }
    }
}