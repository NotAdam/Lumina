using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GcArmyCaptureTactics", columnHash: 0x62bcfbad )]
    public class GcArmyCaptureTactics : IExcelRow
    {
        
        public LazyRow< Status > Name;
        public byte HP;
        public byte DamageDealt;
        public byte DamageReceived;
        public LazyRow< Addon > Tactic;
        public uint Icon;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = new LazyRow< Status >( lumina, parser.ReadColumn< int >( 0 ) );
            HP = parser.ReadColumn< byte >( 1 );
            DamageDealt = parser.ReadColumn< byte >( 2 );
            DamageReceived = parser.ReadColumn< byte >( 3 );
            Tactic = new LazyRow< Addon >( lumina, parser.ReadColumn< uint >( 4 ) );
            Icon = parser.ReadColumn< uint >( 5 );
        }
    }
}