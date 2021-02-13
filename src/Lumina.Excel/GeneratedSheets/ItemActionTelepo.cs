// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ItemActionTelepo", columnHash: 0x5d58cc84 )]
    public class ItemActionTelepo : ExcelRow
    {
        
        public uint Requirement;
        public LazyRow< LogMessage > DenyMessage;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Requirement = parser.ReadColumn< uint >( 0 );
            DenyMessage = new LazyRow< LogMessage >( lumina, parser.ReadColumn< uint >( 1 ), language );
        }
    }
}