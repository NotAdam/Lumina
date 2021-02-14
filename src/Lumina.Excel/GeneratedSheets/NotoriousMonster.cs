// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "NotoriousMonster", columnHash: 0x307c9206 )]
    public class NotoriousMonster : ExcelRow
    {
        
        public LazyRow< BNpcBase > BNpcBase;
        public byte Rank;
        public LazyRow< BNpcName > BNpcName;
        public ushort Unknown3;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            BNpcBase = new LazyRow< BNpcBase >( lumina, parser.ReadColumn< int >( 0 ), language );
            Rank = parser.ReadColumn< byte >( 1 );
            BNpcName = new LazyRow< BNpcName >( lumina, parser.ReadColumn< uint >( 2 ), language );
            Unknown3 = parser.ReadColumn< ushort >( 3 );
        }
    }
}