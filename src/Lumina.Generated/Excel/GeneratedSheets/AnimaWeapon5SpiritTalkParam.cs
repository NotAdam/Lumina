using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AnimaWeapon5SpiritTalkParam", columnHash: 0x9db0e48f )]
    public class AnimaWeapon5SpiritTalkParam : IExcelRow
    {
        
        public string Prologue;
        public string Epilogue;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Prologue = parser.ReadColumn< string >( 0 );
            Epilogue = parser.ReadColumn< string >( 1 );
        }
    }
}