// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AnimationLOD", columnHash: 0x261cfad0 )]
    public partial class AnimationLOD : ExcelRow
    {
        
        public float CameraDistance { get; set; }
        public float SampleInterval { get; set; }
        public sbyte BoneLOD { get; set; }
        public bool[] AnimationEnable { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            CameraDistance = parser.ReadColumn< float >( 0 );
            SampleInterval = parser.ReadColumn< float >( 1 );
            BoneLOD = parser.ReadColumn< sbyte >( 2 );
            AnimationEnable = new bool[ 8 ];
            for( var i = 0; i < 8; i++ )
                AnimationEnable[ i ] = parser.ReadColumn< bool >( 3 + i );
        }
    }
}