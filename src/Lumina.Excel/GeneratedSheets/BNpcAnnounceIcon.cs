// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BNpcAnnounceIcon", columnHash: 0xdbf43666 )]
    public class BNpcAnnounceIcon : ExcelRow
    {
        
        public uint Icon;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Icon = parser.ReadColumn< uint >( 0 );
        }
    }
}