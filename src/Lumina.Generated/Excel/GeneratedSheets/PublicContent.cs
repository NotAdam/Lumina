using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PublicContent", columnHash: 0xd084c410 )]
    public class PublicContent : IExcelRow
    {
        
        public byte Type;
        public ushort TimeLimit;
        public uint MapIcon;
        public string Name;
        public LazyRow< PublicContentTextData > TextDataStart;
        public LazyRow< PublicContentTextData > TextDataEnd;
        public ushort Unknown6;
        public uint Unknown7;
        public LazyRow< ContentFinderCondition > ContentFinderCondition;
        public ushort AdditionalData;
        public byte Unknown10;
        public ushort Unknown11;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Type = parser.ReadColumn< byte >( 0 );
            TimeLimit = parser.ReadColumn< ushort >( 1 );
            MapIcon = parser.ReadColumn< uint >( 2 );
            Name = parser.ReadColumn< string >( 3 );
            TextDataStart = new LazyRow< PublicContentTextData >( lumina, parser.ReadColumn< uint >( 4 ), language );
            TextDataEnd = new LazyRow< PublicContentTextData >( lumina, parser.ReadColumn< uint >( 5 ), language );
            Unknown6 = parser.ReadColumn< ushort >( 6 );
            Unknown7 = parser.ReadColumn< uint >( 7 );
            ContentFinderCondition = new LazyRow< ContentFinderCondition >( lumina, parser.ReadColumn< ushort >( 8 ), language );
            AdditionalData = parser.ReadColumn< ushort >( 9 );
            Unknown10 = parser.ReadColumn< byte >( 10 );
            Unknown11 = parser.ReadColumn< ushort >( 11 );
        }
    }
}