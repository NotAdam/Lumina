// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ModelSkeleton", columnHash: 0x94cc54f1 )]
    public class ModelSkeleton : ExcelRow
    {
        
        public float Radius;
        public float Height;
        public float VFXScale;
        public ushort Unknown3;
        public ushort Unknown4;
        public ushort Unknown5;
        public ushort Unknown6;
        public ushort Unknown7;
        public ushort Unknown8;
        public ushort Unknown9;
        public ushort Unknown10;
        public float FloatHeight;
        public float FloatDown;
        public ushort FloatUp;
        public byte Unknown14;
        public bool MotionBlendType;
        public byte LoopFlySE;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

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