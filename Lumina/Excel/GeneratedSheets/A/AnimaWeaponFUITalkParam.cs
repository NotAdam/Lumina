using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AnimaWeaponFUITalkParam", columnHash: 0x9db0e48f )]
    public class AnimaWeaponFUITalkParam : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT


        // col: 00 offset: 0000
        public string Prologue;

        // col: 01 offset: 0004
        public string Epilogue;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Prologue = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            Epilogue = parser.ReadOffset< string >( 0x4 );


        }
    }
}