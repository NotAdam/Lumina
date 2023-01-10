// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "EObj", columnHash: 0x82700e8d )]
    public partial class EObj : ExcelRow
    {
        
        public bool Unknown0 { get; set; }
        public bool Unknown1 { get; set; }
        public bool Unknown2 { get; set; }
        public bool Unknown3 { get; set; }
        public bool Unknown4 { get; set; }
        public bool Unknown5 { get; set; }
        public bool Unknown6 { get; set; }
        public bool Unknown7 { get; set; }
        public byte PopType { get; set; }
        public uint Data { get; set; }
        public byte Invisibility { get; set; }
        public LazyRow< ExportedSG > SgbPath { get; set; }
        public bool EyeCollision { get; set; }
        public bool DirectorControl { get; set; }
        public bool Target { get; set; }
        public byte EventHighAddition { get; set; }
        public bool Unknown16 { get; set; }
        public byte Unknown17 { get; set; }
        public bool AddedIn53 { get; set; }
        public bool Unknown19 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

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
            SgbPath = new LazyRow< ExportedSG >( gameData, parser.ReadColumn< ushort >( 11 ), language );
            EyeCollision = parser.ReadColumn< bool >( 12 );
            DirectorControl = parser.ReadColumn< bool >( 13 );
            Target = parser.ReadColumn< bool >( 14 );
            EventHighAddition = parser.ReadColumn< byte >( 15 );
            Unknown16 = parser.ReadColumn< bool >( 16 );
            Unknown17 = parser.ReadColumn< byte >( 17 );
            AddedIn53 = parser.ReadColumn< bool >( 18 );
            Unknown19 = parser.ReadColumn< bool >( 19 );
        }
    }
}