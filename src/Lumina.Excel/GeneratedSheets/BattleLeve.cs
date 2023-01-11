// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BattleLeve", columnHash: 0x1ce99cea )]
    public partial class BattleLeve : ExcelRow
    {
        
        public ushort[] Time { get; set; }
        public int[] BaseID { get; set; }
        public ushort[] EnemyLevel { get; set; }
        public LazyRow< BNpcName >[] BNpcName { get; set; }
        public LazyRow< EventItem >[] ItemsInvolved { get; set; }
        public byte[] ItemsInvolvedQty { get; set; }
        public byte[] ItemDropRate { get; set; }
        public uint[] ToDoNumberInvolved { get; set; }
        public uint[] ToDoParam { get; set; }
        public uint Unknown69 { get; set; }
        public uint Unknown70 { get; set; }
        public uint Unknown71 { get; set; }
        public uint Unknown72 { get; set; }
        public uint Unknown73 { get; set; }
        public uint Unknown74 { get; set; }
        public uint Unknown75 { get; set; }
        public uint Unknown76 { get; set; }
        public uint Unknown77 { get; set; }
        public uint Unknown78 { get; set; }
        public uint Unknown79 { get; set; }
        public uint Unknown80 { get; set; }
        public uint Unknown81 { get; set; }
        public uint Unknown82 { get; set; }
        public uint Unknown83 { get; set; }
        public uint Unknown84 { get; set; }
        public uint Unknown85 { get; set; }
        public uint Unknown86 { get; set; }
        public uint Unknown87 { get; set; }
        public uint Unknown88 { get; set; }
        public uint Unknown89 { get; set; }
        public uint Unknown90 { get; set; }
        public uint Unknown91 { get; set; }
        public uint Unknown92 { get; set; }
        public uint Unknown93 { get; set; }
        public uint Unknown94 { get; set; }
        public uint Unknown95 { get; set; }
        public uint Unknown96 { get; set; }
        public uint Unknown97 { get; set; }
        public uint Unknown98 { get; set; }
        public uint Unknown99 { get; set; }
        public uint Unknown100 { get; set; }
        public uint Unknown101 { get; set; }
        public uint Unknown102 { get; set; }
        public uint Unknown103 { get; set; }
        public byte[] NumOfAppearance { get; set; }
        public byte Unknown112 { get; set; }
        public byte Unknown113 { get; set; }
        public byte Unknown114 { get; set; }
        public byte Unknown115 { get; set; }
        public byte Unknown116 { get; set; }
        public byte Unknown117 { get; set; }
        public byte Unknown118 { get; set; }
        public byte Unknown119 { get; set; }
        public byte Unknown120 { get; set; }
        public byte Unknown121 { get; set; }
        public byte Unknown122 { get; set; }
        public byte Unknown123 { get; set; }
        public byte Unknown124 { get; set; }
        public byte Unknown125 { get; set; }
        public byte Unknown126 { get; set; }
        public byte Unknown127 { get; set; }
        public byte Unknown128 { get; set; }
        public byte Unknown129 { get; set; }
        public byte Unknown130 { get; set; }
        public byte Unknown131 { get; set; }
        public byte Unknown132 { get; set; }
        public byte Unknown133 { get; set; }
        public byte Unknown134 { get; set; }
        public byte Unknown135 { get; set; }
        public byte Unknown136 { get; set; }
        public byte Unknown137 { get; set; }
        public byte Unknown138 { get; set; }
        public byte Unknown139 { get; set; }
        public byte Unknown140 { get; set; }
        public byte Unknown141 { get; set; }
        public byte Unknown142 { get; set; }
        public byte Unknown143 { get; set; }
        public byte Unknown144 { get; set; }
        public byte Unknown145 { get; set; }
        public byte Unknown146 { get; set; }
        public byte Unknown147 { get; set; }
        public byte Unknown148 { get; set; }
        public byte Unknown149 { get; set; }
        public byte Unknown150 { get; set; }
        public byte Unknown151 { get; set; }
        public byte Unknown152 { get; set; }
        public byte Unknown153 { get; set; }
        public byte Unknown154 { get; set; }
        public byte Unknown155 { get; set; }
        public byte Unknown156 { get; set; }
        public byte Unknown157 { get; set; }
        public byte Unknown158 { get; set; }
        public byte Unknown159 { get; set; }
        public byte Unknown160 { get; set; }
        public byte Unknown161 { get; set; }
        public byte Unknown162 { get; set; }
        public byte Unknown163 { get; set; }
        public byte Unknown164 { get; set; }
        public byte Unknown165 { get; set; }
        public byte Unknown166 { get; set; }
        public byte Unknown167 { get; set; }
        public byte[] ToDoSequence { get; set; }
        public LazyRow< BattleLeveRule > Rule { get; set; }
        public byte Varient { get; set; }
        public LazyRow< LeveString > Objective0 { get; set; }
        public LazyRow< LeveString > Objective1 { get; set; }
        public LazyRow< LeveString > Objective2 { get; set; }
        public ushort Help0 { get; set; }
        public ushort Help1 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

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
                BNpcName[ i ] = new LazyRow< BNpcName >( gameData, parser.ReadColumn< uint >( 24 + i ), language );
            ItemsInvolved = new LazyRow< EventItem >[ 8 ];
            for( var i = 0; i < 8; i++ )
                ItemsInvolved[ i ] = new LazyRow< EventItem >( gameData, parser.ReadColumn< int >( 32 + i ), language );
            ItemsInvolvedQty = new byte[ 8 ];
            for( var i = 0; i < 8; i++ )
                ItemsInvolvedQty[ i ] = parser.ReadColumn< byte >( 40 + i );
            ItemDropRate = new byte[ 8 ];
            for( var i = 0; i < 8; i++ )
                ItemDropRate[ i ] = parser.ReadColumn< byte >( 48 + i );
            ToDoNumberInvolved = new uint[ 8 ];
            for( var i = 0; i < 8; i++ )
                ToDoNumberInvolved[ i ] = parser.ReadColumn< uint >( 56 + i );
            ToDoParam = new uint[ 5 ];
            for( var i = 0; i < 5; i++ )
                ToDoParam[ i ] = parser.ReadColumn< uint >( 64 + i );
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
            NumOfAppearance = new byte[ 8 ];
            for( var i = 0; i < 8; i++ )
                NumOfAppearance[ i ] = parser.ReadColumn< byte >( 104 + i );
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
            Rule = new LazyRow< BattleLeveRule >( gameData, parser.ReadColumn< int >( 176 ), language );
            Varient = parser.ReadColumn< byte >( 177 );
            Objective0 = new LazyRow< LeveString >( gameData, parser.ReadColumn< ushort >( 178 ), language );
            Objective1 = new LazyRow< LeveString >( gameData, parser.ReadColumn< ushort >( 179 ), language );
            Objective2 = new LazyRow< LeveString >( gameData, parser.ReadColumn< ushort >( 180 ), language );
            Help0 = parser.ReadColumn< ushort >( 181 );
            Help1 = parser.ReadColumn< ushort >( 182 );
        }
    }
}