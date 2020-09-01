using System;
using System.Diagnostics;
using Lumina.Data.Structs;
using Lumina.Extensions;
using static Lumina.Data.Parsing.Mdl.MdlStructs;

namespace Lumina.Data.Files {
    public class MdlFile : FileResource {
        public ModelFileHeader FileHeader;
        public VertexDeclarationStruct[] VertexDeclarations;
        public ModelHeader ModelHeader;
        public ElementIdStruct[] ElementIds;
        public LodStruct[] Lods;
        public ExtraLodStruct[] ExtraLods;
        public MeshStruct[] Meshes;
        public uint[] AttributeNameOffsets;
        public SubmeshStruct[] Submeshes;

        public TerrainShadowMeshStruct[] TerrainShadowMeshes;
        public TerrainShadowSubmeshStruct[] TerrainShadowSubmeshes;

        public uint[] MaterialNameOffsets;
        public uint[] BoneNameOffsets;
        public BoneTableStruct[] BoneTables;
        public ShapeStruct[] Shapes;
        public ShapeMeshStruct[] ShapeMeshes;
        public ShapeValueStruct[] ShapeValues;

        public ushort[] SubmeshBoneMap;
        public BoundingBoxStruct BoundingBoxes;
        public BoundingBoxStruct ModelBoundingBoxes;
        public BoundingBoxStruct WaterBoundingBoxes;
        public BoundingBoxStruct VerticalFogBoundingBoxes;
        public BoundingBoxStruct[] BoneBoundingBoxes;

        public ushort StringCount;
        public byte[] Strings;

        public byte[][] VertexBuffers;
        public byte[][] IndexBuffers;

        public override void LoadFile()
        {
            // We can ensure based on content-type that files are models
            if( FileInfo.Type != FileType.Model )
            {
                Console.WriteLine( $"Attempted to load {FilePath} of content type {FileInfo.Type} as a model, returning..." );
                return;
            }

            FileHeader = ModelFileHeader.Read( Reader );

            VertexDeclarations = new VertexDeclarationStruct[FileHeader.VertexDeclarationNum];
            for( int i = 0; i < FileHeader.VertexDeclarationNum; i++ ) VertexDeclarations[ i ] = VertexDeclarationStruct.Read( Reader );

            StringCount = Reader.ReadUInt16();
            Reader.ReadUInt16();
            uint stringSize = Reader.ReadUInt32();
            Strings = Reader.ReadBytes( (int) stringSize );

            ModelHeader = ModelHeader.Read( Reader );
            ElementIds = new ElementIdStruct[ModelHeader.ElementIdNum];
            Lods = new LodStruct[3];
            Meshes = new MeshStruct[ModelHeader.MeshNum];
            Submeshes = new SubmeshStruct[ModelHeader.SubmeshNum];
            TerrainShadowMeshes = new TerrainShadowMeshStruct[ModelHeader.TerrainShadowMeshNum];
            TerrainShadowSubmeshes = new TerrainShadowSubmeshStruct[ModelHeader.TerrainShadowSubmeshNum];
            BoneTables = new BoneTableStruct[ModelHeader.BoneTableNum];
            Shapes = new ShapeStruct[ModelHeader.ShapeNum];
            ShapeMeshes = new ShapeMeshStruct[ModelHeader.ShapeMeshNum];
            ShapeValues = new ShapeValueStruct[ModelHeader.ShapeValueNum];
            BoneBoundingBoxes = new BoundingBoxStruct[ModelHeader.BoneNum];

            VertexBuffers = new byte[3][];
            IndexBuffers = new byte[3][];

            for( int i = 0; i < ModelHeader.ElementIdNum; i++ ) ElementIds[ i ] = ElementIdStruct.Read( Reader );
            for( int i = 0; i < 3; i++ ) Lods[ i ] = LodStruct.Read( Reader );

            if( ModelHeader.ExtraLodEnabled ) {
                ExtraLods = new ExtraLodStruct[3];
                for( int i = 0; i < 3; i++ ) ExtraLods[ i ] = ExtraLodStruct.Read( Reader );
            }

            for( int i = 0; i < ModelHeader.MeshNum; i++ ) Meshes[ i ] = MeshStruct.Read( Reader );
            AttributeNameOffsets = Reader.ReadStructures< UInt32 >( ModelHeader.AttributeNum ).ToArray();
            for( int i = 0; i < ModelHeader.SubmeshNum; i++ ) Submeshes[ i ] = SubmeshStruct.Read( Reader );
            for( int i = 0; i < ModelHeader.TerrainShadowMeshNum; i++ ) TerrainShadowMeshes[ i ] = TerrainShadowMeshStruct.Read( Reader );
            for( int i = 0; i < ModelHeader.TerrainShadowSubmeshNum; i++ ) TerrainShadowSubmeshes[ i ] = TerrainShadowSubmeshStruct.Read( Reader );

            MaterialNameOffsets = Reader.ReadStructures< UInt32 >( ModelHeader.MaterialNum ).ToArray();
            BoneNameOffsets = Reader.ReadStructures< UInt32 >( ModelHeader.BoneNum ).ToArray();
            for( int i = 0; i < ModelHeader.BoneTableNum; i++ ) BoneTables[ i ] = BoneTableStruct.Read( Reader );

            for( int i = 0; i < ModelHeader.ShapeNum; i++ ) Shapes[ i ] = ShapeStruct.Read( Reader );
            for( int i = 0; i < ModelHeader.ShapeMeshNum; i++ ) ShapeMeshes[ i ] = ShapeMeshStruct.Read( Reader );
            for( int i = 0; i < ModelHeader.ShapeValueNum; i++ ) ShapeValues[ i ] = ShapeValueStruct.Read( Reader );

            uint submeshBoneMapSize = Reader.ReadUInt32();
            SubmeshBoneMap = Reader.ReadStructures< UInt16 >( (int) submeshBoneMapSize / 2 ).ToArray();

            byte paddingAmount = Reader.ReadByte();
            Reader.Seek( Reader.BaseStream.Position + paddingAmount );

            // Dunno what this first one is for?
            BoundingBoxes = BoundingBoxStruct.Read( Reader );
            ModelBoundingBoxes = BoundingBoxStruct.Read( Reader );
            WaterBoundingBoxes = BoundingBoxStruct.Read( Reader );
            VerticalFogBoundingBoxes = BoundingBoxStruct.Read( Reader );
            for( int i = 0; i < ModelHeader.BoneNum; i++ ) BoneBoundingBoxes[ i ] = BoundingBoxStruct.Read( Reader );

            for( int i = 0; i < 3; i++ ) {
                Reader.BaseStream.Position = FileHeader.VertexOffset[ i ];
                VertexBuffers[ i ] = Reader.ReadBytes( (int) FileHeader.VertexBufferSize[ i ] );

                Reader.BaseStream.Position = FileHeader.IndexOffset[ i ];
                IndexBuffers[ i ] = Reader.ReadBytes( (int) FileHeader.IndexBufferSize[ i ] );
            }
        }
    }
}

/*
// goes after file header, testing for something?
byte Stack[fileHeader.StackMemorySize] <bgcolor=0xff0000>;
byte Runtime[fileHeader.RuntimeMemorySize] <bgcolor=0x00ff00>;

local int i = 0;
for (i = 0; i < 3; i++) {
    //FSeek(sizeof(Model_File_Header_Block) + fileHeader.VertexDataOffset[i]);
    FSeek(fileHeader.VertexDataOffset[i]);
    ByteArr vertBuffer(fileHeader.VertexBufferSize[i]) <bgcolor=0x0000ff>;

    //FSeek(sizeof(Model_File_Header_Block) + fileHeader.IndexDataOffset[i]);
    FSeek(fileHeader.IndexDataOffset[i]);
    ByteArr indexBuffer(fileHeader.IndexBufferSize[i]) <bgcolor=0xff0000>;
}*/

/*
// header testing code
FSeek(fileHeader.VertexDataOffset[0]);
hfloat ignore[meshHeaders[0].VertexBufferOffset[1] / 2];

struct VertTest1
{
    hfloat normal[4];
    byte tangent[4];
    hfloat texcoord[2];
};

struct VertTest2
{
    uint ny : 11;
    uint nx : 11;
    uint nz : 10;
    byte tangent[4];
    hfloat texcoord[2];
};

if (IsBigEndian()) {
    VertTest2 test[20];
} else {
    VertTest1 test[20];
}

FSeek(fileHeader.IndexDataOffset[0]);
ushort indexBuffer[fileHeader.IndexBufferSize[0] / 2] <bgcolor=0xff0000>;
*/