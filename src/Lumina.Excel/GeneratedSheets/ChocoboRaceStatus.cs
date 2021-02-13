// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ChocoboRaceStatus", columnHash: 0xf8ab135e )]
    public class ChocoboRaceStatus : ExcelRow
    {
        
        public LazyRow< Status > Status;
        public ushort Unknown1;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Status = new LazyRow< Status >( lumina, parser.ReadColumn< int >( 0 ), language );
            Unknown1 = parser.ReadColumn< ushort >( 1 );
        }
    }
}