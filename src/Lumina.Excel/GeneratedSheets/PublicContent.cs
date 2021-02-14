// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PublicContent", columnHash: 0xdb646081 )]
    public class PublicContent : ExcelRow
    {
        
        public byte Type;
        public ushort TimeLimit;
        public uint MapIcon;
        public SeString Name;
        public LazyRow< PublicContentTextData > TextDataStart;
        public LazyRow< PublicContentTextData > TextDataEnd;
        public ushort Unknown6;
        public uint Unknown7;
        public uint Unknown8;
        public LazyRow< ContentFinderCondition > ContentFinderCondition;
        public ushort AdditionalData;
        public byte Unknown11;
        public ushort Unknown12;
        public int Unknown540;
        public ushort Unknown541;
        public ushort Unknown542;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Type = parser.ReadColumn< byte >( 0 );
            TimeLimit = parser.ReadColumn< ushort >( 1 );
            MapIcon = parser.ReadColumn< uint >( 2 );
            Name = parser.ReadColumn< SeString >( 3 );
            TextDataStart = new LazyRow< PublicContentTextData >( lumina, parser.ReadColumn< uint >( 4 ), language );
            TextDataEnd = new LazyRow< PublicContentTextData >( lumina, parser.ReadColumn< uint >( 5 ), language );
            Unknown6 = parser.ReadColumn< ushort >( 6 );
            Unknown7 = parser.ReadColumn< uint >( 7 );
            Unknown8 = parser.ReadColumn< uint >( 8 );
            ContentFinderCondition = new LazyRow< ContentFinderCondition >( lumina, parser.ReadColumn< ushort >( 9 ), language );
            AdditionalData = parser.ReadColumn< ushort >( 10 );
            Unknown11 = parser.ReadColumn< byte >( 11 );
            Unknown12 = parser.ReadColumn< ushort >( 12 );
            Unknown540 = parser.ReadColumn< int >( 13 );
            Unknown541 = parser.ReadColumn< ushort >( 14 );
            Unknown542 = parser.ReadColumn< ushort >( 15 );
        }
    }
}