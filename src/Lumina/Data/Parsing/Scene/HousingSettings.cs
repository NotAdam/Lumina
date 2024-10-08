namespace Lumina.Data.Parsing.Scene
{
    public struct HousingSettings
    {
        public ushort DefaultColorID;

        public byte Unknown02;
        public byte Padding03;
        public uint Unknown04;
        // 6
        public uint[] Unknown08;
        public uint Unknown20;
        public uint Unknown24;
        public uint Unknown28;
        public uint Unknown2C;
        public uint Unknown30;
        public byte Unknown34;
        // 3
        public byte[] Padding35;
        public uint Unknown38;
        public uint Unknown3C;
        public uint Unknown40;
        
        public static HousingSettings Read( LuminaBinaryReader br )
        {
            HousingSettings ret = new HousingSettings();

            ret.DefaultColorID = br.ReadUInt16();

            ret.Unknown02 = br.ReadByte();
            ret.Padding03 = br.ReadByte();
            ret.Unknown04 = br.ReadUInt32();
            ret.Unknown08 = br.ReadUInt32Array( 6 );
            ret.Unknown20 = br.ReadUInt32();
            ret.Unknown24 = br.ReadUInt32();
            ret.Unknown28 = br.ReadUInt32();
            ret.Unknown2C = br.ReadUInt32();
            ret.Unknown30 = br.ReadUInt32();
            ret.Unknown34 = br.ReadByte();
            ret.Padding35 = br.ReadBytes( 3 );
            ret.Unknown38 = br.ReadUInt32();
            ret.Unknown3C = br.ReadUInt32();
            ret.Unknown40 = br.ReadUInt32();

            return ret;
        }
    }
}