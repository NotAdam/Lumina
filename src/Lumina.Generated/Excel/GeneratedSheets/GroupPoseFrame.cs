// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GroupPoseFrame", columnHash: 0x6499223f )]
    public class GroupPoseFrame : IExcelRow
    {
        
        public int Unknown0;
        public int Image;
        public string GridText;
        public int Unknown3;
        public uint Unknown4;
        public byte Unknown5;
        public string Text;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< int >( 0 );
            Image = parser.ReadColumn< int >( 1 );
            GridText = parser.ReadColumn< string >( 2 );
            Unknown3 = parser.ReadColumn< int >( 3 );
            Unknown4 = parser.ReadColumn< uint >( 4 );
            Unknown5 = parser.ReadColumn< byte >( 5 );
            Text = parser.ReadColumn< string >( 6 );
        }
    }
}