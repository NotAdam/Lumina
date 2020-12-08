// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BattleLeve", columnHash: 0x1ce99cea )]
    public class BattleLeve : IExcelRow
    {
        public struct UnkStruct64Struct
        {
            public uint ToDoParam;
        }
        public struct UnkStruct104Struct
        {
            public byte NumOfAppearance;
        }
        
        public ushort[] Time;
        public int[] BaseID;
        public ushort[] EnemyLevel;
        public LazyRow< BNpcName >[] BNpcName;
        public LazyRow< EventItem >[] ItemsInvolved;
        public byte[] ItemsInvolvedQty;
        public byte[] ItemDropRate;
        public uint[] ToDoNumberInvolved;
        public UnkStruct64Struct[] UnkStruct64;
        public uint Unknown69;
        public uint Unknown70;
        public uint Unknown71;
        public uint Unknown72;
        public uint Unknown73;
        public uint Unknown74;
        public uint Unknown75;
        public uint Unknown76;
        public uint Unknown77;
        public uint Unknown78;
        public uint Unknown79;
        public uint Unknown80;
        public uint Unknown81;
        public uint Unknown82;
        public uint Unknown83;
        public uint Unknown84;
        public uint Unknown85;
        public uint Unknown86;
        public uint Unknown87;
        public uint Unknown88;
        public uint Unknown89;
        public uint Unknown90;
        public uint Unknown91;
        public uint Unknown92;
        public uint Unknown93;
        public uint Unknown94;
        public uint Unknown95;
        public uint Unknown96;
        public uint Unknown97;
        public uint Unknown98;
        public uint Unknown99;
        public uint Unknown100;
        public uint Unknown101;
        public uint Unknown102;
        public uint Unknown103;
        public UnkStruct104Struct[] UnkStruct104;
        public byte Unknown112;
        public byte Unknown113;
        public byte Unknown114;
        public byte Unknown115;
        public byte Unknown116;
        public byte Unknown117;
        public byte Unknown118;
        public byte Unknown119;
        public byte Unknown120;
        public byte Unknown121;
        public byte Unknown122;
        public byte Unknown123;
        public byte Unknown124;
        public byte Unknown125;
        public byte Unknown126;
        public byte Unknown127;
        public byte Unknown128;
        public byte Unknown129;
        public byte Unknown130;
        public byte Unknown131;
        public byte Unknown132;
        public byte Unknown133;
        public byte Unknown134;
        public byte Unknown135;
        public byte Unknown136;
        public byte Unknown137;
        public byte Unknown138;
        public byte Unknown139;
        public byte Unknown140;
        public byte Unknown141;
        public byte Unknown142;
        public byte Unknown143;
        public byte Unknown144;
        public byte Unknown145;
        public byte Unknown146;
        public byte Unknown147;
        public byte Unknown148;
        public byte Unknown149;
        public byte Unknown150;
        public byte Unknown151;
        public byte Unknown152;
        public byte Unknown153;
        public byte Unknown154;
        public byte Unknown155;
        public byte Unknown156;
        public byte Unknown157;
        public byte Unknown158;
        public byte Unknown159;
        public byte Unknown160;
        public byte Unknown161;
        public byte Unknown162;
        public byte Unknown163;
        public byte Unknown164;
        public byte Unknown165;
        public byte Unknown166;
        public byte Unknown167;
        public byte[] ToDoSequence;
        public LazyRow< BattleLeveRule > Rule;
        public byte Varient;
        public LazyRow< LeveString > Objective0;
        public LazyRow< LeveString > Objective1;
        public LazyRow< LeveString > Objective2;
        public ushort Help0;
        public ushort Help1;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Time = new ushort[ 8 ];
            for( var i = 0; i < 8; i++ )
                Time[ i ] = parser.ReadColumn< ushort >( 0 + i );
            BaseID = new int[ 8 ];
            for( var i = 0; i < 8; i++ )
                BaseID[ i ] = parser.ReadColumn< int >( 8 + i );
            EnemyLevel = new ushort[ 8 ];
            for( var i = 0; i < 8; i++ )
                EnemyLevel[ i ] = parser.ReadColumn< ushort >( 16 + i );
            BNpcName = new LazyRow< BNpcName >[ 8 ];
            for( var i = 0; i < 8; i++ )
                BNpcName[ i ] = new LazyRow< BNpcName >( lumina, parser.ReadColumn< uint >( 24 + i ), language );
            ItemsInvolved = new LazyRow< EventItem >[ 8 ];
            for( var i = 0; i < 8; i++ )
                ItemsInvolved[ i ] = new LazyRow< EventItem >( lumina, parser.ReadColumn< int >( 32 + i ), language );
            ItemsInvolvedQty = new byte[ 8 ];
            for( var i = 0; i < 8; i++ )
                ItemsInvolvedQty[ i ] = parser.ReadColumn< byte >( 40 + i );
            ItemDropRate = new byte[ 8 ];
            for( var i = 0; i < 8; i++ )
                ItemDropRate[ i ] = parser.ReadColumn< byte >( 48 + i );
            ToDoNumberInvolved = new uint[ 8 ];
            for( var i = 0; i < 8; i++ )
                ToDoNumberInvolved[ i ] = parser.ReadColumn< uint >( 56 + i );
            UnkStruct64 = new UnkStruct64Struct[ 5 ];
            for( var i = 0; i < 5; i++ )
            {
                UnkStruct64[ i ] = new UnkStruct64Struct();
                UnkStruct64[ i ].ToDoParam = parser.ReadColumn< uint >( 64 + ( i * 1 + 0 ) );
            }
            Unknown69 = parser.ReadColumn< uint >( 69 );
            Unknown70 = parser.ReadColumn< uint >( 70 );
            Unknown71 = parser.ReadColumn< uint >( 71 );
            Unknown72 = parser.ReadColumn< uint >( 72 );
            Unknown73 = parser.ReadColumn< uint >( 73 );
            Unknown74 = parser.ReadColumn< uint >( 74 );
            Unknown75 = parser.ReadColumn< uint >( 75 );
            Unknown76 = parser.ReadColumn< uint >( 76 );
            Unknown77 = parser.ReadColumn< uint >( 77 );
            Unknown78 = parser.ReadColumn< uint >( 78 );
            Unknown79 = parser.ReadColumn< uint >( 79 );
            Unknown80 = parser.ReadColumn< uint >( 80 );
            Unknown81 = parser.ReadColumn< uint >( 81 );
            Unknown82 = parser.ReadColumn< uint >( 82 );
            Unknown83 = parser.ReadColumn< uint >( 83 );
            Unknown84 = parser.ReadColumn< uint >( 84 );
            Unknown85 = parser.ReadColumn< uint >( 85 );
            Unknown86 = parser.ReadColumn< uint >( 86 );
            Unknown87 = parser.ReadColumn< uint >( 87 );
            Unknown88 = parser.ReadColumn< uint >( 88 );
            Unknown89 = parser.ReadColumn< uint >( 89 );
            Unknown90 = parser.ReadColumn< uint >( 90 );
            Unknown91 = parser.ReadColumn< uint >( 91 );
            Unknown92 = parser.ReadColumn< uint >( 92 );
            Unknown93 = parser.ReadColumn< uint >( 93 );
            Unknown94 = parser.ReadColumn< uint >( 94 );
            Unknown95 = parser.ReadColumn< uint >( 95 );
            Unknown96 = parser.ReadColumn< uint >( 96 );
            Unknown97 = parser.ReadColumn< uint >( 97 );
            Unknown98 = parser.ReadColumn< uint >( 98 );
            Unknown99 = parser.ReadColumn< uint >( 99 );
            Unknown100 = parser.ReadColumn< uint >( 100 );
            Unknown101 = parser.ReadColumn< uint >( 101 );
            Unknown102 = parser.ReadColumn< uint >( 102 );
            Unknown103 = parser.ReadColumn< uint >( 103 );
            UnkStruct104 = new UnkStruct104Struct[ 8 ];
            for( var i = 0; i < 8; i++ )
            {
                UnkStruct104[ i ] = new UnkStruct104Struct();
                UnkStruct104[ i ].NumOfAppearance = parser.ReadColumn< byte >( 104 + ( i * 1 + 0 ) );
            }
            Unknown112 = parser.ReadColumn< byte >( 112 );
            Unknown113 = parser.ReadColumn< byte >( 113 );
            Unknown114 = parser.ReadColumn< byte >( 114 );
            Unknown115 = parser.ReadColumn< byte >( 115 );
            Unknown116 = parser.ReadColumn< byte >( 116 );
            Unknown117 = parser.ReadColumn< byte >( 117 );
            Unknown118 = parser.ReadColumn< byte >( 118 );
            Unknown119 = parser.ReadColumn< byte >( 119 );
            Unknown120 = parser.ReadColumn< byte >( 120 );
            Unknown121 = parser.ReadColumn< byte >( 121 );
            Unknown122 = parser.ReadColumn< byte >( 122 );
            Unknown123 = parser.ReadColumn< byte >( 123 );
            Unknown124 = parser.ReadColumn< byte >( 124 );
            Unknown125 = parser.ReadColumn< byte >( 125 );
            Unknown126 = parser.ReadColumn< byte >( 126 );
            Unknown127 = parser.ReadColumn< byte >( 127 );
            Unknown128 = parser.ReadColumn< byte >( 128 );
            Unknown129 = parser.ReadColumn< byte >( 129 );
            Unknown130 = parser.ReadColumn< byte >( 130 );
            Unknown131 = parser.ReadColumn< byte >( 131 );
            Unknown132 = parser.ReadColumn< byte >( 132 );
            Unknown133 = parser.ReadColumn< byte >( 133 );
            Unknown134 = parser.ReadColumn< byte >( 134 );
            Unknown135 = parser.ReadColumn< byte >( 135 );
            Unknown136 = parser.ReadColumn< byte >( 136 );
            Unknown137 = parser.ReadColumn< byte >( 137 );
            Unknown138 = parser.ReadColumn< byte >( 138 );
            Unknown139 = parser.ReadColumn< byte >( 139 );
            Unknown140 = parser.ReadColumn< byte >( 140 );
            Unknown141 = parser.ReadColumn< byte >( 141 );
            Unknown142 = parser.ReadColumn< byte >( 142 );
            Unknown143 = parser.ReadColumn< byte >( 143 );
            Unknown144 = parser.ReadColumn< byte >( 144 );
            Unknown145 = parser.ReadColumn< byte >( 145 );
            Unknown146 = parser.ReadColumn< byte >( 146 );
            Unknown147 = parser.ReadColumn< byte >( 147 );
            Unknown148 = parser.ReadColumn< byte >( 148 );
            Unknown149 = parser.ReadColumn< byte >( 149 );
            Unknown150 = parser.ReadColumn< byte >( 150 );
            Unknown151 = parser.ReadColumn< byte >( 151 );
            Unknown152 = parser.ReadColumn< byte >( 152 );
            Unknown153 = parser.ReadColumn< byte >( 153 );
            Unknown154 = parser.ReadColumn< byte >( 154 );
            Unknown155 = parser.ReadColumn< byte >( 155 );
            Unknown156 = parser.ReadColumn< byte >( 156 );
            Unknown157 = parser.ReadColumn< byte >( 157 );
            Unknown158 = parser.ReadColumn< byte >( 158 );
            Unknown159 = parser.ReadColumn< byte >( 159 );
            Unknown160 = parser.ReadColumn< byte >( 160 );
            Unknown161 = parser.ReadColumn< byte >( 161 );
            Unknown162 = parser.ReadColumn< byte >( 162 );
            Unknown163 = parser.ReadColumn< byte >( 163 );
            Unknown164 = parser.ReadColumn< byte >( 164 );
            Unknown165 = parser.ReadColumn< byte >( 165 );
            Unknown166 = parser.ReadColumn< byte >( 166 );
            Unknown167 = parser.ReadColumn< byte >( 167 );
            ToDoSequence = new byte[ 8 ];
            for( var i = 0; i < 8; i++ )
                ToDoSequence[ i ] = parser.ReadColumn< byte >( 168 + i );
            Rule = new LazyRow< BattleLeveRule >( lumina, parser.ReadColumn< int >( 176 ), language );
            Varient = parser.ReadColumn< byte >( 177 );
            Objective0 = new LazyRow< LeveString >( lumina, parser.ReadColumn< ushort >( 178 ), language );
            Objective1 = new LazyRow< LeveString >( lumina, parser.ReadColumn< ushort >( 179 ), language );
            Objective2 = new LazyRow< LeveString >( lumina, parser.ReadColumn< ushort >( 180 ), language );
            Help0 = parser.ReadColumn< ushort >( 181 );
            Help1 = parser.ReadColumn< ushort >( 182 );
        }
    }
}