// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HWDCrafterSupply", columnHash: 0x888c75d1 )]
    public class HWDCrafterSupply : IExcelRow
    {
        
        public LazyRow< Item >[] ItemTradeIn;
        public byte[] Level;
        public byte[] LevelMax;
        public byte Unknown49;
        public byte Unknown50;
        public byte Unknown51;
        public byte Unknown52;
        public byte Unknown53;
        public byte Unknown54;
        public byte Unknown55;
        public byte Unknown56;
        public byte Unknown57;
        public byte Unknown58;
        public byte Unknown59;
        public byte Unknown60;
        public byte Unknown61;
        public byte Unknown62;
        public byte Unknown63;
        public byte Unknown64;
        public byte Unknown65;
        public byte Unknown66;
        public byte Unknown67;
        public ushort[] BaseCollectableRating;
        public ushort[] MidBaseCollectableRating;
        public ushort[] HighBaseCollectableRating;
        public LazyRow< HWDCrafterSupplyReward >[] BaseCollectableReward;
        public LazyRow< HWDCrafterSupplyReward >[] MidCollectableReward;
        public LazyRow< HWDCrafterSupplyReward >[] HighCollectableReward;
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
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            ItemTradeIn = new LazyRow< Item >[ 17 ];
            for( var i = 0; i < 17; i++ )
                ItemTradeIn[ i ] = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 0 + i ), language );
            Level = new byte[ 16 ];
            for( var i = 0; i < 16; i++ )
                Level[ i ] = parser.ReadColumn< byte >( 17 + i );
            LevelMax = new byte[ 16 ];
            for( var i = 0; i < 16; i++ )
                LevelMax[ i ] = parser.ReadColumn< byte >( 33 + i );
            Unknown49 = parser.ReadColumn< byte >( 49 );
            Unknown50 = parser.ReadColumn< byte >( 50 );
            Unknown51 = parser.ReadColumn< byte >( 51 );
            Unknown52 = parser.ReadColumn< byte >( 52 );
            Unknown53 = parser.ReadColumn< byte >( 53 );
            Unknown54 = parser.ReadColumn< byte >( 54 );
            Unknown55 = parser.ReadColumn< byte >( 55 );
            Unknown56 = parser.ReadColumn< byte >( 56 );
            Unknown57 = parser.ReadColumn< byte >( 57 );
            Unknown58 = parser.ReadColumn< byte >( 58 );
            Unknown59 = parser.ReadColumn< byte >( 59 );
            Unknown60 = parser.ReadColumn< byte >( 60 );
            Unknown61 = parser.ReadColumn< byte >( 61 );
            Unknown62 = parser.ReadColumn< byte >( 62 );
            Unknown63 = parser.ReadColumn< byte >( 63 );
            Unknown64 = parser.ReadColumn< byte >( 64 );
            Unknown65 = parser.ReadColumn< byte >( 65 );
            Unknown66 = parser.ReadColumn< byte >( 66 );
            Unknown67 = parser.ReadColumn< byte >( 67 );
            BaseCollectableRating = new ushort[ 17 ];
            for( var i = 0; i < 17; i++ )
                BaseCollectableRating[ i ] = parser.ReadColumn< ushort >( 68 + i );
            MidBaseCollectableRating = new ushort[ 17 ];
            for( var i = 0; i < 17; i++ )
                MidBaseCollectableRating[ i ] = parser.ReadColumn< ushort >( 85 + i );
            HighBaseCollectableRating = new ushort[ 17 ];
            for( var i = 0; i < 17; i++ )
                HighBaseCollectableRating[ i ] = parser.ReadColumn< ushort >( 102 + i );
            BaseCollectableReward = new LazyRow< HWDCrafterSupplyReward >[ 17 ];
            for( var i = 0; i < 17; i++ )
                BaseCollectableReward[ i ] = new LazyRow< HWDCrafterSupplyReward >( lumina, parser.ReadColumn< ushort >( 119 + i ), language );
            MidCollectableReward = new LazyRow< HWDCrafterSupplyReward >[ 17 ];
            for( var i = 0; i < 17; i++ )
                MidCollectableReward[ i ] = new LazyRow< HWDCrafterSupplyReward >( lumina, parser.ReadColumn< ushort >( 136 + i ), language );
            HighCollectableReward = new LazyRow< HWDCrafterSupplyReward >[ 17 ];
            for( var i = 0; i < 17; i++ )
                HighCollectableReward[ i ] = new LazyRow< HWDCrafterSupplyReward >( lumina, parser.ReadColumn< ushort >( 153 + i ), language );
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
        }
    }
}