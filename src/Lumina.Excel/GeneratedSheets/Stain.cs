// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Stain", columnHash: 0xa2420e68 )]
    public class Stain : ExcelRow
    {
        
        public uint Color;
        public byte Shade;
        public byte Unknown2;
        public SeString Name;
        public bool Unknown4;
        public bool Unknown5;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Color = parser.ReadColumn< uint >( 0 );
            Shade = parser.ReadColumn< byte >( 1 );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            Name = parser.ReadColumn< SeString >( 3 );
            Unknown4 = parser.ReadColumn< bool >( 4 );
            Unknown5 = parser.ReadColumn< bool >( 5 );
        }
    }
}