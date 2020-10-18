// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AnimationLOD", columnHash: 0x261cfad0 )]
    public class AnimationLOD : IExcelRow
    {
        
        public float CameraDistance;
        public float SampleInterval;
        public sbyte BoneLOD;
        public bool[] AnimationEnable;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            CameraDistance = parser.ReadColumn< float >( 0 );
            SampleInterval = parser.ReadColumn< float >( 1 );
            BoneLOD = parser.ReadColumn< sbyte >( 2 );
            AnimationEnable = new bool[ 8 ];
            for( var i = 0; i < 8; i++ )
                AnimationEnable[ i ] = parser.ReadColumn< bool >( 3 + i );
        }
    }
}