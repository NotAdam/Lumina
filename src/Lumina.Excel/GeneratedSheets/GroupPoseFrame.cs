// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GroupPoseFrame", columnHash: 0x1771561e )]
    public class GroupPoseFrame : IExcelRow
    {
        
        public int Unknown0;
        public int Image;
        public SeString GridText;
        public int Unknown3;
        public uint Unknown4;
        public byte Unknown5;
        public int Unknown54;
        public SeString Text;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< int >( 0 );
            Image = parser.ReadColumn< int >( 1 );
            GridText = parser.ReadColumn< SeString >( 2 );
            Unknown3 = parser.ReadColumn< int >( 3 );
            Unknown4 = parser.ReadColumn< uint >( 4 );
            Unknown5 = parser.ReadColumn< byte >( 5 );
            Unknown54 = parser.ReadColumn< int >( 6 );
            Text = parser.ReadColumn< SeString >( 7 );
        }
    }
}