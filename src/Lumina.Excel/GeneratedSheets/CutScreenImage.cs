// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CutScreenImage", columnHash: 0xe4a523cd )]
    public class CutScreenImage : ExcelRow
    {
        
        public short Type;
        public int Image;
        public short Unknown2;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Type = parser.ReadColumn< short >( 0 );
            Image = parser.ReadColumn< int >( 1 );
            Unknown2 = parser.ReadColumn< short >( 2 );
        }
    }
}