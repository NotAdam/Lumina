// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ContentExAction", columnHash: 0x8690a89e )]
    public class ContentExAction : ExcelRow
    {
        
        public LazyRow< Action > Name;
        public uint Unknown1;
        public byte Charges;
        public byte Unknown3;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Name = new LazyRow< Action >( lumina, parser.ReadColumn< uint >( 0 ), language );
            Unknown1 = parser.ReadColumn< uint >( 1 );
            Charges = parser.ReadColumn< byte >( 2 );
            Unknown3 = parser.ReadColumn< byte >( 3 );
        }
    }
}