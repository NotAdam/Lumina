// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GuidePage", columnHash: 0x5bfa8a4e )]
    public class GuidePage : ExcelRow
    {
        
        public byte Key;
        public uint Output;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Key = parser.ReadColumn< byte >( 0 );
            Output = parser.ReadColumn< uint >( 1 );
        }
    }
}