using System;
using System.IO;
using Lumina.Data.Attributes;

namespace Lumina.Data.Files;

/// <summary>
/// Skeleton data and its related mappings.
/// </summary>
[FileExtension( ".sklb" )]
public class SklbFile : FileResource
{
    public const uint SklbMagic = 0x736B6C62;

    /// <summary>
    /// The version of a skeleton file. This is a XIV-specific tag, and does not correlate with the version of
    /// the embedded tagfile.
    /// </summary>
    public enum SklbVersion : uint
    {
        V1100 = 0x31313030,
        V1110 = 0x31313130,
        V1200 = 0x31323030,
        V1300 = 0x31333030,
        V1301 = 0x31333031,
    }

    public SklbVersion Version { get; private set; }

    public uint LayerOffset { get; private set; }
    public uint SkeletonOffset { get; private set; }

    public uint CharacterId { get; private set; }
    public uint[] MapperCharacterId { get; private set; } = null!;
    public short[] ConnectBones { get; private set; } = null!;

    /// <summary>
    /// The number of bones sampled per level of detail. Only present on files older than
    /// <see cref="SklbVersion.V1300"/>, and empty otherwise.
    /// </summary>
    public short[] LodSampleBoneCount { get; private set; } = null!;

    /// <summary>
    /// The skeleton itself, in Havok binary tagfile format.
    /// </summary>
    public byte[] Skeleton { get; private set; } = null!;

    public override void LoadFile()
    {
        Reader.BaseStream.Position = 0;

        if( Reader.ReadUInt32() != SklbMagic )
            throw new InvalidDataException( "Not a sklb file" );

        Version = (SklbVersion)Reader.ReadUInt32();

        // the header widened its offsets and dropped the lod counts in 1300
        if( Version is SklbVersion.V1300 or SklbVersion.V1301 )
        {
            LayerOffset = Reader.ReadUInt32();
            SkeletonOffset = Reader.ReadUInt32();
            var connectBoneIndex = Reader.ReadInt16();
            Reader.ReadUInt16();
            CharacterId = Reader.ReadUInt32();
            MapperCharacterId = Reader.ReadUInt32Array( 4 );
            var bones = Reader.ReadInt16Array( 4 );
            ConnectBones = Version == SklbVersion.V1301 ? bones : [connectBoneIndex];
            LodSampleBoneCount = [];
        }
        else
        {
            LayerOffset = Reader.ReadUInt16();
            SkeletonOffset = Reader.ReadUInt16();
            CharacterId = Reader.ReadUInt32();
            MapperCharacterId = Reader.ReadUInt32Array( 4 );
            LodSampleBoneCount = Reader.ReadInt16Array( 3 );
            ConnectBones = Reader.ReadInt16Array( 4 );
        }

        Reader.BaseStream.Position = SkeletonOffset;
        Skeleton = Reader.ReadBytes( checked( (int)( Reader.BaseStream.Length - SkeletonOffset ) ) );
    }
}
