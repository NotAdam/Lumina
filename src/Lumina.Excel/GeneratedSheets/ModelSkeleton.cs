// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ModelSkeleton", columnHash: 0x94cc54f1 )]
    public partial class ModelSkeleton : ExcelRow
    {
        
        public float Radius { get; set; }
        public float Height { get; set; }
        public float VFXScale { get; set; }
        public ushort Unknown3 { get; set; }
        public ushort Unknown4 { get; set; }
        public ushort Unknown5 { get; set; }
        public ushort Unknown6 { get; set; }
        public ushort Unknown7 { get; set; }
        public ushort Unknown8 { get; set; }
        public ushort Unknown9 { get; set; }
        public ushort Unknown10 { get; set; }
        public float FloatHeight { get; set; }
        public float FloatDown { get; set; }
        public ushort FloatUp { get; set; }
        public byte Unknown14 { get; set; }
        public bool MotionBlendType { get; set; }
        public byte LoopFlySE { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Radius = parser.ReadColumn< float >( 0 );
            Height = parser.ReadColumn< float >( 1 );
            VFXScale = parser.ReadColumn< float >( 2 );
            Unknown3 = parser.ReadColumn< ushort >( 3 );
            Unknown4 = parser.ReadColumn< ushort >( 4 );
            Unknown5 = parser.ReadColumn< ushort >( 5 );
            Unknown6 = parser.ReadColumn< ushort >( 6 );
            Unknown7 = parser.ReadColumn< ushort >( 7 );
            Unknown8 = parser.ReadColumn< ushort >( 8 );
            Unknown9 = parser.ReadColumn< ushort >( 9 );
            Unknown10 = parser.ReadColumn< ushort >( 10 );
            FloatHeight = parser.ReadColumn< float >( 11 );
            FloatDown = parser.ReadColumn< float >( 12 );
            FloatUp = parser.ReadColumn< ushort >( 13 );
            Unknown14 = parser.ReadColumn< byte >( 14 );
            MotionBlendType = parser.ReadColumn< bool >( 15 );
            LoopFlySE = parser.ReadColumn< byte >( 16 );
        }
    }
}