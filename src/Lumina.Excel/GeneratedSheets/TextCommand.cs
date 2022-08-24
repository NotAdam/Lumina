// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "TextCommand", columnHash: 0x5d4b4e4b )]
    public partial class TextCommand : ExcelRow
    {
        
        public byte Unknown0 { get; set; }
        public byte Unknown1 { get; set; }
        public sbyte Unknown2 { get; set; }
        public sbyte Unknown3 { get; set; }
        public sbyte Unknown4 { get; set; }
        public SeString Command { get; set; }
        public SeString ShortCommand { get; set; }
        public SeString Description { get; set; }
        public SeString Alias { get; set; }
        public SeString ShortAlias { get; set; }
        public LazyRow< TextCommandParam > Param { get; set; }
        public uint Unknown11 { get; set; }
        
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
            Param = new LazyRow< TextCommandParam >( gameData, parser.ReadColumn< ushort >( 10 ), language );
            Unknown11 = parser.ReadColumn< uint >( 11 );
        }
    }
}