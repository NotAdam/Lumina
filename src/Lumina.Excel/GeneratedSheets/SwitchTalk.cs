// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "SwitchTalk", columnHash: 0x4be042fe )]
    public class SwitchTalk : ExcelRow
    {
        
        public uint Unknown0;
        public bool Unknown1;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Unknown0 = parser.ReadColumn< uint >( 0 );
            Unknown1 = parser.ReadColumn< bool >( 1 );
        }
    }
}