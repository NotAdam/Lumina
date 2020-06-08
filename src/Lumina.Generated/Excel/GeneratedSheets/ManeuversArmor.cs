using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ManeuversArmor", columnHash: 0xc8b98ed4 )]
    public class ManeuversArmor : IExcelRow
    {
        
        public ushort Unknown0;
        public LazyRow< BNpcName >[] BNpcBase;
        public byte Unknown3;
        public bool Unknown4;
        public uint[] Icon;
        public string Unknown10;
        public string Unknown11;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< ushort >( 0 );
            for( var i = 0; i < 2; i++ )
                BNpcBase[ i ] = new LazyRow< BNpcName >( lumina, parser.ReadColumn< uint >( 1 + i ) );
            Unknown3 = parser.ReadColumn< byte >( 3 );
            Unknown4 = parser.ReadColumn< bool >( 4 );
            for( var i = 0; i < 5; i++ )
                Icon[ i ] = parser.ReadColumn< uint >( 5 + i );
            Unknown10 = parser.ReadColumn< string >( 10 );
            Unknown11 = parser.ReadColumn< string >( 11 );
        }
    }
}