using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Numerics;
using Lumina.Data.Parsing.Mdl;
using Lumina.Extensions;

namespace Lumina.Models.Model {
    public class Mesh {
        
        public enum MeshType
        {
            Main,
            Water,
            Shadow,
            TerrainShadow,
            VerticalFog,
            LightShaft,
            Glass,
            MaterialChange,
            CrestChange
        }
        
        public Model Model { get; private set; }
        public int MeshIndex { get; private set; }
        public MeshType Type { get; private set; }
        
        public string[] Attributes { get; private set; }
        
        // TODO: build submeshes from the index data
        // the information is available to build these, but it'd be nice
        // to have access to Mesh objects with pre-read submesh meshes
        // public Mesh[] SubmeshesAsMesh { get; private set; }

        public Submesh[] Submeshes { get; private set; }
        
        public ushort[] BoneTable { get; private set; }

        public Vertex[] Vertices;
        public ushort[] Indices;

        // todo
        // public Material Material { get; private set; }

        public Mesh( Model model, int index, MeshType type ) {
            Model = model;
            MeshIndex = index;
            Type = type;
            BuildMesh();
        }

        public void BuildMesh() {
            ReadBoneTable();
            ReadIndices();
            ReadVertices();
            ReadSubmeshes();
        }

        private void ReadSubmeshes()
        {
            var currentMesh = Model.File.Meshes[ MeshIndex ];
            Submeshes = new Submesh[ currentMesh.SubMeshCount ];
            for( int i = 0; i < currentMesh.SubMeshCount; i++ )
                Submeshes[i] = new Submesh(Model, MeshIndex, i);
        }
        
        //TODO is this necessary?
        private void ReadBoneTable()
        {
            var currentMesh = Model.File.Meshes[ MeshIndex ];

            // Copy over the bone table
            int boneTableIndex = currentMesh.BoneTableIndex;
            if (boneTableIndex != 255)
                BoneTable = Model.File.BoneTables[ boneTableIndex ].BoneIndex;
        }

        private void ReadIndices()
        {
            var currentMesh = Model.File.Meshes[ MeshIndex ];
            
            // Read indices because they're easy
            BinaryReader reader = new BinaryReader( new MemoryStream( Model.File.IndexBuffers[ (int) Model.Lod ] ) );
            reader.Seek( currentMesh.StartIndex * 2 );
            Indices = reader.ReadStructures< UInt16 >( (int) currentMesh.IndexCount ).ToArray();
        }

        private void ReadVertices()
        {
            MdlStructs.MeshStruct currentMesh = Model.File.Meshes[ MeshIndex ];
            
            // Vertex reading stuff
            MdlStructs.VertexDeclarationStruct currentDecl = Model.File.VertexDeclarations[ MeshIndex ];
            
            // We have to go through these in order by offset with this implementation
            // TODO is this slow? this sort's purpose is to avoid copying every vertex out
            var orderedElements = currentDecl.VertexElements.ToList();
            orderedElements.Sort( ( e1, e2 ) => e1.Offset.CompareTo( e2.Offset ) );
            Vertices = new Vertex[currentMesh.VertexCount];

            // Vertices may be defined across at most 3 streams defined by a Mesh's VertexDeclarations
            var vertexStreamReader = new BinaryReader[3];
            for( int i = 0; i < 3; i++ ) {
                vertexStreamReader[ i ] = new BinaryReader( new MemoryStream( Model.File.VertexBuffers[ (int) Model.Lod ] ) );
                vertexStreamReader[ i ].Seek( currentMesh.VertexBufferOffset[ i ] );
            }

            for( int i = 0; i < Vertices.Length; i++ ) {
                Vertices[i] = new Vertex();

                foreach( var element in orderedElements )
                    SetElementField( ref Vertices[i], element, vertexStreamReader[element.Stream] );
            }
        }
        
        private void SetElementField( ref Vertex v, MdlStructs.VertexElement element, BinaryReader br ) {
            var type = (Vertex.VertexType) element.Type;
            var usage = (Vertex.VertexUsage) element.Usage;

            object data = type switch {
                Vertex.VertexType.Single3    => new Vector3( br.ReadSingle(), br.ReadSingle(), br.ReadSingle() ),
                Vertex.VertexType.Single4    => new Vector4( br.ReadSingle(), br.ReadSingle(), br.ReadSingle(), br.ReadSingle() ),
                Vertex.VertexType.UInt       => br.ReadBytes( 4 ),
                Vertex.VertexType.ByteFloat4 => new Vector4( br.ReadByte() / 255f, br.ReadByte() / 255f, br.ReadByte() / 255f, br.ReadByte() / 255f ),
                Vertex.VertexType.Half2      => new Vector2( br.ReadUInt16().Unpack(), br.ReadUInt16().Unpack() ),
                Vertex.VertexType.Half4      => new Vector4( br.ReadUInt16().Unpack(), br.ReadUInt16().Unpack(),
                                                             br.ReadUInt16().Unpack(), br.ReadUInt16().Unpack() ),
                _ => throw new ArgumentOutOfRangeException()
            };
            
            switch( usage ) {
                case Vertex.VertexUsage.Position:     v.Position =     GetVector4(data); break;
                case Vertex.VertexUsage.BlendWeights: v.BlendWeights = GetVector4(data); break;
                case Vertex.VertexUsage.BlendIndices: v.BlendIndices = (byte[]) data;    break;
                case Vertex.VertexUsage.Normal:       v.Normal =       GetVector3(data); break;
                case Vertex.VertexUsage.UV:           v.UV =           GetVector4(data); break;
                case Vertex.VertexUsage.Tangent2:     v.Tangent2 =     GetVector4(data); break;
                case Vertex.VertexUsage.Tangent1:     v.Tangent1 =     GetVector4(data); break;
                case Vertex.VertexUsage.Color:        v.Color =        GetVector4(data); break;
                default: throw new ArgumentOutOfRangeException();
            }
        }

        private static Vector3 GetVector3( object value ) {
            switch( value ) {
                case Vector2 v2: return new Vector3( v2.X, v2.Y, 0 );
                case Vector3 v3: return v3;
                case Vector4 v4: return new Vector3( v4.X, v4.Y, v4.Z );
            }
            throw new ArgumentOutOfRangeException();
        }

        private static Vector4 GetVector4( object value ) {
            switch( value ) {
                case Vector2 v2: return new Vector4( v2.X, v2.Y, 0, 0 );
                case Vector3 v3: return new Vector4( v3.X, v3.Y, v3.Z, 1 );
                case Vector4 v4: return v4;
            }
            throw new ArgumentOutOfRangeException();
        }
    }
}