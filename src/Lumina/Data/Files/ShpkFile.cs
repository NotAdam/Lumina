using System.IO;
using Lumina.Data.Attributes;

namespace Lumina.Data.Files;

/// <summary>
/// The header and top-level tables of a shader package.
/// </summary>
[FileExtension( ".shpk" )]
public class ShpkFile : FileResource
{
    public const uint ShpkMagic = 0x6B506853;

    public const uint VersionTessellation = 0x0D01;
    public const uint VersionNodeAliasClusters = 0x0E01;

    public uint Version { get; private set; }

    /// <summary>
    /// The DirectX version this package was built for, either <c>DX11</c> or <c>DX9</c>.
    /// </summary>
    public string DirectXVersion { get; private set; } = null!;

    public uint TotalSize { get; private set; }
    public uint BlobsOffset { get; private set; }
    public uint StringsOffset { get; private set; }

    public uint VertexShaderCount { get; private set; }
    public uint PixelShaderCount { get; private set; }

    public uint MaterialParamsSize { get; private set; }
    public ushort MaterialParamCount { get; private set; }
    public bool HasParamDefaults { get; private set; }

    public uint ConstantCount { get; private set; }
    public ushort SamplerCount { get; private set; }
    public ushort TextureCount { get; private set; }
    public uint UavCount { get; private set; }

    public uint SystemKeyCount { get; private set; }
    public uint SceneKeyCount { get; private set; }
    public uint MaterialKeyCount { get; private set; }

    public uint NodeCount { get; private set; }
    public uint NodeAliasCount { get; private set; }

    public uint HullShaderCount { get; private set; }
    public uint DomainShaderCount { get; private set; }
    public uint GeometryShaderCount { get; private set; }

    public uint NodeAliasClusterCount { get; private set; }

    public override void LoadFile()
    {
        Reader.BaseStream.Position = 0;

        if( Reader.ReadUInt32() != ShpkMagic )
            throw new InvalidDataException( "Not a shpk file" );

        Version = Reader.ReadUInt32();
        DirectXVersion = System.Text.Encoding.ASCII.GetString( Reader.ReadBytes( 4 ) );

        TotalSize = Reader.ReadUInt32();
        BlobsOffset = Reader.ReadUInt32();
        StringsOffset = Reader.ReadUInt32();

        VertexShaderCount = Reader.ReadUInt32();
        PixelShaderCount = Reader.ReadUInt32();

        MaterialParamsSize = Reader.ReadUInt32();
        MaterialParamCount = Reader.ReadUInt16();
        HasParamDefaults = Reader.ReadUInt16() != 0;

        ConstantCount = Reader.ReadUInt32();
        SamplerCount = Reader.ReadUInt16();
        TextureCount = Reader.ReadUInt16();
        UavCount = Reader.ReadUInt32();

        SystemKeyCount = Reader.ReadUInt32();
        SceneKeyCount = Reader.ReadUInt32();
        MaterialKeyCount = Reader.ReadUInt32();

        NodeCount = Reader.ReadUInt32();
        NodeAliasCount = Reader.ReadUInt32();

        // tessellation stages and alias clusters were appended to the header, not inserted
        if( Version >= VersionTessellation )
        {
            HullShaderCount = Reader.ReadUInt32();
            DomainShaderCount = Reader.ReadUInt32();
            GeometryShaderCount = Reader.ReadUInt32();
        }

        if( Version >= VersionNodeAliasClusters )
            NodeAliasClusterCount = Reader.ReadUInt32();
    }
}
