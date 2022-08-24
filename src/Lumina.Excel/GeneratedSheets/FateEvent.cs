// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FateEvent", columnHash: 0x0f779649 )]
    public partial class FateEvent : ExcelRow
    {
        
        public byte[] Turn { get; set; }
        public uint[] Gesture { get; set; }
        public int[] LipSync { get; set; }
        public int[] Facial { get; set; }
        public int[] Shape { get; set; }
        public bool[] IsAutoShake { get; set; }
        public byte[] WidgetType { get; set; }
        public SeString[] Text { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Turn = new byte[ 8 ];
            for( var i = 0; i < 8; i++ )
                Turn[ i ] = parser.ReadColumn< byte >( 0 + i );
            Gesture = new uint[ 8 ];
            for( var i = 0; i < 8; i++ )
                Gesture[ i ] = parser.ReadColumn< uint >( 8 + i );
            LipSync = new int[ 8 ];
            for( var i = 0; i < 8; i++ )
                LipSync[ i ] = parser.ReadColumn< int >( 16 + i );
            Facial = new int[ 8 ];
            for( var i = 0; i < 8; i++ )
                Facial[ i ] = parser.ReadColumn< int >( 24 + i );
            Shape = new int[ 8 ];
            for( var i = 0; i < 8; i++ )
                Shape[ i ] = parser.ReadColumn< int >( 32 + i );
            IsAutoShake = new bool[ 8 ];
            for( var i = 0; i < 8; i++ )
                IsAutoShake[ i ] = parser.ReadColumn< bool >( 40 + i );
            WidgetType = new byte[ 8 ];
            for( var i = 0; i < 8; i++ )
                WidgetType[ i ] = parser.ReadColumn< byte >( 48 + i );
            Text = new SeString[ 8 ];
            for( var i = 0; i < 8; i++ )
                Text[ i ] = parser.ReadColumn< SeString >( 56 + i );
        }
    }
}