using System.Numerics;
using Lumina.Data.Attributes;
using Lumina.Extensions;

namespace Lumina.Data.Files;

/// <summary>
/// A collection of bone deformations for transforming between character skeletons.
/// </summary>
[FileExtension( ".pbd" )]
public class PbdFile : FileResource
{
    public struct Deformer
    {
        public ushort Id;
        public ushort NodeIndex;
        public int DataOffset;
        public float Scale;

        /// <summary>
        /// The names of the bones this deformer transforms, and one transform per bone. Both are empty when
        /// <see cref="DataOffset"/> is unset.
        /// </summary>
        public string[] BoneNames;

        public Matrix4x4[] BoneMatrices;
    }

    public struct Node
    {
        public ushort ParentIndex;
        public ushort FirstChildIndex;
        public ushort NextIndex;
        public ushort DeformerIndex;
    }

    public Deformer[] Deformers { get; private set; } = null!;
    public Node[] Nodes { get; private set; } = null!;

    public override void LoadFile()
    {
        Reader.BaseStream.Position = 0;

        var count = Reader.ReadUInt32();

        Deformers = new Deformer[count];
        for( var i = 0; i < count; i++ )
        {
            Deformers[ i ].Id = Reader.ReadUInt16();
            Deformers[ i ].NodeIndex = Reader.ReadUInt16();
            Deformers[ i ].DataOffset = Reader.ReadInt32();
            Deformers[ i ].Scale = Reader.ReadSingle();
        }

        Nodes = new Node[count];
        for( var i = 0; i < count; i++ )
        {
            Nodes[ i ].ParentIndex = Reader.ReadUInt16();
            Nodes[ i ].FirstChildIndex = Reader.ReadUInt16();
            Nodes[ i ].NextIndex = Reader.ReadUInt16();
            Nodes[ i ].DeformerIndex = Reader.ReadUInt16();
        }

        for( var i = 0; i < count; i++ )
        {
            if( Deformers[ i ].DataOffset <= 0 )
            {
                Deformers[ i ].BoneNames = [];
                Deformers[ i ].BoneMatrices = [];
                continue;
            }

            ReadBoneMatrices( ref Deformers[ i ] );
        }
    }

    private void ReadBoneMatrices( ref Deformer deformer )
    {
        Reader.BaseStream.Position = deformer.DataOffset;

        // name offsets are relative to the start of the deformer's data block
        var baseOffset = deformer.DataOffset;
        var boneCount = checked( (int)Reader.ReadUInt32() );

        var nameOffsets = Reader.ReadInt16Array( boneCount );

        deformer.BoneNames = new string[boneCount];
        for( var i = 0; i < boneCount; i++ )
        {
            Reader.BaseStream.Position = baseOffset + nameOffsets[ i ];
            deformer.BoneNames[ i ] = Reader.ReadStringData();
        }

        // the matrices follow the name offset table, aligned to 4 bytes
        var afterNames = baseOffset + 4 + boneCount * sizeof( short );
        Reader.BaseStream.Position = ( afterNames + 3 ) / 4 * 4;

        deformer.BoneMatrices = new Matrix4x4[boneCount];
        for( var i = 0; i < boneCount; i++ )
        {
            var row0 = ReadVector4();
            var row1 = ReadVector4();
            var row2 = ReadVector4();
            deformer.BoneMatrices[ i ] = new Matrix4x4(
                row0.X, row0.Y, row0.Z, row0.W,
                row1.X, row1.Y, row1.Z, row1.W,
                row2.X, row2.Y, row2.Z, row2.W,
                0, 0, 0, 1 );
        }
    }

    private Vector4 ReadVector4() =>
        new( Reader.ReadSingle(), Reader.ReadSingle(), Reader.ReadSingle(), Reader.ReadSingle() );
}
