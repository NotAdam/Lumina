// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MacroIconRedirectOld", columnHash: 0x5c9aa6b3 )]
    public class MacroIconRedirectOld : ExcelRow
    {
        
        public uint IconOld;
        public int IconNew;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            IconOld = parser.ReadColumn< uint >( 0 );
            IconNew = parser.ReadColumn< int >( 1 );
        }
    }
}