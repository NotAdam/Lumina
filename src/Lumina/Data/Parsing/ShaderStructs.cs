using System.IO;
using Lumina.Extensions;

namespace Lumina.Data.Parsing
{
    // Here is a catch-all comment telling you to check the template if you have access
    public class ShaderStructs
    {
        struct ShaderHeader
        {
            public uint Magic;
            public uint Version;
            public uint Platform;
            public uint FileSize;
            public uint CodeStart;
            public uint StringsStart;

            public static ShaderHeader Read(BinaryReader br)
            {
                ShaderHeader ret = new ShaderHeader();
                ret.Magic = br.ReadUInt32();
                ret.Version = br.ReadUInt32();
                ret.Platform = br.ReadUInt32();
                ret.FileSize = br.ReadUInt32();
                ret.CodeStart = br.ReadUInt32();
                ret.StringsStart = br.ReadUInt32();
                return ret;
            }
        }
        
        struct ShaderPackageHeader
        {
            public ShaderHeader ShaderHeader;
            public uint VertexShaderCount;
            public uint PixelShaderCount;
            public uint MaterialBufferSize;
            public uint MaterialElementCount;
            public uint ConstantCount;
            public uint SamplerCount;
            public uint RwResourceCount;
            public uint SystemKeyCount;
            public uint SceneKeyCount;
            public uint MaterialKeyCount;
            public uint ShaderNodeCount;
            public uint ReferenceNodeCount;
            
            public static ShaderPackageHeader Read(BinaryReader br)
            {
                ShaderPackageHeader ret = new ShaderPackageHeader();
                ret.ShaderHeader = br.ReadStructure< ShaderHeader >();
                ret.VertexShaderCount = br.ReadUInt32();
                ret.PixelShaderCount = br.ReadUInt32();
                ret.MaterialBufferSize = br.ReadUInt32();
                ret.MaterialElementCount = br.ReadUInt32();
                ret.ConstantCount = br.ReadUInt32();
                ret.SamplerCount = br.ReadUInt32();
                ret.RwResourceCount = br.ReadUInt32();
                ret.SystemKeyCount = br.ReadUInt32();
                ret.SceneKeyCount = br.ReadUInt32();
                ret.MaterialKeyCount = br.ReadUInt32();
                ret.ShaderNodeCount = br.ReadUInt32();
                ret.ReferenceNodeCount = br.ReadUInt32();
                return ret;
            }
        }

        struct ShaderParameter
        {
            public uint ShaderParameterKey;
            public uint ParameterNameOffset;
            public uint ParameterNameSize;
            public ushort RegisterIndex;
            public ushort RegisterCount;
        }

        struct ShaderCode
        {
            public uint ShaderCodeOffset;
            public uint ShaderCodeSize;
            public ushort ConstantCount;
            public ushort SamplerCount;
            public ushort RwResourceCount;
            public ushort Unknown2;
            public ShaderParameter[] ShaderParameters;
            
            public static ShaderCode Read(BinaryReader br)
            {
                ShaderCode ret = new ShaderCode();
                ret.ShaderCodeOffset = br.ReadUInt32();
                ret.ShaderCodeSize = br.ReadUInt32();
                ret.ConstantCount = br.ReadUInt16();
                ret.SamplerCount = br.ReadUInt16();
                ret.RwResourceCount = br.ReadUInt16();
                ret.Unknown2 = br.ReadUInt16();
                ret.ShaderParameters = br.ReadStructuresAsArray<ShaderParameter>(ret.ConstantCount + ret.SamplerCount + ret.RwResourceCount);
                return ret;
            }
        }

        struct ShaderMaterial
        {
            public uint Material;
            public ushort Offset;
            public ushort Size;
        }

        struct ShaderPass
        {
            public uint ShaderPassId;
            public uint VertexShaderIndex;
            public uint PixelShaderIndex;
        }

        struct ShaderNode
        {
            public uint ShaderNodeKey;
            public uint ShaderPassCount;
            public byte[] ShaderPassIndices;
            public uint[] ShaderKeys;
            public ShaderPass[] ShaderPass;
        }

        struct ShaderKeyValue
        {
            public uint Key;
            public uint Value;
        }
    }
}