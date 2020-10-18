// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AnimaWeapon5SpiritTalkParam", columnHash: 0x9db0e48f )]
    public class AnimaWeapon5SpiritTalkParam : IExcelRow
    {
        
        public SeString Prologue;
        public SeString Epilogue;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Prologue = parser.ReadColumn< SeString >( 0 );
            Epilogue = parser.ReadColumn< SeString >( 1 );
        }
    }
}