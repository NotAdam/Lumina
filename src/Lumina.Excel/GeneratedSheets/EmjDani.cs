// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "EmjDani", columnHash: 0xf3fb0152 )]
    public class EmjDani : ExcelRow
    {
        
        public uint Icon;
        public ushort Unknown1;
        public ushort Unknown2;
        public bool Unknown3;
        public short Unknown4;
        public short Unknown5;
        public short Unknown6;
        public short Unknown7;
        public short Unknown8;
        public short Unknown9;
        public short Unknown10;
        public short Unknown11;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Icon = parser.ReadColumn< uint >( 0 );
            Unknown1 = parser.ReadColumn< ushort >( 1 );
            Unknown2 = parser.ReadColumn< ushort >( 2 );
            Unknown3 = parser.ReadColumn< bool >( 3 );
            Unknown4 = parser.ReadColumn< short >( 4 );
            Unknown5 = parser.ReadColumn< short >( 5 );
            Unknown6 = parser.ReadColumn< short >( 6 );
            Unknown7 = parser.ReadColumn< short >( 7 );
            Unknown8 = parser.ReadColumn< short >( 8 );
            Unknown9 = parser.ReadColumn< short >( 9 );
            Unknown10 = parser.ReadColumn< short >( 10 );
            Unknown11 = parser.ReadColumn< short >( 11 );
        }
    }
}