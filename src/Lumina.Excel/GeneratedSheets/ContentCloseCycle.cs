// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ContentCloseCycle", columnHash: 0xd3032cdb )]
    public class ContentCloseCycle : IExcelRow
    {
        
        public uint Unixtime;
        public uint TimeSeconds;
        public uint Unknown2;
        public bool Unknown3;
        public bool Unknown4;
        public bool Unknown5;
        public bool Unknown6;
        public bool Unknown7;
        public bool Unknown8;
        public bool Unknown9;
        public bool Unknown10;
        public bool Unknown11;
        public bool Unknown12;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unixtime = parser.ReadColumn< uint >( 0 );
            TimeSeconds = parser.ReadColumn< uint >( 1 );
            Unknown2 = parser.ReadColumn< uint >( 2 );
            Unknown3 = parser.ReadColumn< bool >( 3 );
            Unknown4 = parser.ReadColumn< bool >( 4 );
            Unknown5 = parser.ReadColumn< bool >( 5 );
            Unknown6 = parser.ReadColumn< bool >( 6 );
            Unknown7 = parser.ReadColumn< bool >( 7 );
            Unknown8 = parser.ReadColumn< bool >( 8 );
            Unknown9 = parser.ReadColumn< bool >( 9 );
            Unknown10 = parser.ReadColumn< bool >( 10 );
            Unknown11 = parser.ReadColumn< bool >( 11 );
            Unknown12 = parser.ReadColumn< bool >( 12 );
        }
    }
}