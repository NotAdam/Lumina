using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AnimaWeapon5Param", columnHash: 0x5eb59ccb )]
    public class AnimaWeapon5Param : IExcelRow
    {
        
        public LazyRow< BaseParam > BaseParam;
        public string Name;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            BaseParam = new LazyRow< BaseParam >( lumina, parser.ReadColumn< byte >( 0 ) );
            Name = parser.ReadColumn< string >( 1 );
        }
    }
}