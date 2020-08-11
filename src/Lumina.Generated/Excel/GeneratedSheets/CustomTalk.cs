// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CustomTalk", columnHash: 0x74541fa8 )]
    public class CustomTalk : IExcelRow
    {
        
        public uint IconActor;
        public uint IconMap;
        public string Name;
        public string[] ScriptInstruction;
        public uint[] ScriptArg;
        public bool Unknown63;
        public string Unknown64;
        public string Unknown65;
        public bool Text;
        public bool Unknown67;
        public bool Unknown68;
        public bool Unknown69;
        public bool Unknown70;
        public bool Unknown71;
        public bool Unknown72;
        public bool Unknown73;
        public bool Unknown74;
        public uint Unknown75;
        public byte Unknown76;
        public bool Unknown77;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            IconActor = parser.ReadColumn< uint >( 0 );
            IconMap = parser.ReadColumn< uint >( 1 );
            Name = parser.ReadColumn< string >( 2 );
            ScriptInstruction = new string[ 30 ];
            for( var i = 0; i < 30; i++ )
                ScriptInstruction[ i ] = parser.ReadColumn< string >( 3 + i );
            ScriptArg = new uint[ 30 ];
            for( var i = 0; i < 30; i++ )
                ScriptArg[ i ] = parser.ReadColumn< uint >( 33 + i );
            Unknown63 = parser.ReadColumn< bool >( 63 );
            Unknown64 = parser.ReadColumn< string >( 64 );
            Unknown65 = parser.ReadColumn< string >( 65 );
            Text = parser.ReadColumn< bool >( 66 );
            Unknown67 = parser.ReadColumn< bool >( 67 );
            Unknown68 = parser.ReadColumn< bool >( 68 );
            Unknown69 = parser.ReadColumn< bool >( 69 );
            Unknown70 = parser.ReadColumn< bool >( 70 );
            Unknown71 = parser.ReadColumn< bool >( 71 );
            Unknown72 = parser.ReadColumn< bool >( 72 );
            Unknown73 = parser.ReadColumn< bool >( 73 );
            Unknown74 = parser.ReadColumn< bool >( 74 );
            Unknown75 = parser.ReadColumn< uint >( 75 );
            Unknown76 = parser.ReadColumn< byte >( 76 );
            Unknown77 = parser.ReadColumn< bool >( 77 );
        }
    }
}