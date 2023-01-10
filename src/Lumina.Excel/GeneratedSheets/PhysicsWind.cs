// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PhysicsWind", columnHash: 0x3bc4120f )]
    public partial class PhysicsWind : ExcelRow
    {
        
        public float Threshold { get; set; }
        public float Amplitude { get; set; }
        public float AmplitudeFrequency { get; set; }
        public float PowerMin { get; set; }
        public float PowerMax { get; set; }
        public float PowerFrequency { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Threshold = parser.ReadColumn< float >( 0 );
            Amplitude = parser.ReadColumn< float >( 1 );
            AmplitudeFrequency = parser.ReadColumn< float >( 2 );
            PowerMin = parser.ReadColumn< float >( 3 );
            PowerMax = parser.ReadColumn< float >( 4 );
            PowerFrequency = parser.ReadColumn< float >( 5 );
        }
    }
}