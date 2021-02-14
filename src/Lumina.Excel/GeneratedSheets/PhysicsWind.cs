// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PhysicsWind", columnHash: 0x3bc4120f )]
    public class PhysicsWind : ExcelRow
    {
        
        public float Threshold;
        public float Amplitude;
        public float AmplitudeFrequency;
        public float PowerMin;
        public float PowerMax;
        public float PowerFrequency;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Threshold = parser.ReadColumn< float >( 0 );
            Amplitude = parser.ReadColumn< float >( 1 );
            AmplitudeFrequency = parser.ReadColumn< float >( 2 );
            PowerMin = parser.ReadColumn< float >( 3 );
            PowerMax = parser.ReadColumn< float >( 4 );
            PowerFrequency = parser.ReadColumn< float >( 5 );
        }
    }
}