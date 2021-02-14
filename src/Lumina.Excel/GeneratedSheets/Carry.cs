// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Carry", columnHash: 0x31e1f9e6 )]
    public class Carry : ExcelRow
    {
        
        public ulong Model;
        public byte Timeline;
        public byte Unknown2;
        public byte Unknown3;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Model = parser.ReadColumn< ulong >( 0 );
            Timeline = parser.ReadColumn< byte >( 1 );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            Unknown3 = parser.ReadColumn< byte >( 3 );
        }
    }
}