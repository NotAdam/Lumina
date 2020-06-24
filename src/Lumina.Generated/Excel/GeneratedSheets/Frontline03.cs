using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Frontline03", columnHash: 0x605090e3 )]
    public class Frontline03 : IExcelRow
    {
        
        public byte Unknown0;
        public byte Unknown1;
        public byte Unknown2;
        public byte Unknown3;
        public byte Unknown4;
        public byte Unknown5;
        public byte Unknown6;
        public byte Unknown7;
        public byte Unknown8;
        public uint[] EmptyIcon;
        public uint[] MaelstromIcon;
        public uint[] TwinAdderIcon;
        public uint[] ImmortalFlamesIcon;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            Unknown3 = parser.ReadColumn< byte >( 3 );
            Unknown4 = parser.ReadColumn< byte >( 4 );
            Unknown5 = parser.ReadColumn< byte >( 5 );
            Unknown6 = parser.ReadColumn< byte >( 6 );
            Unknown7 = parser.ReadColumn< byte >( 7 );
            Unknown8 = parser.ReadColumn< byte >( 8 );
            EmptyIcon = new uint[ 3 ];
            for( var i = 0; i < 3; i++ )
                EmptyIcon[ i ] = parser.ReadColumn< uint >( 9 + i );
            MaelstromIcon = new uint[ 3 ];
            for( var i = 0; i < 3; i++ )
                MaelstromIcon[ i ] = parser.ReadColumn< uint >( 12 + i );
            TwinAdderIcon = new uint[ 3 ];
            for( var i = 0; i < 3; i++ )
                TwinAdderIcon[ i ] = parser.ReadColumn< uint >( 15 + i );
            ImmortalFlamesIcon = new uint[ 3 ];
            for( var i = 0; i < 3; i++ )
                ImmortalFlamesIcon[ i ] = parser.ReadColumn< uint >( 18 + i );
        }
    }
}