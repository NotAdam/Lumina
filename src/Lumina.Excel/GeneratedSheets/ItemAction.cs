// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ItemAction", columnHash: 0xb1f26af0 )]
    public class ItemAction : IExcelRow
    {
        
        public byte CondLv;
        public bool CondBattle;
        public bool CondPVP;
        public bool CondPVPOnly;
        public ushort Type;
        public ushort[] Data;
        public ushort[] DataHQ;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            CondLv = parser.ReadColumn< byte >( 0 );
            CondBattle = parser.ReadColumn< bool >( 1 );
            CondPVP = parser.ReadColumn< bool >( 2 );
            CondPVPOnly = parser.ReadColumn< bool >( 3 );
            Type = parser.ReadColumn< ushort >( 4 );
            Data = new ushort[ 9 ];
            for( var i = 0; i < 9; i++ )
                Data[ i ] = parser.ReadColumn< ushort >( 5 + i );
            DataHQ = new ushort[ 9 ];
            for( var i = 0; i < 9; i++ )
                DataHQ[ i ] = parser.ReadColumn< ushort >( 14 + i );
        }
    }
}