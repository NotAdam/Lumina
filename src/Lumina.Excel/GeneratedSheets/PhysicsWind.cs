// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PhysicsWind", columnHash: 0x3bc4120f )]
    public class PhysicsWind : IExcelRow
    {
        
        public float Threshold;
        public float Amplitude;
        public float AmplitudeFrequency;
        public float PowerMin;
        public float PowerMax;
        public float PowerFrequency;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Threshold = parser.ReadColumn< float >( 0 );
            Amplitude = parser.ReadColumn< float >( 1 );
            AmplitudeFrequency = parser.ReadColumn< float >( 2 );
            PowerMin = parser.ReadColumn< float >( 3 );
            PowerMax = parser.ReadColumn< float >( 4 );
            PowerFrequency = parser.ReadColumn< float >( 5 );
        }
    }
}