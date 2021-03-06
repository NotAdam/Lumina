// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PublicContent", columnHash: 0xdb646081 )]
    public class PublicContent : ExcelRow
    {
        
        public byte Type { get; set; }
        public ushort TimeLimit { get; set; }
        public uint MapIcon { get; set; }
        public SeString Name { get; set; }
        public LazyRow< PublicContentTextData > TextDataStart { get; set; }
        public LazyRow< PublicContentTextData > TextDataEnd { get; set; }
        public ushort Unknown6 { get; set; }
        public uint Unknown7 { get; set; }
        public uint Unknown8 { get; set; }
        public LazyRow< ContentFinderCondition > ContentFinderCondition { get; set; }
        public ushort AdditionalData { get; set; }
        public byte Unknown11 { get; set; }
        public ushort Unknown12 { get; set; }
        public int Unknown540 { get; set; }
        public ushort Unknown541 { get; set; }
        public ushort Unknown542 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Type = parser.ReadColumn< byte >( 0 );
            TimeLimit = parser.ReadColumn< ushort >( 1 );
            MapIcon = parser.ReadColumn< uint >( 2 );
            Name = parser.ReadColumn< SeString >( 3 );
            TextDataStart = new LazyRow< PublicContentTextData >( gameData, parser.ReadColumn< uint >( 4 ), language );
            TextDataEnd = new LazyRow< PublicContentTextData >( gameData, parser.ReadColumn< uint >( 5 ), language );
            Unknown6 = parser.ReadColumn< ushort >( 6 );
            Unknown7 = parser.ReadColumn< uint >( 7 );
            Unknown8 = parser.ReadColumn< uint >( 8 );
            ContentFinderCondition = new LazyRow< ContentFinderCondition >( gameData, parser.ReadColumn< ushort >( 9 ), language );
            AdditionalData = parser.ReadColumn< ushort >( 10 );
            Unknown11 = parser.ReadColumn< byte >( 11 );
            Unknown12 = parser.ReadColumn< ushort >( 12 );
            Unknown540 = parser.ReadColumn< int >( 13 );
            Unknown541 = parser.ReadColumn< ushort >( 14 );
            Unknown542 = parser.ReadColumn< ushort >( 15 );
        }
    }
}