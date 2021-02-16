// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AnimaWeaponIcon", columnHash: 0x63c20db3 )]
    public class AnimaWeaponIcon : ExcelRow
    {
        
        public int Hyperconductive;
        public int Reborn;
        public int Sharpened;
        public int Zodiac;
        public int ZodiacLux;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Hyperconductive = parser.ReadColumn< int >( 0 );
            Reborn = parser.ReadColumn< int >( 1 );
            Sharpened = parser.ReadColumn< int >( 2 );
            Zodiac = parser.ReadColumn< int >( 3 );
            ZodiacLux = parser.ReadColumn< int >( 4 );
        }
    }
}