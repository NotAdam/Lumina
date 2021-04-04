namespace Lumina.Data.Parsing
{
    /**
     * These values are actually CRC values used by SE in order to
     * coordinate mappings to shaders. Textures do not actually store
     * whether they are diffuse, specular, etc. They store the shader
     * that this texture is input for, in CRC form.
     *
     * That was my long way of explaining "these are linked manually."
     */
    public enum TextureUsage : uint
    {
        Sampler = 0x88408C04,
        Sampler0 = 0x213CB439,
        Sampler1 = 0x563B84AF,
        SamplerCatchlight = 0xFEA0F3D2,
        SamplerColorMap0 = 0x1E6FEF9C,
        SamplerColorMap1 = 0x6968DF0A,
        SamplerDiffuse = 0x115306BE,
        SamplerEnvMap = 0xF8D7957A,
        SamplerMask = 0x8A4E82B6,
        SamplerNormal = 0x0C5EC1F1,
        SamplerNormalMap0 = 0xAAB4D9E9,
        SamplerNormalMap1 = 0xDDB3E97F,
        SamplerReflection = 0x87F6474D,
        SamplerSpecular = 0x2B99E025,
        SamplerSpecularMap0 = 0x1BBC2F12,
        SamplerSpecularMap1 = 0x6CBB1F84,
        SamplerWaveMap = 0xE6321AFC,
        SamplerWaveletMap0 = 0x574E22D6,
        SamplerWaveletMap1 = 0x20491240,
        SamplerWhitecapMap = 0x95E1F64D
    }

    public struct MaterialFileHeader
    {
        public uint Version;
        public ushort FileSize;
        public ushort DataSetSize;
        public ushort StringTableSize;
        public ushort ShaderPackageNameOffset;
        public byte TextureCount;
        public byte UvSetCount;
        public byte ColorSetCount;
        public byte AdditionalDataSize;
    }

    public struct MaterialHeader
    {
        public ushort ShaderValueListSize;
        public ushort ShaderKeyCount;
        public ushort ConstantCount;
        public ushort SamplerCount;
        public ushort Unknown1;
        public ushort Unknown2;
    }

    public struct TextureOffset
    {
        public ushort Offset;
        public ushort Flags; // This is an assumption; has always been 32768 (0x8000)
    }

    public struct Constant
    {
        public uint ConstantId;
        public ushort ValueOffset;
        public ushort ValueSize;
    }

    public struct SamplerState
    {
        // Seems to be a bitfield, but no idea what the
        // values are for
        public uint Unknown;
    }

    public unsafe struct Sampler
    {
        public uint SamplerId;
        public SamplerState SamplerState;
        public byte TextureIndex;
        private fixed byte Padding[3];
    }

    public struct ShaderKey
    {
        public uint Category;
        public uint Value;
    }
    
    public struct UvColorSet
    {
        public ushort NameOffset;
        public ushort Index;
    }

    public unsafe struct ColorSetInfo
    {
        public fixed ushort Data[256];
    }

    public unsafe struct ColorSetDyeInfo
    {
        public fixed ushort Data[16];
    }
}