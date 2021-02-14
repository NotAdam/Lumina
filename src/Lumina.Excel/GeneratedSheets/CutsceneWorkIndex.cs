// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CutsceneWorkIndex", columnHash: 0xd870e208 )]
    public class CutsceneWorkIndex : ExcelRow
    {
        
        public ushort WorkIndex;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            WorkIndex = parser.ReadColumn< ushort >( 0 );
        }
    }
}