using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using Lumina.Extensions;

// ReSharper disable InconsistentNaming
// ReSharper disable UnassignedField.Global
#pragma warning disable 649
#pragma warning disable 169

namespace Lumina.Data.Parsing
{
    public static class MdlStructs
    {
        [Flags]
        public enum ModelFlags1 : byte
        {
            DustOcclusionEnabled = 0x80,
            SnowOcclusionEnabled = 0x40,
            RainOcclusionEnabled = 0x20,
            Unknown1 = 0x10,
            LightingReflectionEnabled = 0x08,
            WavingAnimationDisabled = 0x04,
            LightShadowDisabled = 0x02,
            ShadowDisabled = 0x01,
        }

        [Flags]
        public enum ModelFlags2 : byte
        {
            Unknown2 = 0x80,
            BgUvScrollEnabled = 0x40,
            EnableForceNonResident = 0x20,
            ExtraLodEnabled = 0x10,
            ShadowMaskEnabled = 0x08,
            ForceLodRangeEnabled = 0x04,
            EdgeGeometryEnabled = 0x02,
            Unknown3 = 0x01
        }

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

            public static ModelFileHeader Read( LuminaBinaryReader br )
            {
                ModelFileHeader ret = new ModelFileHeader();
                ret.Version = br.ReadUInt32();
                ret.StackSize = br.ReadUInt32();
                ret.RuntimeSize = br.ReadUInt32();
                ret.VertexDeclarationCount = br.ReadUInt16();
                ret.MaterialCount = br.ReadUInt16();
                ret.VertexOffset = br.ReadUInt32s( 3 );
                ret.IndexOffset = br.ReadUInt32s( 3 );
                ret.VertexBufferSize = br.ReadUInt32s( 3 );
                ret.IndexBufferSize = br.ReadUInt32s( 3 );
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

            public static VertexDeclarationStruct Read( LuminaBinaryReader br )
            {
                VertexDeclarationStruct ret = new VertexDeclarationStruct();

                var elems = new List< VertexElement >();

                // Read the vertex elements that we need
                var thisElem = br.ReadStructure< VertexElement >();
                do
                {
                    elems.Add( thisElem );
                    thisElem = br.ReadStructure< VertexElement >();
                } while( thisElem.Stream != 255 );

                // Skip the number of bytes that we don't need to read
                // We skip elems.Count * 9 because we had to read the invalid element
                int toSeek = 17 * 8 - ( elems.Count + 1 ) * 8;
                br.Seek( br.BaseStream.Position + toSeek );

                ret.VertexElements = elems.ToArray();

                return ret;
            }
        }

        public unsafe struct VertexElement
        {
            public byte Stream;
            public byte Offset;
            public byte Type;
            public byte Usage;
            public byte UsageIndex; // D3D9 remnant?
            private fixed byte Padding[3];
        }

        public unsafe struct ModelHeader : IConvertEndianness
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

            private ModelFlags1 Flags1;

            public bool DustOcclusionEnabled => Flags1.HasFlag( ModelFlags1.DustOcclusionEnabled );
            public bool SnowOcclusionEnabled => Flags1.HasFlag( ModelFlags1.SnowOcclusionEnabled );
            public bool RainOcclusionEnabled => Flags1.HasFlag( ModelFlags1.RainOcclusionEnabled );
            public bool Unknown1 => Flags1.HasFlag( ModelFlags1.Unknown1 );
            public bool BgLightingReflectionEnabled => Flags1.HasFlag( ModelFlags1.LightingReflectionEnabled );
            public bool WavingAnimationDisabled => Flags1.HasFlag( ModelFlags1.WavingAnimationDisabled );
            public bool LightShadowDisabled => Flags1.HasFlag( ModelFlags1.LightShadowDisabled );
            public bool ShadowDisabled => Flags1.HasFlag( ModelFlags1.ShadowDisabled );

            public ushort ElementIdCount;
            public byte TerrainShadowMeshCount;

            private ModelFlags2 Flags2;

            public bool Unknown2 => Flags2.HasFlag( ModelFlags2.Unknown2 );
            public bool BgUvScrollEnabled => Flags2.HasFlag( ModelFlags2.BgUvScrollEnabled );
            public bool EnableForceNonResident => Flags2.HasFlag( ModelFlags2.EnableForceNonResident );
            public bool ExtraLodEnabled => Flags2.HasFlag( ModelFlags2.ExtraLodEnabled );
            public bool ShadowMaskEnabled => Flags2.HasFlag( ModelFlags2.ShadowMaskEnabled );
            public bool ForceLodRangeEnabled => Flags2.HasFlag( ModelFlags2.ForceLodRangeEnabled );
            public bool EdgeGeometryEnabled => Flags2.HasFlag( ModelFlags2.EdgeGeometryEnabled );
            public bool Unknown3 => Flags2.HasFlag( ModelFlags2.Unknown3 );

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
            private fixed byte Padding[6];

            public void ConvertEndianness()
            {
                Radius = LuminaBinaryReader.ReverseEndianness( Radius );
                MeshCount = BinaryPrimitives.ReverseEndianness( MeshCount );
                AttributeCount = BinaryPrimitives.ReverseEndianness( AttributeCount );
                SubmeshCount = BinaryPrimitives.ReverseEndianness( SubmeshCount );
                MaterialCount = BinaryPrimitives.ReverseEndianness( MaterialCount );
                BoneCount = BinaryPrimitives.ReverseEndianness( BoneCount );
                BoneTableCount = BinaryPrimitives.ReverseEndianness( BoneTableCount );
                ShapeCount = BinaryPrimitives.ReverseEndianness( ShapeCount );
                ShapeMeshCount = BinaryPrimitives.ReverseEndianness( ShapeMeshCount );
                ShapeValueCount = BinaryPrimitives.ReverseEndianness( ShapeValueCount );
                ElementIdCount = BinaryPrimitives.ReverseEndianness( ElementIdCount );
                ModelClipOutDistance = LuminaBinaryReader.ReverseEndianness( ModelClipOutDistance );
                ShadowClipOutDistance = LuminaBinaryReader.ReverseEndianness( ShadowClipOutDistance );
                Unknown4 = BinaryPrimitives.ReverseEndianness( Unknown4 );
                TerrainShadowMeshCount = BinaryPrimitives.ReverseEndianness( TerrainShadowMeshCount );
                Unknown7 = BinaryPrimitives.ReverseEndianness( Unknown7 );
                Unknown8 = BinaryPrimitives.ReverseEndianness( Unknown8 );
                Unknown9 = BinaryPrimitives.ReverseEndianness( Unknown9 );
            }
        }

        public struct ElementIdStruct
        {
            public uint ElementId;
            public uint ParentBoneName;
            public float[] Translate;
            public float[] Rotate;

            public static ElementIdStruct Read( LuminaBinaryReader br )
            {
                ElementIdStruct ret = new ElementIdStruct();
                ret.ElementId = br.ReadUInt32();
                ret.ParentBoneName = br.ReadUInt32();
                ret.Translate = br.ReadStructures< Single >( 3 ).ToArray();
                ret.Rotate = br.ReadStructures< Single >( 3 ).ToArray();
                return ret;
            }
        }

        public struct LodStruct : IConvertEndianness
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

            public void ConvertEndianness()
            {
                MeshIndex = BinaryPrimitives.ReverseEndianness( MeshIndex );
                MeshCount = BinaryPrimitives.ReverseEndianness( MeshCount );
                ModelLodRange = LuminaBinaryReader.ReverseEndianness( ModelLodRange );
                TextureLodRange = LuminaBinaryReader.ReverseEndianness( TextureLodRange );
                WaterMeshIndex = BinaryPrimitives.ReverseEndianness( WaterMeshIndex );
                WaterMeshCount = BinaryPrimitives.ReverseEndianness( WaterMeshCount );
                ShadowMeshIndex = BinaryPrimitives.ReverseEndianness( ShadowMeshIndex );
                ShadowMeshCount = BinaryPrimitives.ReverseEndianness( ShadowMeshCount );
                TerrainShadowMeshIndex = BinaryPrimitives.ReverseEndianness( TerrainShadowMeshIndex );
                TerrainShadowMeshCount = BinaryPrimitives.ReverseEndianness( TerrainShadowMeshCount );
                VerticalFogMeshIndex = BinaryPrimitives.ReverseEndianness( VerticalFogMeshIndex );
                VerticalFogMeshCount = BinaryPrimitives.ReverseEndianness( VerticalFogMeshCount );
                EdgeGeometrySize = BinaryPrimitives.ReverseEndianness( EdgeGeometrySize );
                EdgeGeometryDataOffset = BinaryPrimitives.ReverseEndianness( EdgeGeometryDataOffset );
                PolygonCount = BinaryPrimitives.ReverseEndianness( PolygonCount );
                Unknown1 = BinaryPrimitives.ReverseEndianness( Unknown1 );
                VertexBufferSize = BinaryPrimitives.ReverseEndianness( VertexBufferSize );
                IndexBufferSize = BinaryPrimitives.ReverseEndianness( IndexBufferSize );
                VertexDataOffset = BinaryPrimitives.ReverseEndianness( VertexDataOffset );
                IndexDataOffset = BinaryPrimitives.ReverseEndianness( IndexDataOffset );
            }
        }

        public struct ExtraLodStruct : IConvertEndianness
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

            public void ConvertEndianness()
            {
                LightShaftMeshIndex = BinaryPrimitives.ReverseEndianness( LightShaftMeshIndex );
                LightShaftMeshCount = BinaryPrimitives.ReverseEndianness( LightShaftMeshCount );
                GlassMeshIndex = BinaryPrimitives.ReverseEndianness( GlassMeshIndex );
                GlassMeshCount = BinaryPrimitives.ReverseEndianness( GlassMeshCount );
                MaterialChangeMeshIndex = BinaryPrimitives.ReverseEndianness( MaterialChangeMeshIndex );
                MaterialChangeMeshCount = BinaryPrimitives.ReverseEndianness( MaterialChangeMeshCount );
                CrestChangeMeshIndex = BinaryPrimitives.ReverseEndianness( CrestChangeMeshIndex );
                CrestChangeMeshCount = BinaryPrimitives.ReverseEndianness( CrestChangeMeshCount );
                Unknown1 = BinaryPrimitives.ReverseEndianness( Unknown1 );
                Unknown2 = BinaryPrimitives.ReverseEndianness( Unknown2 );
                Unknown3 = BinaryPrimitives.ReverseEndianness( Unknown3 );
                Unknown4 = BinaryPrimitives.ReverseEndianness( Unknown4 );
                Unknown5 = BinaryPrimitives.ReverseEndianness( Unknown5 );
                Unknown6 = BinaryPrimitives.ReverseEndianness( Unknown6 );
                Unknown7 = BinaryPrimitives.ReverseEndianness( Unknown7 );
                Unknown8 = BinaryPrimitives.ReverseEndianness( Unknown8 );
                Unknown9 = BinaryPrimitives.ReverseEndianness( Unknown9 );
                Unknown10 = BinaryPrimitives.ReverseEndianness( Unknown10 );
                Unknown11 = BinaryPrimitives.ReverseEndianness( Unknown11 );
                Unknown12 = BinaryPrimitives.ReverseEndianness( Unknown12 );
            }
        }

        public struct MeshStruct
        {
            public ushort VertexCount;
            private ushort Padding;
            public uint IndexCount;
            public ushort MaterialIndex;
            public ushort SubMeshIndex;
            public ushort SubMeshCount;
            public ushort BoneTableIndex;
            public uint StartIndex;
            public uint[] VertexBufferOffset;
            public byte[] VertexBufferStride;

            public byte VertexStreamCount;

            public static MeshStruct Read( LuminaBinaryReader br )
            {
                MeshStruct ret = new MeshStruct();
                ret.VertexCount = br.ReadUInt16();
                ret.Padding = br.ReadUInt16();
                ret.IndexCount = br.ReadUInt32();
                ret.MaterialIndex = br.ReadUInt16();
                ret.SubMeshIndex = br.ReadUInt16();
                ret.SubMeshCount = br.ReadUInt16();
                ret.BoneTableIndex = br.ReadUInt16();
                ret.StartIndex = br.ReadUInt32();
                ret.VertexBufferOffset = br.ReadUInt32s( 3 );
                ret.VertexBufferStride = br.ReadBytes( 3 );
                ret.VertexStreamCount = br.ReadByte();
                return ret;
            }
        }

        public struct SubmeshStruct : IConvertEndianness
        {
            public uint IndexOffset;
            public uint IndexCount;
            public uint AttributeIndexMask;
            public ushort BoneStartIndex;
            public ushort BoneCount;

            public void ConvertEndianness()
            {
                IndexOffset = BinaryPrimitives.ReverseEndianness( IndexOffset );
                IndexCount = BinaryPrimitives.ReverseEndianness( IndexCount );
                AttributeIndexMask = BinaryPrimitives.ReverseEndianness( AttributeIndexMask );
                BoneStartIndex = BinaryPrimitives.ReverseEndianness( BoneStartIndex );
                BoneCount = BinaryPrimitives.ReverseEndianness( BoneCount );
            }
        }

        public struct TerrainShadowMeshStruct : IConvertEndianness
        {
            public uint IndexCount;
            public uint StartIndex;
            public uint VertexBufferOffset;
            public ushort VertexCount;
            public ushort SubMeshIndex;
            public ushort SubMeshCount;
            public byte VertexBufferStride;
            private byte Padding;

            public void ConvertEndianness()
            {
                IndexCount = BinaryPrimitives.ReverseEndianness( IndexCount );
                StartIndex = BinaryPrimitives.ReverseEndianness( StartIndex );
                VertexBufferOffset = BinaryPrimitives.ReverseEndianness( VertexBufferOffset );
                VertexCount = BinaryPrimitives.ReverseEndianness( VertexCount );
                SubMeshIndex = BinaryPrimitives.ReverseEndianness( SubMeshIndex );
                SubMeshCount = BinaryPrimitives.ReverseEndianness( SubMeshCount );
            }
        }

        public struct TerrainShadowSubmeshStruct : IConvertEndianness
        {
            public uint IndexOffset;
            public uint IndexCount;
            public ushort Unknown1;
            public ushort Unknown2;

            public void ConvertEndianness()
            {
                IndexOffset = BinaryPrimitives.ReverseEndianness( IndexOffset );
                IndexCount = BinaryPrimitives.ReverseEndianness( IndexCount );
                Unknown1 = BinaryPrimitives.ReverseEndianness( Unknown1 );
                Unknown2 = BinaryPrimitives.ReverseEndianness( Unknown2 );
            }
        }

        public struct BoneTableStruct
        {
            public ushort[] BoneIndex;
            public byte BoneCount;
            private byte[] Padding;

            public static BoneTableStruct Read( LuminaBinaryReader br )
            {
                BoneTableStruct ret = new BoneTableStruct();
                ret.BoneIndex = br.ReadUInt16s( 64 );
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

            public static ShapeStruct Read( LuminaBinaryReader br )
            {
                ShapeStruct ret = new ShapeStruct();
                ret.StringOffset = br.ReadUInt32();
                ret.ShapeMeshStartIndex = br.ReadUInt16s( 3 );
                ret.ShapeMeshCount = br.ReadUInt16s( 3 );
                return ret;
            }
        }

        public struct ShapeMeshStruct : IConvertEndianness
        {
            public uint StartIndex;
            public uint ShapeValueCount;
            public uint ShapeValueOffset;

            public void ConvertEndianness()
            {
                StartIndex = BinaryPrimitives.ReverseEndianness( StartIndex );
                ShapeValueCount = BinaryPrimitives.ReverseEndianness( ShapeValueCount );
                ShapeValueOffset = BinaryPrimitives.ReverseEndianness( ShapeValueOffset );
            }
        }

        public struct ShapeValueStruct : IConvertEndianness
        {
            public ushort Offset;
            public ushort Value;

            public void ConvertEndianness()
            {
                Offset = BinaryPrimitives.ReverseEndianness( Offset );
                Value = BinaryPrimitives.ReverseEndianness( Value );
            }
        }

        public struct BoundingBoxStruct
        {
            public float[] Min;
            public float[] Max;

            public static BoundingBoxStruct Read( LuminaBinaryReader br )
            {
                BoundingBoxStruct ret = new BoundingBoxStruct();
                ret.Min = br.ReadSingles( 4 );
                ret.Max = br.ReadSingles( 4 );
                return ret;
            }
        }
    }
}