using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GcArmyMemberGrow", columnHash: 0xf522dc80 )]
    public class GcArmyMemberGrow : IExcelRow
    {
        
        public LazyRow< ClassJob > ClassJob;
        public LazyRow< Item > ClassBook;
        public ushort Unknown2;
        public ushort Unknown3;
        public ushort Unknown4;
        public ushort Unknown5;
        public ushort Unknown6;
        public ushort Unknown7;
        public ushort Unknown8;
        public ushort Unknown9;
        public ushort Unknown10;
        public ushort Unknown11;
        public ushort Unknown12;
        public ushort Unknown13;
        public ushort Unknown14;
        public ushort Unknown15;
        public ushort Unknown16;
        public ushort Unknown17;
        public ushort Unknown18;
        public ushort Unknown19;
        public ushort Unknown20;
        public ushort Unknown21;
        public ushort Unknown22;
        public ushort Unknown23;
        public ushort Unknown24;
        public ushort Unknown25;
        public ushort Unknown26;
        public ushort Unknown27;
        public ushort Unknown28;
        public ushort Unknown29;
        public ushort Unknown30;
        public ushort Unknown31;
        public ushort Unknown32;
        public ushort Unknown33;
        public ushort Unknown34;
        public ushort Unknown35;
        public ushort Unknown36;
        public ushort Unknown37;
        public ushort Unknown38;
        public ushort Unknown39;
        public ushort Unknown40;
        public ushort Unknown41;
        public ushort Unknown42;
        public ushort Unknown43;
        public ushort Unknown44;
        public ushort Unknown45;
        public ushort Unknown46;
        public ushort Unknown47;
        public ushort Unknown48;
        public ushort Unknown49;
        public ushort Unknown50;
        public ushort Unknown51;
        public ushort Unknown52;
        public ushort Unknown53;
        public ushort Unknown54;
        public ushort Unknown55;
        public ushort Unknown56;
        public ushort Unknown57;
        public ushort Unknown58;
        public ushort Unknown59;
        public ushort Unknown60;
        public ushort Unknown61;
        public ushort Unknown62;
        public byte Unknown63;
        public byte Unknown64;
        public byte Unknown65;
        public byte Unknown66;
        public byte Unknown67;
        public byte Unknown68;
        public byte Unknown69;
        public byte Unknown70;
        public byte Unknown71;
        public byte Unknown72;
        public byte Unknown73;
        public byte Unknown74;
        public byte Unknown75;
        public byte Unknown76;
        public byte Unknown77;
        public byte Unknown78;
        public byte Unknown79;
        public byte Unknown80;
        public byte Unknown81;
        public byte Unknown82;
        public byte Unknown83;
        public byte Unknown84;
        public byte Unknown85;
        public byte Unknown86;
        public byte Unknown87;
        public byte Unknown88;
        public byte Unknown89;
        public byte Unknown90;
        public byte Unknown91;
        public byte Unknown92;
        public byte Unknown93;
        public byte Unknown94;
        public byte Unknown95;
        public byte Unknown96;
        public byte Unknown97;
        public byte Unknown98;
        public byte Unknown99;
        public byte Unknown100;
        public byte Unknown101;
        public byte Unknown102;
        public byte Unknown103;
        public byte Unknown104;
        public byte Unknown105;
        public byte Unknown106;
        public byte Unknown107;
        public byte Unknown108;
        public byte Unknown109;
        public byte Unknown110;
        public byte Unknown111;
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
        public byte Unknown168;
        public byte Unknown169;
        public byte Unknown170;
        public byte Unknown171;
        public byte Unknown172;
        public byte Unknown173;
        public byte Unknown174;
        public byte Unknown175;
        public byte Unknown176;
        public byte Unknown177;
        public byte Unknown178;
        public byte Unknown179;
        public byte Unknown180;
        public byte Unknown181;
        public byte Unknown182;
        public byte Unknown183;
        public byte Unknown184;
        public byte Unknown185;
        public byte Unknown186;
        public byte Unknown187;
        public byte Unknown188;
        public byte Unknown189;
        public byte Unknown190;
        public byte Unknown191;
        public byte Unknown192;
        public byte Unknown193;
        public byte Unknown194;
        public byte Unknown195;
        public byte Unknown196;
        public byte Unknown197;
        public byte Unknown198;
        public byte Unknown199;
        public byte Unknown200;
        public byte Unknown201;
        public byte Unknown202;
        public byte Unknown203;
        public byte Unknown204;
        public byte Unknown205;
        public byte Unknown206;
        public byte Unknown207;
        public byte Unknown208;
        public byte Unknown209;
        public byte Unknown210;
        public byte Unknown211;
        public byte Unknown212;
        public byte Unknown213;
        public byte Unknown214;
        public byte Unknown215;
        public byte Unknown216;
        public byte Unknown217;
        public byte Unknown218;
        public byte Unknown219;
        public byte Unknown220;
        public byte Unknown221;
        public byte Unknown222;
        public byte Unknown223;
        public byte Unknown224;
        public byte Unknown225;
        public byte Unknown226;
        public byte Unknown227;
        public byte Unknown228;
        public byte Unknown229;
        public byte Unknown230;
        public byte Unknown231;
        public byte Unknown232;
        public byte Unknown233;
        public byte Unknown234;
        public byte Unknown235;
        public byte Unknown236;
        public byte Unknown237;
        public byte Unknown238;
        public byte Unknown239;
        public byte Unknown240;
        public byte Unknown241;
        public byte Unknown242;
        public byte Unknown243;
        public byte Unknown244;
        public byte Unknown245;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            ClassJob = new LazyRow< ClassJob >( lumina, parser.ReadColumn< byte >( 0 ) );
            ClassBook = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 1 ) );
            Unknown2 = parser.ReadColumn< ushort >( 2 );
            Unknown3 = parser.ReadColumn< ushort >( 3 );
            Unknown4 = parser.ReadColumn< ushort >( 4 );
            Unknown5 = parser.ReadColumn< ushort >( 5 );
            Unknown6 = parser.ReadColumn< ushort >( 6 );
            Unknown7 = parser.ReadColumn< ushort >( 7 );
            Unknown8 = parser.ReadColumn< ushort >( 8 );
            Unknown9 = parser.ReadColumn< ushort >( 9 );
            Unknown10 = parser.ReadColumn< ushort >( 10 );
            Unknown11 = parser.ReadColumn< ushort >( 11 );
            Unknown12 = parser.ReadColumn< ushort >( 12 );
            Unknown13 = parser.ReadColumn< ushort >( 13 );
            Unknown14 = parser.ReadColumn< ushort >( 14 );
            Unknown15 = parser.ReadColumn< ushort >( 15 );
            Unknown16 = parser.ReadColumn< ushort >( 16 );
            Unknown17 = parser.ReadColumn< ushort >( 17 );
            Unknown18 = parser.ReadColumn< ushort >( 18 );
            Unknown19 = parser.ReadColumn< ushort >( 19 );
            Unknown20 = parser.ReadColumn< ushort >( 20 );
            Unknown21 = parser.ReadColumn< ushort >( 21 );
            Unknown22 = parser.ReadColumn< ushort >( 22 );
            Unknown23 = parser.ReadColumn< ushort >( 23 );
            Unknown24 = parser.ReadColumn< ushort >( 24 );
            Unknown25 = parser.ReadColumn< ushort >( 25 );
            Unknown26 = parser.ReadColumn< ushort >( 26 );
            Unknown27 = parser.ReadColumn< ushort >( 27 );
            Unknown28 = parser.ReadColumn< ushort >( 28 );
            Unknown29 = parser.ReadColumn< ushort >( 29 );
            Unknown30 = parser.ReadColumn< ushort >( 30 );
            Unknown31 = parser.ReadColumn< ushort >( 31 );
            Unknown32 = parser.ReadColumn< ushort >( 32 );
            Unknown33 = parser.ReadColumn< ushort >( 33 );
            Unknown34 = parser.ReadColumn< ushort >( 34 );
            Unknown35 = parser.ReadColumn< ushort >( 35 );
            Unknown36 = parser.ReadColumn< ushort >( 36 );
            Unknown37 = parser.ReadColumn< ushort >( 37 );
            Unknown38 = parser.ReadColumn< ushort >( 38 );
            Unknown39 = parser.ReadColumn< ushort >( 39 );
            Unknown40 = parser.ReadColumn< ushort >( 40 );
            Unknown41 = parser.ReadColumn< ushort >( 41 );
            Unknown42 = parser.ReadColumn< ushort >( 42 );
            Unknown43 = parser.ReadColumn< ushort >( 43 );
            Unknown44 = parser.ReadColumn< ushort >( 44 );
            Unknown45 = parser.ReadColumn< ushort >( 45 );
            Unknown46 = parser.ReadColumn< ushort >( 46 );
            Unknown47 = parser.ReadColumn< ushort >( 47 );
            Unknown48 = parser.ReadColumn< ushort >( 48 );
            Unknown49 = parser.ReadColumn< ushort >( 49 );
            Unknown50 = parser.ReadColumn< ushort >( 50 );
            Unknown51 = parser.ReadColumn< ushort >( 51 );
            Unknown52 = parser.ReadColumn< ushort >( 52 );
            Unknown53 = parser.ReadColumn< ushort >( 53 );
            Unknown54 = parser.ReadColumn< ushort >( 54 );
            Unknown55 = parser.ReadColumn< ushort >( 55 );
            Unknown56 = parser.ReadColumn< ushort >( 56 );
            Unknown57 = parser.ReadColumn< ushort >( 57 );
            Unknown58 = parser.ReadColumn< ushort >( 58 );
            Unknown59 = parser.ReadColumn< ushort >( 59 );
            Unknown60 = parser.ReadColumn< ushort >( 60 );
            Unknown61 = parser.ReadColumn< ushort >( 61 );
            Unknown62 = parser.ReadColumn< ushort >( 62 );
            Unknown63 = parser.ReadColumn< byte >( 63 );
            Unknown64 = parser.ReadColumn< byte >( 64 );
            Unknown65 = parser.ReadColumn< byte >( 65 );
            Unknown66 = parser.ReadColumn< byte >( 66 );
            Unknown67 = parser.ReadColumn< byte >( 67 );
            Unknown68 = parser.ReadColumn< byte >( 68 );
            Unknown69 = parser.ReadColumn< byte >( 69 );
            Unknown70 = parser.ReadColumn< byte >( 70 );
            Unknown71 = parser.ReadColumn< byte >( 71 );
            Unknown72 = parser.ReadColumn< byte >( 72 );
            Unknown73 = parser.ReadColumn< byte >( 73 );
            Unknown74 = parser.ReadColumn< byte >( 74 );
            Unknown75 = parser.ReadColumn< byte >( 75 );
            Unknown76 = parser.ReadColumn< byte >( 76 );
            Unknown77 = parser.ReadColumn< byte >( 77 );
            Unknown78 = parser.ReadColumn< byte >( 78 );
            Unknown79 = parser.ReadColumn< byte >( 79 );
            Unknown80 = parser.ReadColumn< byte >( 80 );
            Unknown81 = parser.ReadColumn< byte >( 81 );
            Unknown82 = parser.ReadColumn< byte >( 82 );
            Unknown83 = parser.ReadColumn< byte >( 83 );
            Unknown84 = parser.ReadColumn< byte >( 84 );
            Unknown85 = parser.ReadColumn< byte >( 85 );
            Unknown86 = parser.ReadColumn< byte >( 86 );
            Unknown87 = parser.ReadColumn< byte >( 87 );
            Unknown88 = parser.ReadColumn< byte >( 88 );
            Unknown89 = parser.ReadColumn< byte >( 89 );
            Unknown90 = parser.ReadColumn< byte >( 90 );
            Unknown91 = parser.ReadColumn< byte >( 91 );
            Unknown92 = parser.ReadColumn< byte >( 92 );
            Unknown93 = parser.ReadColumn< byte >( 93 );
            Unknown94 = parser.ReadColumn< byte >( 94 );
            Unknown95 = parser.ReadColumn< byte >( 95 );
            Unknown96 = parser.ReadColumn< byte >( 96 );
            Unknown97 = parser.ReadColumn< byte >( 97 );
            Unknown98 = parser.ReadColumn< byte >( 98 );
            Unknown99 = parser.ReadColumn< byte >( 99 );
            Unknown100 = parser.ReadColumn< byte >( 100 );
            Unknown101 = parser.ReadColumn< byte >( 101 );
            Unknown102 = parser.ReadColumn< byte >( 102 );
            Unknown103 = parser.ReadColumn< byte >( 103 );
            Unknown104 = parser.ReadColumn< byte >( 104 );
            Unknown105 = parser.ReadColumn< byte >( 105 );
            Unknown106 = parser.ReadColumn< byte >( 106 );
            Unknown107 = parser.ReadColumn< byte >( 107 );
            Unknown108 = parser.ReadColumn< byte >( 108 );
            Unknown109 = parser.ReadColumn< byte >( 109 );
            Unknown110 = parser.ReadColumn< byte >( 110 );
            Unknown111 = parser.ReadColumn< byte >( 111 );
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
            Unknown168 = parser.ReadColumn< byte >( 168 );
            Unknown169 = parser.ReadColumn< byte >( 169 );
            Unknown170 = parser.ReadColumn< byte >( 170 );
            Unknown171 = parser.ReadColumn< byte >( 171 );
            Unknown172 = parser.ReadColumn< byte >( 172 );
            Unknown173 = parser.ReadColumn< byte >( 173 );
            Unknown174 = parser.ReadColumn< byte >( 174 );
            Unknown175 = parser.ReadColumn< byte >( 175 );
            Unknown176 = parser.ReadColumn< byte >( 176 );
            Unknown177 = parser.ReadColumn< byte >( 177 );
            Unknown178 = parser.ReadColumn< byte >( 178 );
            Unknown179 = parser.ReadColumn< byte >( 179 );
            Unknown180 = parser.ReadColumn< byte >( 180 );
            Unknown181 = parser.ReadColumn< byte >( 181 );
            Unknown182 = parser.ReadColumn< byte >( 182 );
            Unknown183 = parser.ReadColumn< byte >( 183 );
            Unknown184 = parser.ReadColumn< byte >( 184 );
            Unknown185 = parser.ReadColumn< byte >( 185 );
            Unknown186 = parser.ReadColumn< byte >( 186 );
            Unknown187 = parser.ReadColumn< byte >( 187 );
            Unknown188 = parser.ReadColumn< byte >( 188 );
            Unknown189 = parser.ReadColumn< byte >( 189 );
            Unknown190 = parser.ReadColumn< byte >( 190 );
            Unknown191 = parser.ReadColumn< byte >( 191 );
            Unknown192 = parser.ReadColumn< byte >( 192 );
            Unknown193 = parser.ReadColumn< byte >( 193 );
            Unknown194 = parser.ReadColumn< byte >( 194 );
            Unknown195 = parser.ReadColumn< byte >( 195 );
            Unknown196 = parser.ReadColumn< byte >( 196 );
            Unknown197 = parser.ReadColumn< byte >( 197 );
            Unknown198 = parser.ReadColumn< byte >( 198 );
            Unknown199 = parser.ReadColumn< byte >( 199 );
            Unknown200 = parser.ReadColumn< byte >( 200 );
            Unknown201 = parser.ReadColumn< byte >( 201 );
            Unknown202 = parser.ReadColumn< byte >( 202 );
            Unknown203 = parser.ReadColumn< byte >( 203 );
            Unknown204 = parser.ReadColumn< byte >( 204 );
            Unknown205 = parser.ReadColumn< byte >( 205 );
            Unknown206 = parser.ReadColumn< byte >( 206 );
            Unknown207 = parser.ReadColumn< byte >( 207 );
            Unknown208 = parser.ReadColumn< byte >( 208 );
            Unknown209 = parser.ReadColumn< byte >( 209 );
            Unknown210 = parser.ReadColumn< byte >( 210 );
            Unknown211 = parser.ReadColumn< byte >( 211 );
            Unknown212 = parser.ReadColumn< byte >( 212 );
            Unknown213 = parser.ReadColumn< byte >( 213 );
            Unknown214 = parser.ReadColumn< byte >( 214 );
            Unknown215 = parser.ReadColumn< byte >( 215 );
            Unknown216 = parser.ReadColumn< byte >( 216 );
            Unknown217 = parser.ReadColumn< byte >( 217 );
            Unknown218 = parser.ReadColumn< byte >( 218 );
            Unknown219 = parser.ReadColumn< byte >( 219 );
            Unknown220 = parser.ReadColumn< byte >( 220 );
            Unknown221 = parser.ReadColumn< byte >( 221 );
            Unknown222 = parser.ReadColumn< byte >( 222 );
            Unknown223 = parser.ReadColumn< byte >( 223 );
            Unknown224 = parser.ReadColumn< byte >( 224 );
            Unknown225 = parser.ReadColumn< byte >( 225 );
            Unknown226 = parser.ReadColumn< byte >( 226 );
            Unknown227 = parser.ReadColumn< byte >( 227 );
            Unknown228 = parser.ReadColumn< byte >( 228 );
            Unknown229 = parser.ReadColumn< byte >( 229 );
            Unknown230 = parser.ReadColumn< byte >( 230 );
            Unknown231 = parser.ReadColumn< byte >( 231 );
            Unknown232 = parser.ReadColumn< byte >( 232 );
            Unknown233 = parser.ReadColumn< byte >( 233 );
            Unknown234 = parser.ReadColumn< byte >( 234 );
            Unknown235 = parser.ReadColumn< byte >( 235 );
            Unknown236 = parser.ReadColumn< byte >( 236 );
            Unknown237 = parser.ReadColumn< byte >( 237 );
            Unknown238 = parser.ReadColumn< byte >( 238 );
            Unknown239 = parser.ReadColumn< byte >( 239 );
            Unknown240 = parser.ReadColumn< byte >( 240 );
            Unknown241 = parser.ReadColumn< byte >( 241 );
            Unknown242 = parser.ReadColumn< byte >( 242 );
            Unknown243 = parser.ReadColumn< byte >( 243 );
            Unknown244 = parser.ReadColumn< byte >( 244 );
            Unknown245 = parser.ReadColumn< byte >( 245 );
        }
    }
}