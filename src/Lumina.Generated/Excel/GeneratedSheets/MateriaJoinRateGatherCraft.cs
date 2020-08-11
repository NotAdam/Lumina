// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MateriaJoinRateGatherCraft", columnHash: 0xab31b42e )]
    public class MateriaJoinRateGatherCraft : IExcelRow
    {
        
        public float[] NQOvermeldPctSlot;
        public float[] HQOvermeldPctSlot;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            NQOvermeldPctSlot = new float[ 4 ];
            for( var i = 0; i < 4; i++ )
                NQOvermeldPctSlot[ i ] = parser.ReadColumn< float >( 0 + i );
            HQOvermeldPctSlot = new float[ 4 ];
            for( var i = 0; i < 4; i++ )
                HQOvermeldPctSlot[ i ] = parser.ReadColumn< float >( 4 + i );
        }
    }
}