// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CustomTalk", columnHash: 0x2a751293 )]
    public class CustomTalk : ExcelRow
    {
        
        public uint IconActor;
        public uint IconMap;
        public SeString Name;
        public SeString[] ScriptInstruction;
        public uint[] ScriptArg;
        public bool Unknown63;
        public SeString Unknown64;
        public SeString Unknown65;
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
        public bool Unknown54;
        public bool Unknown78;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

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
            Unknown64 = parser.ReadColumn< SeString >( 64 );
            Unknown65 = parser.ReadColumn< SeString >( 65 );
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
            Unknown54 = parser.ReadColumn< bool >( 77 );
            Unknown78 = parser.ReadColumn< bool >( 78 );
        }
    }
}