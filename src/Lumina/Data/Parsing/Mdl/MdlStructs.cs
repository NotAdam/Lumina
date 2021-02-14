using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Lumina.Extensions;

// Here is a catch-all comment telling you to check the template if you have access
namespace Lumina.Data.Parsing.Mdl
{
    public static class MdlStructs
    {
        public struct ModelFileHeader
        {
            public uint Version;
            public uint StackSize;
            public uint RuntimeSize;
            public ushort VertexDeclarationCount;
            public ushort MaterialCount;
            public uint[] VertexOffset;
            public uint[] IndexOffset;
            public uint[] VertexBufferSize;
            public uint[] IndexBufferSize;
            public byte LodCount;
            public bool EnableIndexBufferStreaming;
            public bool EnableEdgeGeometry;
            private byte Padding;

            public static ModelFileHeader Read( BinaryReader br )
            {
                ModelFileHeader ret = new ModelFileHeader();
                ret.Version = br.ReadUInt32();
                ret.StackSize = br.ReadUInt32();
                ret.RuntimeSize = br.ReadUInt32();
                ret.VertexDeclarationCount = br.ReadUInt16();
                ret.MaterialCount = br.ReadUInt16();
                ret.VertexOffset = br.ReadStructures< UInt32 >( 3 ).ToArray();
                ret.IndexOffset = br.ReadStructures< UInt32 >( 3 ).ToArray();
                ret.VertexBufferSize = br.ReadStructures< UInt32 >( 3 ).ToArray();
                ret.IndexBufferSize = br.ReadStructures< UInt32 >( 3 ).ToArray();
                ret.LodCount = br.ReadByte();
                ret.EnableIndexBufferStreaming = br.ReadBoolean();
                ret.EnableEdgeGeometry = br.ReadBoolean();
                ret.Padding = br.ReadByte();
                if( ret.EnableEdgeGeometry )
                    Console.WriteLine( "Win32 file with EdgeGeometry enabled?" );
                return ret;
            }
        }

        public struct VertexDeclarationStruct
        {
            // There are always 17, but stop when stream = -1
            public VertexElement[] VertexElements;

            public static VertexDeclarationStruct Read( BinaryReader br )
            {
                VertexDeclarationStruct ret = new VertexDeclarationStruct();

                var elems = new List< VertexElement >();

                // Read the vertex elements that we need
                var thisElem = VertexElement.Read( br );
                do
                {
                    elems.Add( thisElem );
                    thisElem = VertexElement.Read( br );
                } while( thisElem.Stream != 255 );

                // Skip the number of bytes that we don't need to read
                // We skip elems.Count * 9 because we had to read the invalid element
                int toSeek = ( 17 * 8 ) - ( ( elems.Count + 1 ) * 8 );
                br.Seek( br.BaseStream.Position + toSeek );

                ret.VertexElements = elems.ToArray();

                return ret;
            }
        }

        public struct VertexElement
        {
            public byte Stream;
            public byte Offset;
            public byte Type;
            public byte Usage;
            public byte UsageIndex; // D3D9 remnant?
            private byte[] Padding;

            public static VertexElement Read( BinaryReader br )
            {
                VertexElement ret = new VertexElement();
                ret.Stream = br.ReadByte();
                ret.Offset = br.ReadByte();
                ret.Type = br.ReadByte();
                ret.Usage = br.ReadByte();
                ret.UsageIndex = br.ReadByte();
                ret.Padding = br.ReadBytes( 3 );
                return ret;
            }
        }

        public struct ModelHeader
        {
            // MeshHeader
            public float Radius;
            public ushort MeshCount;
            public ushort AttributeCount;
            public ushort SubmeshCount;
            public ushort MaterialCount;
            public ushort BoneCount;
            public ushort BoneTableCount;
            public ushort ShapeCount;
            public ushort ShapeMeshCount;
            public ushort ShapeValueCount;
            public byte LodCount;

            private byte bitfield1;

            public bool DustOcclusionEnabled;
            public bool SnowOcclusionEnabled;
            public bool RainOcclusionEnabled;
            public bool Unknown1;
            public bool BGLightingReflectionEnabled;
            public bool WavingAnimationDisabled;
            public bool LightShadowDisabled;
            public bool ShadowDisabled;
            public ushort ElementIdCount;
            public byte TerrainShadowMeshCount;

            private byte bitfield2;

            public bool Unknown2;
            public bool BgUvScrollEnabled;
            public bool EnableForceNonResident;
            public bool ExtraLodEnabled;
            public bool ShadowMaskEnabled;
            public bool ForceLodRangeEnabled;
            public bool EdgeGeometryEnabled;
            public bool Unknown3;

            public float ModelClipOutDistance;
            public float ShadowClipOutDistance;
            public ushort Unknown4;
            public ushort TerrainShadowSubmeshCount;

            private byte Unknown5;

            public byte BGChangeMaterialIndex;
            public byte BGCrestChangeMaterialIndex;
            public byte Unknown6;
            public ushort Unknown7;
            public ushort Unknown8;
            public ushort Unknown9;
            private byte[] Padding00;

            public static ModelHeader Read( BinaryReader br )
            {
                ModelHeader ret = new ModelHeader();
                ret.Radius = br.ReadSingle();
                ret.MeshCount = br.ReadUInt16();
                ret.AttributeCount = br.ReadUInt16();
                ret.SubmeshCount = br.ReadUInt16();
                ret.MaterialCount = br.ReadUInt16();
                ret.BoneCount = br.ReadUInt16();
                ret.BoneTableCount = br.ReadUInt16();
                ret.ShapeCount = br.ReadUInt16();
                ret.ShapeMeshCount = br.ReadUInt16();
                ret.ShapeValueCount = br.ReadUInt16();
                ret.LodCount = br.ReadByte();

                ret.bitfield1 = br.ReadByte();
                ret.DustOcclusionEnabled = ( ret.bitfield1 & 0x80 ) == 0x80;
                ret.SnowOcclusionEnabled = ( ret.bitfield1 & 0x40 ) == 0x40;
                ret.RainOcclusionEnabled = ( ret.bitfield1 & 0x20 ) == 0x20;
                ret.Unknown1 = ( ret.bitfield1 & 0x10 ) == 0x10;
                ret.BGLightingReflectionEnabled = ( ret.bitfield1 & 0x08 ) == 0x08;
                ret.WavingAnimationDisabled = ( ret.bitfield1 & 0x04 ) == 0x04;
                ret.LightShadowDisabled = ( ret.bitfield1 & 0x02 ) == 0x02;
                ret.ShadowDisabled = ( ret.bitfield1 & 0x01 ) == 0x01;

                ret.ElementIdCount = br.ReadUInt16();
                ret.TerrainShadowMeshCount = br.ReadByte();

                ret.bitfield2 = br.ReadByte();
                ret.Unknown2 = ( ret.bitfield2 & 0x80 ) == 0x80;
                ret.BgUvScrollEnabled = ( ret.bitfield2 & 0x40 ) == 0x40;
                ret.EnableForceNonResident = ( ret.bitfield2 & 0x20 ) == 0x20;
                ret.ExtraLodEnabled = ( ret.bitfield2 & 0x10 ) == 0x10;
                ret.ShadowMaskEnabled = ( ret.bitfield2 & 0x08 ) == 0x08;
                ret.ForceLodRangeEnabled = ( ret.bitfield2 & 0x04 ) == 0x04;
                ret.EdgeGeometryEnabled = ( ret.bitfield2 & 0x02 ) == 0x02;
                ret.Unknown3 = ( ret.bitfield2 & 0x01 ) == 0x01;

                ret.ModelClipOutDistance = br.ReadSingle();
                ret.ShadowClipOutDistance = br.ReadSingle();
                ret.Unknown4 = br.ReadUInt16();
                ret.TerrainShadowSubmeshCount = br.ReadUInt16();
                ret.Unknown5 = br.ReadByte();
                ret.BGChangeMaterialIndex = br.ReadByte();
                ret.BGCrestChangeMaterialIndex = br.ReadByte();
                ret.Unknown6 = br.ReadByte();
                ret.Unknown7 = br.ReadUInt16();
                ret.Unknown8 = br.ReadUInt16();
                ret.Unknown9 = br.ReadUInt16();
                ret.Padding00 = br.ReadBytes( 6 ).ToArray();
                return ret;
            }
        }

        public struct ElementIdStruct
        {
            public uint ElementId;
            public uint ParentBoneName;
            public float[] Translate;
            public float[] Rotate;

            public static ElementIdStruct Read( BinaryReader br )
            {
                ElementIdStruct ret = new ElementIdStruct();
                ret.ElementId = br.ReadUInt32();
                ret.ParentBoneName = br.ReadUInt32();
                ret.Translate = br.ReadStructures< Single >( 3 ).ToArray();
                ret.Rotate = br.ReadStructures< Single >( 3 ).ToArray();
                return ret;
            }
        }

        public struct LodStruct
        {
            public ushort MeshIndex;
            public ushort MeshCount;
            public float ModelLodRange;
            public float TextureLodRange;
            public ushort WaterMeshIndex;
            public ushort WaterMeshCount;
            public ushort ShadowMeshIndex;
            public ushort ShadowMeshCount;
            public ushort TerrainShadowMeshIndex;
            public ushort TerrainShadowMeshCount;
            public ushort VerticalFogMeshIndex;
            public ushort VerticalFogMeshCount;
            // Yell at me if this ever exists on Win32
            public uint EdgeGeometrySize;
            public uint EdgeGeometryDataOffset;
            public uint PolygonCount;
            public uint Unknown1;
            public uint VertexBufferSize;
            public uint IndexBufferSize;
            public uint VertexDataOffset;
            public uint IndexDataOffset;

            public static LodStruct Read( BinaryReader br )
            {
                LodStruct ret = new LodStruct();
                ret.MeshIndex = br.ReadUInt16();
                ret.MeshCount = br.ReadUInt16();
                ret.ModelLodRange = br.ReadSingle();
                ret.TextureLodRange = br.ReadSingle();
                ret.WaterMeshIndex = br.ReadUInt16();
                ret.WaterMeshCount = br.ReadUInt16();
                ret.ShadowMeshIndex = br.ReadUInt16();
                ret.ShadowMeshCount = br.ReadUInt16();
                ret.TerrainShadowMeshIndex = br.ReadUInt16();
                ret.TerrainShadowMeshCount = br.ReadUInt16();
                ret.VerticalFogMeshIndex = br.ReadUInt16();
                ret.VerticalFogMeshCount = br.ReadUInt16();
                ret.EdgeGeometrySize = br.ReadUInt32();
                ret.EdgeGeometryDataOffset = br.ReadUInt32();
                ret.PolygonCount = br.ReadUInt32();
                ret.Unknown1 = br.ReadUInt32();
                ret.VertexBufferSize = br.ReadUInt32();
                ret.IndexBufferSize = br.ReadUInt32();
                ret.VertexDataOffset = br.ReadUInt32();
                ret.IndexDataOffset = br.ReadUInt32();
                return ret;
            }
        }

        public struct ExtraLodStruct
        {
            public ushort LightShaftMeshIndex;
            public ushort LightShaftMeshCount;
            public ushort GlassMeshIndex;
            public ushort GlassMeshCount;
            public ushort MaterialChangeMeshIndex;
            public ushort MaterialChangeMeshCount;
            public ushort CrestChangeMeshIndex;
            public ushort CrestChangeMeshCount;
            public ushort Unknown1;
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

            public static ExtraLodStruct Read( BinaryReader br )
            {
                ExtraLodStruct ret = new ExtraLodStruct();
                ret.LightShaftMeshIndex = br.ReadUInt16();
                ret.LightShaftMeshCount = br.ReadUInt16();
                ret.GlassMeshIndex = br.ReadUInt16();
                ret.GlassMeshCount = br.ReadUInt16();
                ret.MaterialChangeMeshIndex = br.ReadUInt16();
                ret.MaterialChangeMeshCount = br.ReadUInt16();
                ret.CrestChangeMeshIndex = br.ReadUInt16();
                ret.CrestChangeMeshCount = br.ReadUInt16();
                ret.Unknown1 = br.ReadUInt16();
                ret.Unknown2 = br.ReadUInt16();
                ret.Unknown3 = br.ReadUInt16();
                ret.Unknown4 = br.ReadUInt16();
                ret.Unknown5 = br.ReadUInt16();
                ret.Unknown6 = br.ReadUInt16();
                ret.Unknown7 = br.ReadUInt16();
                ret.Unknown8 = br.ReadUInt16();
                ret.Unknown9 = br.ReadUInt16();
                ret.Unknown10 = br.ReadUInt16();
                ret.Unknown11 = br.ReadUInt16();
                ret.Unknown12 = br.ReadUInt16();
                return ret;
            }
        }

        public struct MeshStruct
        {
            public ushort VertexCount;
            private ushort padding;
            public uint IndexCount;
            public ushort MaterialIndex;
            public ushort SubMeshIndex;
            public ushort SubMeshCount;
            public ushort BoneTableIndex;
            public uint StartIndex;
            public uint[] VertexBufferOffset;
            public byte[] VertexBufferStride;

            public byte VertexStreamCount;

            public static MeshStruct Read( BinaryReader br )
            {
                MeshStruct ret = new MeshStruct();
                ret.VertexCount = br.ReadUInt16();
                ret.padding = br.ReadUInt16();
                ret.IndexCount = br.ReadUInt32();
                ret.MaterialIndex = br.ReadUInt16();
                ret.SubMeshIndex = br.ReadUInt16();
                ret.SubMeshCount = br.ReadUInt16();
                ret.BoneTableIndex = br.ReadUInt16();
                ret.StartIndex = br.ReadUInt32();
                ret.VertexBufferOffset = br.ReadStructures< UInt32 >( 3 ).ToArray();
                ret.VertexBufferStride = br.ReadBytes( 3 );
                ret.VertexStreamCount = br.ReadByte();
                return ret;
            }
        }

        public struct SubmeshStruct
        {
            public uint IndexOffset;
            public uint IndexCount;
            public uint AttributeIndexMask;
            public ushort BoneStartIndex;
            public ushort BoneCount;

            public static SubmeshStruct Read( BinaryReader br )
            {
                SubmeshStruct ret = new SubmeshStruct();
                ret.IndexOffset = br.ReadUInt32();
                ret.IndexCount = br.ReadUInt32();
                ret.AttributeIndexMask = br.ReadUInt32();
                ret.BoneStartIndex = br.ReadUInt16();
                ret.BoneCount = br.ReadUInt16();
                return ret;
            }
        }

        public struct TerrainShadowMeshStruct
        {
            public uint IndexCount;
            public uint StartIndex;
            public uint VertexBufferOffset;
            public ushort VertexCount;
            public ushort SubMeshIndex;
            public ushort SubMeshCount;
            public byte VertexBufferStride;
            private byte Padding;

            public static TerrainShadowMeshStruct Read( BinaryReader br )
            {
                TerrainShadowMeshStruct ret = new TerrainShadowMeshStruct();
                ret.IndexCount = br.ReadUInt32();
                ret.StartIndex = br.ReadUInt32();
                ret.VertexBufferOffset = br.ReadUInt32();
                ret.VertexCount = br.ReadUInt16();
                ret.SubMeshIndex = br.ReadUInt16();
                ret.SubMeshCount = br.ReadUInt16();
                ret.VertexBufferStride = br.ReadByte();
                ret.Padding = br.ReadByte();
                return ret;
            }
        }

        public struct TerrainShadowSubmeshStruct
        {
            public uint IndexOffset;
            public uint IndexCount;
            public ushort Unknown1;
            public ushort Unknown2;

            public static TerrainShadowSubmeshStruct Read( BinaryReader br )
            {
                TerrainShadowSubmeshStruct ret = new TerrainShadowSubmeshStruct();
                ret.IndexOffset = br.ReadUInt32();
                ret.IndexCount = br.ReadUInt32();
                ret.Unknown1 = br.ReadUInt16();
                ret.Unknown2 = br.ReadUInt16();
                return ret;
            }
        }

        public struct BoneTableStruct
        {
            public ushort[] BoneIndex;
            public byte BoneCount;
            private byte[] Padding;

            public static BoneTableStruct Read( BinaryReader br )
            {
                BoneTableStruct ret = new BoneTableStruct();
                ret.BoneIndex = br.ReadStructures< UInt16 >( 64 ).ToArray();
                ret.BoneCount = br.ReadByte();
                ret.Padding = br.ReadBytes( 3 );
                return ret;
            }
        }

        public struct ShapeStruct
        {
            public uint StringOffset;
            public ushort[] ShapeMeshStartIndex;
            public ushort[] ShapeMeshCount;

            public static ShapeStruct Read( BinaryReader br )
            {
                ShapeStruct ret = new ShapeStruct();
                ret.StringOffset = br.ReadUInt32();
                ret.ShapeMeshStartIndex = br.ReadStructures< UInt16 >( 3 ).ToArray();
                ret.ShapeMeshCount = br.ReadStructures< UInt16 >( 3 ).ToArray();
                return ret;
            }
        }

        public struct ShapeMeshStruct
        {
            public uint StartIndex;
            public uint ShapeValueCount;
            public uint ShapeValueOffset;

            public static ShapeMeshStruct Read( BinaryReader br )
            {
                ShapeMeshStruct ret = new ShapeMeshStruct();
                ret.StartIndex = br.ReadUInt32();
                ret.ShapeValueCount = br.ReadUInt32();
                ret.ShapeValueOffset = br.ReadUInt32();
                return ret;
            }
        }

        public struct ShapeValueStruct
        {
            public ushort Offset;
            public ushort Value;

            public static ShapeValueStruct Read( BinaryReader br )
            {
                ShapeValueStruct ret = new ShapeValueStruct();
                ret.Offset = br.ReadUInt16();
                ret.Value = br.ReadUInt16();
                return ret;
            }
        }

        public struct BoundingBoxStruct
        {
            public float[] Min;
            public float[] Max;

            public static BoundingBoxStruct Read( BinaryReader br )
            {
                BoundingBoxStruct ret = new BoundingBoxStruct();
                ret.Min = br.ReadStructures< Single >( 4 ).ToArray();
                ret.Max = br.ReadStructures< Single >( 4 ).ToArray();
                return ret;
            }
        }
    }
}