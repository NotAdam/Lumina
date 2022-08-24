// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Frontline03", columnHash: 0x605090e3 )]
    public partial class Frontline03 : ExcelRow
    {
        
        public byte Unknown0 { get; set; }
        public byte Unknown1 { get; set; }
        public byte Unknown2 { get; set; }
        public byte Unknown3 { get; set; }
        public byte Unknown4 { get; set; }
        public byte Unknown5 { get; set; }
        public byte Unknown6 { get; set; }
        public byte Unknown7 { get; set; }
        public byte Unknown8 { get; set; }
        public uint[] EmptyIcon { get; set; }
        public uint[] MaelstromIcon { get; set; }
        public uint[] TwinAdderIcon { get; set; }
        public uint[] ImmortalFlamesIcon { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

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