// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ModelChara", columnHash: 0x8d35f5ed )]
    public partial class ModelChara : ExcelRow
    {
        
        public byte Type { get; set; }
        public ushort Model { get; set; }
        public byte Base { get; set; }
        public byte Variant { get; set; }
        public ushort SEPack { get; set; }
        public byte Unknown5 { get; set; }
        public bool Unknown6 { get; set; }
        public bool PapVariation { get; set; }
        public byte Unknown8 { get; set; }
        public sbyte Unknown9 { get; set; }
        public bool Unknown10 { get; set; }
        public bool Unknown11 { get; set; }
        public bool Unknown12 { get; set; }
        public bool Unknown13 { get; set; }
        public bool Unknown14 { get; set; }
        public byte Unknown15 { get; set; }
        public bool Unknown16 { get; set; }
        public byte Unknown17 { get; set; }
        public float Unknown18 { get; set; }
        public float Unknown19 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Type = parser.ReadColumn< byte >( 0 );
            Model = parser.ReadColumn< ushort >( 1 );
            Base = parser.ReadColumn< byte >( 2 );
            Variant = parser.ReadColumn< byte >( 3 );
            SEPack = parser.ReadColumn< ushort >( 4 );
            Unknown5 = parser.ReadColumn< byte >( 5 );
            Unknown6 = parser.ReadColumn< bool >( 6 );
            PapVariation = parser.ReadColumn< bool >( 7 );
            Unknown8 = parser.ReadColumn< byte >( 8 );
            Unknown9 = parser.ReadColumn< sbyte >( 9 );
            Unknown10 = parser.ReadColumn< bool >( 10 );
            Unknown11 = parser.ReadColumn< bool >( 11 );
            Unknown12 = parser.ReadColumn< bool >( 12 );
            Unknown13 = parser.ReadColumn< bool >( 13 );
            Unknown14 = parser.ReadColumn< bool >( 14 );
            Unknown15 = parser.ReadColumn< byte >( 15 );
            Unknown16 = parser.ReadColumn< bool >( 16 );
            Unknown17 = parser.ReadColumn< byte >( 17 );
            Unknown18 = parser.ReadColumn< float >( 18 );
            Unknown19 = parser.ReadColumn< float >( 19 );
        }
    }
}