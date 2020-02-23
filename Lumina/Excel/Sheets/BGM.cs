namespace Lumina.Excel.Sheets
{
    [Sheet( "BGM" )]
    public class BGM : IExcelRow
    {
        public string File { get; private set; }
        
        public byte Priority { get; private set; }
        
        public bool DisableRestartTimeOut { get; private set; }
        
        public bool DisableRestart { get; private set; }
        
        public bool PassEnd { get; private set; }
        
        public float DisableRestartResetTime { get; private set; }
        
        public byte SpecialMode { get; private set; }
        
        public int RowId { get; set; }
        public int SubRowId { get; set; }
        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            File = parser.ReadColumn< string >( 0 );
            Priority = parser.ReadColumn< byte >( 1 );
            DisableRestartTimeOut = parser.ReadColumn< bool >( 2 );
            DisableRestart = parser.ReadColumn< bool >( 3 );
            PassEnd = parser.ReadColumn< bool >( 4 );
            DisableRestartResetTime = parser.ReadColumn< float >( 5 );
            SpecialMode = parser.ReadColumn< byte >( 6 );
        }
    }
}