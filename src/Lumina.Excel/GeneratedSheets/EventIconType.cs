// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "EventIconType", columnHash: 0x6ce9409c )]
    public class EventIconType : IExcelRow
    {
        
        public uint NpcIconAvailable;
        public uint MapIconAvailable;
        public uint NpcIconInvalid;
        public uint MapIconInvalid;
        public byte IconRange;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            NpcIconAvailable = parser.ReadColumn< uint >( 0 );
            MapIconAvailable = parser.ReadColumn< uint >( 1 );
            NpcIconInvalid = parser.ReadColumn< uint >( 2 );
            MapIconInvalid = parser.ReadColumn< uint >( 3 );
            IconRange = parser.ReadColumn< byte >( 4 );
        }
    }
}