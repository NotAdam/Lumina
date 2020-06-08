using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BGM", columnHash: 0xc9fc6953 )]
    public class BGM : IExcelRow
    {
        
        public string File;
        public byte Priority;
        public bool DisableRestartTimeOut;
        public bool DisableRestart;
        public bool PassEnd;
        public float DisableRestartResetTime;
        public byte SpecialMode;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

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