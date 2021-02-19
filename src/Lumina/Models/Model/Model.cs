using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using Lumina.Data.Files;
using Lumina.Data.Parsing.Mdl;
using Lumina.Extensions;

namespace Lumina.Models.Model
{
    public class Model
    {
        public enum ModelLod
        {
            High,
            Med,
            Low
        }

        public MdlFile File { get; private set; }
        public ModelLod Lod { get; private set; }
        public Mesh[] Meshes { get; private set; }
        
        public Dictionary<string, Shape> Shapes { get; private set; }

        public Dictionary< int, string > StringOffsetToStringMap { get; private set; }

        public Model( MdlFile mdlFile, ModelLod lod = ModelLod.High )
        {
            if( (uint) lod > mdlFile.FileHeader.LodCount )
                throw new ArgumentException( "The given model does not have the requested LoD.", nameof( lod ) );

            File = mdlFile;
            Lod = lod;
            BuildModel();
        }

        public Model( Lumina lumina, string path, ModelLod lod = ModelLod.High )
        {
            var mdlFile = lumina.GetFile< MdlFile >( path );
            File = mdlFile;
            Lod = lod;
            BuildModel();
        }

        private void BuildModel()
        {
            // Every valid MDL has VertexDeclarations
            if( File.VertexDeclarations == null )
            {
                Console.WriteLine( "BuildModel() called on an empty MdlFile." );
                return;
            }
            
            ReadStrings();
            ReadMeshes();
            ReadShapes();
        }

        private void ReadShapes()
        {
            Shapes = new Dictionary< string, Shape >();
            for( int i = 0; i < File.Shapes.Length; i++ )
            {
                var shape = new Shape( this, i );
                Shapes[ shape.ShapeName ] = shape;
            }
        }

        private void ReadStrings()
        {
            // If we save the offset and the string, we can access it later via the offset without reading
            StringOffsetToStringMap = new Dictionary< int, string >();
            var br = new BinaryReader( new MemoryStream( File.Strings ) );
            for( int i = 0; i < File.StringCount; i++ )
            {
                long startOffset = br.BaseStream.Position;
                string tmp = br.ReadStringData();
                StringOffsetToStringMap[ (int) startOffset ] = tmp;
            }
        }

        private void ReadMeshes()
        {
            // We have to count how many of each mesh there are
            // I think this is a constant order, and this is the correct order
            MdlStructs.LodStruct CurrentLod = File.Lods[ (int) Lod ];

            int totalMeshes = CurrentLod.MeshCount;
            // totalMeshes += CurrentLod.WaterMeshCount;
            // totalMeshes += CurrentLod.ShadowMeshCount;
            // totalMeshes += CurrentLod.TerrainShadowMeshCount;
            // totalMeshes += CurrentLod.VerticalFogMeshCount;
            //
            // if( File.ModelHeader.ExtraLodEnabled )
            // {
            //     MdlStructs.ExtraLodStruct ExtraLod = File.ExtraLods[ (int) Lod ];
            //     totalMeshes += ExtraLod.LightShaftMeshCount;
            //     totalMeshes += ExtraLod.GlassMeshCount;
            //     totalMeshes += ExtraLod.MaterialChangeMeshCount;
            //     totalMeshes += ExtraLod.CrestChangeMeshCount;
            // }

            Meshes = new Mesh[totalMeshes];

            for( int i = 0; i < Meshes.Length; i++ )
            {
                Meshes[ i ] = new Mesh( this, i, GetMeshType( i ) );
            }
        }
        
        private Mesh.MeshType GetMeshType( int index )
        {
            // I could create arrays for the ranges for cleaner code, but all this is doing is checking ranges

            if( index > File.Lods[ (int) Lod ].MeshIndex && index < File.Lods[ (int) Lod ].MeshIndex + File.Lods[ (int) Lod ].MeshCount )
                return Mesh.MeshType.Main;
            if( index > File.Lods[ (int) Lod ].WaterMeshIndex && index < File.Lods[ (int) Lod ].WaterMeshIndex + File.Lods[ (int) Lod ].WaterMeshCount )
                return Mesh.MeshType.Water;
            if( index > File.Lods[ (int) Lod ].ShadowMeshIndex && index < File.Lods[ (int) Lod ].ShadowMeshIndex + File.Lods[ (int) Lod ].ShadowMeshCount )
                return Mesh.MeshType.Shadow;
            if( index > File.Lods[ (int) Lod ].TerrainShadowMeshIndex &&
                index < File.Lods[ (int) Lod ].TerrainShadowMeshIndex + File.Lods[ (int) Lod ].TerrainShadowMeshCount )
                return Mesh.MeshType.TerrainShadow;
            if( index > File.Lods[ (int) Lod ].VerticalFogMeshIndex &&
                index < File.Lods[ (int) Lod ].VerticalFogMeshIndex + File.Lods[ (int) Lod ].VerticalFogMeshCount )
                return Mesh.MeshType.VerticalFog;

            if( File.ModelHeader.ExtraLodEnabled )
            {
                if( index > File.ExtraLods[ (int) Lod ].LightShaftMeshIndex &&
                    index < File.ExtraLods[ (int) Lod ].LightShaftMeshIndex + File.ExtraLods[ (int) Lod ].LightShaftMeshCount )
                    return Mesh.MeshType.LightShaft;
                if( index > File.ExtraLods[ (int) Lod ].GlassMeshIndex &&
                    index < File.ExtraLods[ (int) Lod ].GlassMeshIndex + File.ExtraLods[ (int) Lod ].GlassMeshCount )
                    return Mesh.MeshType.Glass;
                if( index > File.ExtraLods[ (int) Lod ].MaterialChangeMeshIndex &&
                    index < File.ExtraLods[ (int) Lod ].MaterialChangeMeshIndex + File.ExtraLods[ (int) Lod ].MaterialChangeMeshCount )
                    return Mesh.MeshType.MaterialChange;
                if( index > File.ExtraLods[ (int) Lod ].CrestChangeMeshIndex &&
                    index < File.ExtraLods[ (int) Lod ].CrestChangeMeshIndex + File.ExtraLods[ (int) Lod ].CrestChangeMeshCount )
                    return Mesh.MeshType.CrestChange;
            }

            return Mesh.MeshType.Main;
        }

        public Mesh[] GetMeshesByType( Mesh.MeshType mp )
        {
            return Meshes.Where( m => m.Type == mp ).ToArray();
        }

        /// <summary>
        /// Writes an entire Model into a single Wavefront Object file.
        /// This was meant for testing, but doesn't hurt to stay.
        /// </summary>
        /// <returns>A string containing the entire .obj file, including newlines.</returns>
        public string GetObjectFileText()
        {
            string nl = Environment.NewLine;

            var vsList = new List< Vector3 >();
            var vcList = new List< Vector4 >();
            var vtList = new List< Vector4 >();
            var nmList = new List< Vector3 >();
            var inList = new List< Vector3 >();

            int indexModifier = 1;
            for( int i = 0; i < Meshes.Length; i++ )
            {
                if( i != 0 )
                    indexModifier += Meshes[i - 1].Vertices.Length;
                foreach( var vert in Meshes[ i ].Vertices )
                {
                    Vector3 vs = new Vector3();
                    Vector4 vc = new Vector4();
                    Vector4 vt = new Vector4();
                    Vector3 nm = new Vector3();

                    vs.X = vert.Position.Value.X;
                    vs.Y = vert.Position.Value.Y;
                    vs.Z = vert.Position.Value.Z;

                    if( vert.Color == null )
                    {
                        vc.X = 0;
                        vc.Y = 0;
                        vc.W = 0;
                        vc.Z = 0;
                    }
                    else
                    {
                        vc.X = vert.Color.Value.X;
                        vc.Y = vert.Color.Value.Y;
                        vc.W = vert.Color.Value.W;
                        vc.Z = vert.Color.Value.Z;
                    }

                    if( vert.UV.HasValue )
                    {
                        vt.X = vert.UV.Value.X;
                        vt.Y = -1 * vert.UV.Value.Y;
                        vt.W = ( vert.UV.Value.W == 0 ) ? vt.X : vert.UV.Value.W;
                        vt.Z = ( vert.UV.Value.Z == 0 ) ? vt.Y : vert.UV.Value.Z;
                    }

                    if( vert.Normal.HasValue )
                    {
                        nm.X = vert.Normal.Value.X;
                        nm.Y = vert.Normal.Value.Y;
                        nm.Z = vert.Normal.Value.Z;
                    }

                    vsList.Add( vs );
                    vcList.Add( vc );
                    vtList.Add( vt );
                    nmList.Add( nm );
                }

                for( int j = 0; j < Meshes[ i ].Indices.Length; j += 3 )
                {
                    Vector3 ind = new Vector3
                    {
                        X = Meshes[ i ].Indices[ j + 0 ] + indexModifier,
                        Y = Meshes[ i ].Indices[ j + 1 ] + indexModifier,
                        Z = Meshes[ i ].Indices[ j + 2 ] + indexModifier
                    };
                    inList.Add( ind );
                }
            }

            var sb = new StringBuilder();
            foreach( var vert in vsList )
                sb.Append( $"v {(decimal) vert.X} {(decimal) vert.Y} {(decimal) vert.Z}{nl}" );

            foreach( var color in vcList )
                sb.Append( $"vc {(decimal) color.W} {(decimal) color.X} {(decimal) color.Y} {(decimal) color.Z}{nl}" );

            foreach( var texCoord in vtList )
                sb.Append( $"vt {(decimal) texCoord.X} {(decimal) texCoord.Y} {(decimal) texCoord.W} {(decimal) texCoord.Z}{nl}" );

            foreach( var norm in nmList )
                sb.Append( $"vn {(decimal) norm.X} {(decimal) norm.Y} {(decimal) norm.Z}{nl}" );

            foreach( var ind in inList )
            {
                sb.Append( String.Format( "f {0}/{0}/{0} {1}/{1}/{1} {2}/{2}/{2}{3}",
                    (ushort) ind.X,
                    (ushort) ind.Y,
                    (ushort) ind.Z,
                    nl ) );
            }
            return sb.ToString();
        }
    }
}