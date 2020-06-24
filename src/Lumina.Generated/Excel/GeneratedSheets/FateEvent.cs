using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FateEvent", columnHash: 0xb047403f )]
    public class FateEvent : IExcelRow
    {
        
        public byte[] Turn;
        public uint[] Gesture;
        public int[] LipSync;
        public int[] Facial;
        public int[] Shape;
        public bool[] IsAutoShake;
        public byte[] WidgetType;
        public string[] Text;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

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
            Text = new string[ 8 ];
            for( var i = 0; i < 8; i++ )
                Text[ i ] = parser.ReadColumn< string >( 56 + i );
        }
    }
}