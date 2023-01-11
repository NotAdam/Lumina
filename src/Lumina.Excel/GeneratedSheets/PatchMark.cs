// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PatchMark", columnHash: 0x4b87e076 )]
    public partial class PatchMark : ExcelRow
    {
        
        public sbyte Category { get; set; }
        public byte SubCategoryType { get; set; }
        public ushort SubCategory { get; set; }
        public byte Unknown3 { get; set; }
        public uint Unknown4 { get; set; }
        public uint MarkID { get; set; }
        public byte Version { get; set; }
        public ushort Unknown7 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Category = parser.ReadColumn< sbyte >( 0 );
            SubCategoryType = parser.ReadColumn< byte >( 1 );
            SubCategory = parser.ReadColumn< ushort >( 2 );
            Unknown3 = parser.ReadColumn< byte >( 3 );
            Unknown4 = parser.ReadColumn< uint >( 4 );
            MarkID = parser.ReadColumn< uint >( 5 );
            Version = parser.ReadColumn< byte >( 6 );
            Unknown7 = parser.ReadColumn< ushort >( 7 );
        }
    }
}