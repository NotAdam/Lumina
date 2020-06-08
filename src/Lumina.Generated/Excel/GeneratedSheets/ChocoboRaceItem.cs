using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ChocoboRaceItem", columnHash: 0x7a3e01e7 )]
    public class ChocoboRaceItem : IExcelRow
    {
        
        public string Name;
        public string Description;
        public uint Icon;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = parser.ReadColumn< string >( 0 );
            Description = parser.ReadColumn< string >( 1 );
            Icon = parser.ReadColumn< uint >( 2 );
        }
    }
}