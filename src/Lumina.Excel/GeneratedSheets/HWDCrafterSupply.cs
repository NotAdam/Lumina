// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HWDCrafterSupply", columnHash: 0xa04b4cc9 )]
    public class HWDCrafterSupply : IExcelRow
    {
        
        public LazyRow< Item >[] ItemTradeIn;
        public byte[] Level;
        public byte[] LevelMax;
        public byte[] BaseCollectableRating;
        public ushort[] MidCollectableRating;
        public ushort[] HighCollectableRating;
        public ushort Unknown138;
        public ushort Unknown139;
        public ushort Unknown140;
        public ushort Unknown141;
        public ushort Unknown142;
        public ushort Unknown143;
        public ushort Unknown144;
        public ushort Unknown145;
        public ushort Unknown146;
        public ushort Unknown147;
        public ushort Unknown148;
        public ushort Unknown149;
        public ushort Unknown150;
        public ushort Unknown151;
        public ushort Unknown152;
        public ushort Unknown153;
        public ushort Unknown154;
        public ushort Unknown155;
        public ushort Unknown156;
        public ushort Unknown157;
        public ushort Unknown158;
        public ushort Unknown159;
        public ushort Unknown160;
        public ushort Unknown161;
        public ushort Unknown162;
        public ushort Unknown163;
        public ushort Unknown164;
        public ushort Unknown165;
        public ushort Unknown166;
        public ushort Unknown167;
        public ushort Unknown168;
        public ushort Unknown169;
        public ushort Unknown170;
        public ushort Unknown171;
        public ushort Unknown172;
        public ushort Unknown173;
        public ushort Unknown174;
        public ushort Unknown175;
        public ushort Unknown176;
        public ushort Unknown177;
        public ushort Unknown178;
        public ushort Unknown179;
        public ushort Unknown180;
        public ushort Unknown181;
        public ushort Unknown182;
        public ushort Unknown183;
        public ushort Unknown184;
        public ushort Unknown185;
        public ushort Unknown186;
        public ushort Unknown187;
        public ushort Unknown188;
        public ushort Unknown189;
        public ushort Unknown190;
        public ushort Unknown191;
        public ushort Unknown192;
        public ushort Unknown193;
        public ushort Unknown194;
        public ushort Unknown195;
        public ushort Unknown196;
        public ushort Unknown197;
        public ushort Unknown198;
        public ushort Unknown199;
        public ushort Unknown200;
        public ushort Unknown201;
        public ushort Unknown202;
        public ushort Unknown203;
        public ushort Unknown204;
        public ushort Unknown205;
        public ushort Unknown206;
        public ushort Unknown207;
        public ushort Unknown208;
        public ushort Unknown209;
        public ushort Unknown210;
        public ushort Unknown211;
        public ushort Unknown212;
        public ushort Unknown213;
        public ushort Unknown214;
        public ushort Unknown215;
        public ushort Unknown216;
        public ushort Unknown217;
        public ushort Unknown218;
        public ushort Unknown219;
        public ushort Unknown220;
        public ushort Unknown221;
        public ushort Unknown222;
        public ushort Unknown223;
        public ushort Unknown224;
        public ushort Unknown225;
        public ushort Unknown226;
        public ushort Unknown227;
        public ushort Unknown228;
        public ushort Unknown229;
        public LazyRow< HWDCrafterSupplyReward >[] BaseCollectableReward;
        public LazyRow< HWDCrafterSupplyReward >[] MidCollectableReward;
        public LazyRow< HWDCrafterSupplyReward >[] HighCollectableReward;
        public LazyRow< HWDCrafterSupplyTerm >[] TermName;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            ItemTradeIn = new LazyRow< Item >[ 23 ];
            for( var i = 0; i < 23; i++ )
                ItemTradeIn[ i ] = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 0 + i ), language );
            Level = new byte[ 23 ];
            for( var i = 0; i < 23; i++ )
                Level[ i ] = parser.ReadColumn< byte >( 23 + i );
            LevelMax = new byte[ 23 ];
            for( var i = 0; i < 23; i++ )
                LevelMax[ i ] = parser.ReadColumn< byte >( 46 + i );
            BaseCollectableRating = new byte[ 23 ];
            for( var i = 0; i < 23; i++ )
                BaseCollectableRating[ i ] = parser.ReadColumn< byte >( 69 + i );
            MidCollectableRating = new ushort[ 23 ];
            for( var i = 0; i < 23; i++ )
                MidCollectableRating[ i ] = parser.ReadColumn< ushort >( 92 + i );
            HighCollectableRating = new ushort[ 23 ];
            for( var i = 0; i < 23; i++ )
                HighCollectableRating[ i ] = parser.ReadColumn< ushort >( 115 + i );
            Unknown138 = parser.ReadColumn< ushort >( 138 );
            Unknown139 = parser.ReadColumn< ushort >( 139 );
            Unknown140 = parser.ReadColumn< ushort >( 140 );
            Unknown141 = parser.ReadColumn< ushort >( 141 );
            Unknown142 = parser.ReadColumn< ushort >( 142 );
            Unknown143 = parser.ReadColumn< ushort >( 143 );
            Unknown144 = parser.ReadColumn< ushort >( 144 );
            Unknown145 = parser.ReadColumn< ushort >( 145 );
            Unknown146 = parser.ReadColumn< ushort >( 146 );
            Unknown147 = parser.ReadColumn< ushort >( 147 );
            Unknown148 = parser.ReadColumn< ushort >( 148 );
            Unknown149 = parser.ReadColumn< ushort >( 149 );
            Unknown150 = parser.ReadColumn< ushort >( 150 );
            Unknown151 = parser.ReadColumn< ushort >( 151 );
            Unknown152 = parser.ReadColumn< ushort >( 152 );
            Unknown153 = parser.ReadColumn< ushort >( 153 );
            Unknown154 = parser.ReadColumn< ushort >( 154 );
            Unknown155 = parser.ReadColumn< ushort >( 155 );
            Unknown156 = parser.ReadColumn< ushort >( 156 );
            Unknown157 = parser.ReadColumn< ushort >( 157 );
            Unknown158 = parser.ReadColumn< ushort >( 158 );
            Unknown159 = parser.ReadColumn< ushort >( 159 );
            Unknown160 = parser.ReadColumn< ushort >( 160 );
            Unknown161 = parser.ReadColumn< ushort >( 161 );
            Unknown162 = parser.ReadColumn< ushort >( 162 );
            Unknown163 = parser.ReadColumn< ushort >( 163 );
            Unknown164 = parser.ReadColumn< ushort >( 164 );
            Unknown165 = parser.ReadColumn< ushort >( 165 );
            Unknown166 = parser.ReadColumn< ushort >( 166 );
            Unknown167 = parser.ReadColumn< ushort >( 167 );
            Unknown168 = parser.ReadColumn< ushort >( 168 );
            Unknown169 = parser.ReadColumn< ushort >( 169 );
            Unknown170 = parser.ReadColumn< ushort >( 170 );
            Unknown171 = parser.ReadColumn< ushort >( 171 );
            Unknown172 = parser.ReadColumn< ushort >( 172 );
            Unknown173 = parser.ReadColumn< ushort >( 173 );
            Unknown174 = parser.ReadColumn< ushort >( 174 );
            Unknown175 = parser.ReadColumn< ushort >( 175 );
            Unknown176 = parser.ReadColumn< ushort >( 176 );
            Unknown177 = parser.ReadColumn< ushort >( 177 );
            Unknown178 = parser.ReadColumn< ushort >( 178 );
            Unknown179 = parser.ReadColumn< ushort >( 179 );
            Unknown180 = parser.ReadColumn< ushort >( 180 );
            Unknown181 = parser.ReadColumn< ushort >( 181 );
            Unknown182 = parser.ReadColumn< ushort >( 182 );
            Unknown183 = parser.ReadColumn< ushort >( 183 );
            Unknown184 = parser.ReadColumn< ushort >( 184 );
            Unknown185 = parser.ReadColumn< ushort >( 185 );
            Unknown186 = parser.ReadColumn< ushort >( 186 );
            Unknown187 = parser.ReadColumn< ushort >( 187 );
            Unknown188 = parser.ReadColumn< ushort >( 188 );
            Unknown189 = parser.ReadColumn< ushort >( 189 );
            Unknown190 = parser.ReadColumn< ushort >( 190 );
            Unknown191 = parser.ReadColumn< ushort >( 191 );
            Unknown192 = parser.ReadColumn< ushort >( 192 );
            Unknown193 = parser.ReadColumn< ushort >( 193 );
            Unknown194 = parser.ReadColumn< ushort >( 194 );
            Unknown195 = parser.ReadColumn< ushort >( 195 );
            Unknown196 = parser.ReadColumn< ushort >( 196 );
            Unknown197 = parser.ReadColumn< ushort >( 197 );
            Unknown198 = parser.ReadColumn< ushort >( 198 );
            Unknown199 = parser.ReadColumn< ushort >( 199 );
            Unknown200 = parser.ReadColumn< ushort >( 200 );
            Unknown201 = parser.ReadColumn< ushort >( 201 );
            Unknown202 = parser.ReadColumn< ushort >( 202 );
            Unknown203 = parser.ReadColumn< ushort >( 203 );
            Unknown204 = parser.ReadColumn< ushort >( 204 );
            Unknown205 = parser.ReadColumn< ushort >( 205 );
            Unknown206 = parser.ReadColumn< ushort >( 206 );
            Unknown207 = parser.ReadColumn< ushort >( 207 );
            Unknown208 = parser.ReadColumn< ushort >( 208 );
            Unknown209 = parser.ReadColumn< ushort >( 209 );
            Unknown210 = parser.ReadColumn< ushort >( 210 );
            Unknown211 = parser.ReadColumn< ushort >( 211 );
            Unknown212 = parser.ReadColumn< ushort >( 212 );
            Unknown213 = parser.ReadColumn< ushort >( 213 );
            Unknown214 = parser.ReadColumn< ushort >( 214 );
            Unknown215 = parser.ReadColumn< ushort >( 215 );
            Unknown216 = parser.ReadColumn< ushort >( 216 );
            Unknown217 = parser.ReadColumn< ushort >( 217 );
            Unknown218 = parser.ReadColumn< ushort >( 218 );
            Unknown219 = parser.ReadColumn< ushort >( 219 );
            Unknown220 = parser.ReadColumn< ushort >( 220 );
            Unknown221 = parser.ReadColumn< ushort >( 221 );
            Unknown222 = parser.ReadColumn< ushort >( 222 );
            Unknown223 = parser.ReadColumn< ushort >( 223 );
            Unknown224 = parser.ReadColumn< ushort >( 224 );
            Unknown225 = parser.ReadColumn< ushort >( 225 );
            Unknown226 = parser.ReadColumn< ushort >( 226 );
            Unknown227 = parser.ReadColumn< ushort >( 227 );
            Unknown228 = parser.ReadColumn< ushort >( 228 );
            Unknown229 = parser.ReadColumn< ushort >( 229 );
            BaseCollectableReward = new LazyRow< HWDCrafterSupplyReward >[ 23 ];
            for( var i = 0; i < 23; i++ )
                BaseCollectableReward[ i ] = new LazyRow< HWDCrafterSupplyReward >( lumina, parser.ReadColumn< ushort >( 230 + i ), language );
            MidCollectableReward = new LazyRow< HWDCrafterSupplyReward >[ 23 ];
            for( var i = 0; i < 23; i++ )
                MidCollectableReward[ i ] = new LazyRow< HWDCrafterSupplyReward >( lumina, parser.ReadColumn< ushort >( 253 + i ), language );
            HighCollectableReward = new LazyRow< HWDCrafterSupplyReward >[ 23 ];
            for( var i = 0; i < 23; i++ )
                HighCollectableReward[ i ] = new LazyRow< HWDCrafterSupplyReward >( lumina, parser.ReadColumn< ushort >( 276 + i ), language );
            TermName = new LazyRow< HWDCrafterSupplyTerm >[ 23 ];
            for( var i = 0; i < 23; i++ )
                TermName[ i ] = new LazyRow< HWDCrafterSupplyTerm >( lumina, parser.ReadColumn< byte >( 299 + i ), language );
        }
    }
}