// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CustomTalk", columnHash: 0xd20fee6c )]
    public partial class CustomTalk : ExcelRow
    {
        
        public uint IconActor { get; set; }
        public uint IconMap { get; set; }
        public SeString Name { get; set; }
        public SeString[] ScriptInstruction { get; set; }
        public uint[] ScriptArg { get; set; }
        public bool Unknown63 { get; set; }
        public SeString MainOption { get; set; }
        public SeString SubOption { get; set; }
        public bool Unknown66 { get; set; }
        public bool Unknown67 { get; set; }
        public bool Unknown68 { get; set; }
        public bool Unknown69 { get; set; }
        public bool Unknown70 { get; set; }
        public bool Unknown71 { get; set; }
        public bool Unknown72 { get; set; }
        public bool Unknown73 { get; set; }
        public bool Unknown74 { get; set; }
        public uint SpecialLinks { get; set; }
        public byte Unknown76 { get; set; }
        public byte Unknown77 { get; set; }
        public bool Unknown78 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            IconActor = parser.ReadColumn< uint >( 0 );
            IconMap = parser.ReadColumn< uint >( 1 );
            Name = parser.ReadColumn< SeString >( 2 );
            ScriptInstruction = new SeString[ 30 ];
            for( var i = 0; i < 30; i++ )
                ScriptInstruction[ i ] = parser.ReadColumn< SeString >( 3 + i );
            ScriptArg = new uint[ 30 ];
            for( var i = 0; i < 30; i++ )
                ScriptArg[ i ] = parser.ReadColumn< uint >( 33 + i );
            Unknown63 = parser.ReadColumn< bool >( 63 );
            MainOption = parser.ReadColumn< SeString >( 64 );
            SubOption = parser.ReadColumn< SeString >( 65 );
            Unknown66 = parser.ReadColumn< bool >( 66 );
            Unknown67 = parser.ReadColumn< bool >( 67 );
            Unknown68 = parser.ReadColumn< bool >( 68 );
            Unknown69 = parser.ReadColumn< bool >( 69 );
            Unknown70 = parser.ReadColumn< bool >( 70 );
            Unknown71 = parser.ReadColumn< bool >( 71 );
            Unknown72 = parser.ReadColumn< bool >( 72 );
            Unknown73 = parser.ReadColumn< bool >( 73 );
            Unknown74 = parser.ReadColumn< bool >( 74 );
            SpecialLinks = parser.ReadColumn< uint >( 75 );
            Unknown76 = parser.ReadColumn< byte >( 76 );
            Unknown77 = parser.ReadColumn< byte >( 77 );
            Unknown78 = parser.ReadColumn< bool >( 78 );
        }
    }
}