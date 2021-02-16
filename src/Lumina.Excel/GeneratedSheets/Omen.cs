// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Omen", columnHash: 0xd79b6c3f )]
    public class Omen : ExcelRow
    {
        
        public SeString Path;
        public SeString PathAlly;
        public byte Type;
        public bool RestrictYScale;
        public bool LargeScale;
        public sbyte Unknown5;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Path = parser.ReadColumn< SeString >( 0 );
            PathAlly = parser.ReadColumn< SeString >( 1 );
            Type = parser.ReadColumn< byte >( 2 );
            RestrictYScale = parser.ReadColumn< bool >( 3 );
            LargeScale = parser.ReadColumn< bool >( 4 );
            Unknown5 = parser.ReadColumn< sbyte >( 5 );
        }
    }
}