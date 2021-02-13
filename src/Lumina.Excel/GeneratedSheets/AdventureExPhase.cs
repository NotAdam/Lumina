// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AdventureExPhase", columnHash: 0x2ebeea9f )]
    public class AdventureExPhase : ExcelRow
    {
        
        public LazyRow< Quest > Quest;
        public LazyRow< Adventure > AdventureBegin;
        public LazyRow< Adventure > AdventureEnd;
        public byte Unknown3;
        public uint Unknown4;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Quest = new LazyRow< Quest >( lumina, parser.ReadColumn< uint >( 0 ), language );
            AdventureBegin = new LazyRow< Adventure >( lumina, parser.ReadColumn< uint >( 1 ), language );
            AdventureEnd = new LazyRow< Adventure >( lumina, parser.ReadColumn< uint >( 2 ), language );
            Unknown3 = parser.ReadColumn< byte >( 3 );
            Unknown4 = parser.ReadColumn< uint >( 4 );
        }
    }
}