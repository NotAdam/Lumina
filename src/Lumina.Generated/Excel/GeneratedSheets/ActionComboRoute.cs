using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ActionComboRoute", columnHash: 0xc4b3400f )]
    public class ActionComboRoute : IExcelRow
    {
        
        public string Name;
        public sbyte Unknown1;
        public LazyRow< Action >[] Action;
        public bool Unknown6;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = parser.ReadColumn< string >( 0 );
            Unknown1 = parser.ReadColumn< sbyte >( 1 );
            Action = new LazyRow< Action >[ 4 ];
            for( var i = 0; i < 4; i++ )
                Action[ i ] = new LazyRow< Action >( lumina, parser.ReadColumn< ushort >( 2 + i ), language );
            Unknown6 = parser.ReadColumn< bool >( 6 );
        }
    }
}