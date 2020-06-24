using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "EObj", columnHash: 0x9335c666 )]
    public class EObj : IExcelRow
    {
        
        public bool Unknown0;
        public bool Unknown1;
        public bool Unknown2;
        public bool Unknown3;
        public bool Unknown4;
        public bool Unknown5;
        public bool Unknown6;
        public bool Unknown7;
        public byte PopType;
        public uint Data;
        public byte Invisibility;
        public LazyRow< ExportedSG > SgbPath;
        public bool EyeCollision;
        public bool DirectorControl;
        public bool Target;
        public byte EventHighAddition;
        public bool Unknown16;
        public byte Unknown17;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< bool >( 0 );
            Unknown1 = parser.ReadColumn< bool >( 1 );
            Unknown2 = parser.ReadColumn< bool >( 2 );
            Unknown3 = parser.ReadColumn< bool >( 3 );
            Unknown4 = parser.ReadColumn< bool >( 4 );
            Unknown5 = parser.ReadColumn< bool >( 5 );
            Unknown6 = parser.ReadColumn< bool >( 6 );
            Unknown7 = parser.ReadColumn< bool >( 7 );
            PopType = parser.ReadColumn< byte >( 8 );
            Data = parser.ReadColumn< uint >( 9 );
            Invisibility = parser.ReadColumn< byte >( 10 );
            SgbPath = new LazyRow< ExportedSG >( lumina, parser.ReadColumn< ushort >( 11 ), language );
            EyeCollision = parser.ReadColumn< bool >( 12 );
            DirectorControl = parser.ReadColumn< bool >( 13 );
            Target = parser.ReadColumn< bool >( 14 );
            EventHighAddition = parser.ReadColumn< byte >( 15 );
            Unknown16 = parser.ReadColumn< bool >( 16 );
            Unknown17 = parser.ReadColumn< byte >( 17 );
        }
    }
}