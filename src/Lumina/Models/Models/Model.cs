using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Lumina.Data.Files;
using Lumina.Data.Parsing;
using Lumina.Extensions;
using Lumina.Models.Materials;

namespace Lumina.Models.Models
{
    public class Model
    {
        /// <summary>
        /// Model levels of details start at 0 for high, and
        /// go up to indicate lowering levels of detail.
        /// This means that models with only one level of detail will
        /// only have a "high quality" model. 
        /// </summary>
        public enum ModelLod
        {
            High,
            Med,
            Low
        }

        public MdlFile? File { get; private set; }
        public ModelLod Lod { get; private set; }
        public Mesh[] Meshes { get; private set; }
        public Material[] Materials { get; private set; }
        public Dictionary< string, Shape > Shapes { get; private set; }
        public Dictionary< int, string > StringOffsetToStringMap { get; private set; }
        public int VariantId { get; private set; }

        /// <summary>
        /// Creates a new Model instance using the provided MdlFile, level of detail,
        /// and variant ID, without resolving any game data.
        /// </summary>
        /// <param name="mdlFile">The MdlFile to back this Model.</param>
        /// <param name="lod">The quality of the loaded Model.</param>
        /// <param name="variantId">The variant ID of the Model to load. This will be used
        /// to specify a Material variant, and may be used by the caller to limit attributes
        /// depending on data from an ImcFile.</param>
        /// <exception cref="ArgumentException">The specified MdlFile does not contain
        /// the specified ModelLod.</exception>
        public Model( MdlFile mdlFile, ModelLod lod = ModelLod.High, int variantId = 1 )
        {
            if( (uint)lod > mdlFile.FileHeader.LodCount )
                throw new ArgumentException( "The given model does not have the requested LoD.", nameof( lod ) );

            File = mdlFile;
            Lod = lod;
            VariantId = variantId;
            BuildModel();
        }

        /// <summary>
        /// Creates a new Model instance using the provided path, access to game data,
        /// level of detail, and variant ID. The Model will be built and then updated
        /// with game data.
        /// </summary>
        /// <param name="data">A reference to game data access.</param>
        /// <param name="path">The path to this Model.</param>
        /// <param name="lod">The quality of the loaded Model.</param>
        /// <param name="variantId">The variant ID of the Model to load. This will be used
        /// to specify a Material variant, and may be used by the caller to limit attributes
        /// depending on data from an ImcFile.</param>
        /// <exception cref="ArgumentException">The specified MdlFile does not contain
        /// the specified ModelLod.</exception>
        public Model( GameData data, string path, ModelLod lod = ModelLod.High, int variantId = 1 )
        {
            var mdlFile = data.GetFile< MdlFile >( path );

            if( (uint)lod > mdlFile?.FileHeader.LodCount )
                throw new ArgumentException( "The given model does not have the requested LoD.", nameof( lod ) );

            File = mdlFile;
            Lod = lod;
            VariantId = variantId;
            BuildModel();
            Update( data );
        }

        private void BuildModel()
        {
            // Every valid MDL has VertexDeclarations
            if( File?.VertexDeclarations == null )
            {
                Console.WriteLine( "BuildModel() called on an empty MdlFile." );
                return;
            }

            ReadStrings();
            ReadMaterials();
            ReadMeshes();
            ReadShapes();
        }

        /// <summary>
        /// Update this Model using game data. The Model's references
        /// to Materials will be resolved and the Material files fully
        /// loaded to be used to resolve textures and other information.
        /// </summary>
        /// <param name="data">A reference to game data access.</param>
        /// <returns>The existing Model instance, for method chaining.</returns>
        public Model Update( GameData data )
        {
            foreach( var mat in Materials )
                mat.Update( data );
            return this;
        }

        private void ReadMaterials()
        {
            if( File == null )
            {
                return;
            }

            Materials = new Material[File.FileHeader.MaterialCount];

            for( int i = 0; i < File.FileHeader.MaterialCount; i++ )
            {
                var pathOffset = File.MaterialNameOffsets[ i ];
                var path = StringOffsetToStringMap[ (int)pathOffset ];
                Materials[ i ] = new Material( this, path, VariantId );
            }
        }

        private void ReadShapes()
        {
            Shapes = new Dictionary< string, Shape >();
            for( int i = 0; i < File?.Shapes.Length; i++ )
            {
                // We will need more info in the constructor here... eventually
                var shape = new Shape( this, i );
                Shapes[ shape.ShapeName ] = shape;
            }
        }

        private void ReadStrings()
        {
            StringOffsetToStringMap = new Dictionary< int, string >();
            var mr = new MemoryStream( File.Strings );
            var br = new BinaryReader( mr );
            for( int i = 0; i < File.StringCount; i++ )
            {
                long startOffset = br.BaseStream.Position;
                string tmp = br.ReadStringData();
                StringOffsetToStringMap[ (int)startOffset ] = tmp;
            }

            br.Dispose();
            mr.Dispose();
        }

        private void ReadMeshes()
        {
            // My brain is fried
            var ranges = new List< (int s, int e ) >();

            MdlStructs.LodStruct currentLod = File.Lods[ (int)Lod ];
            ranges.Add( ( currentLod.MeshIndex, currentLod.MeshIndex + currentLod.MeshCount ) );
            ranges.Add( ( currentLod.WaterMeshIndex, currentLod.WaterMeshIndex + currentLod.WaterMeshCount ) );
            ranges.Add( ( currentLod.ShadowMeshIndex, currentLod.ShadowMeshIndex + currentLod.ShadowMeshCount ) );
            ranges.Add( ( currentLod.TerrainShadowMeshIndex, currentLod.TerrainShadowMeshIndex + currentLod.TerrainShadowMeshCount ) );
            ranges.Add( ( currentLod.VerticalFogMeshIndex, currentLod.VerticalFogMeshIndex + currentLod.VerticalFogMeshCount ) );

            if( File.ModelHeader.ExtraLodEnabled )
            {
                MdlStructs.ExtraLodStruct extraLod = File.ExtraLods[ (int)Lod ];
                ranges.Add( ( extraLod.LightShaftMeshIndex, extraLod.LightShaftMeshIndex + extraLod.LightShaftMeshCount ) );
                ranges.Add( ( extraLod.GlassMeshIndex, extraLod.GlassMeshIndex + extraLod.GlassMeshCount ) );
                ranges.Add( ( extraLod.MaterialChangeMeshIndex, extraLod.MaterialChangeMeshIndex + extraLod.MaterialChangeMeshCount ) );
                ranges.Add( ( extraLod.CrestChangeMeshIndex, extraLod.CrestChangeMeshIndex + extraLod.CrestChangeMeshCount ) );
            }

            int totalMeshes = 0;
            bool atIndex = true;
            while( atIndex )
            {
                atIndex = false;
                foreach( var range in ranges )
                {
                    if( range.s <= totalMeshes && totalMeshes < range.e )
                    {
                        atIndex = true;
                        totalMeshes++;
                        break;
                    }
                }
            }

            Meshes = new Mesh[totalMeshes];

            for( int i = 0; i < Meshes.Length; i++ )
            {
                Meshes[ i ] = new Mesh( this, i, GetMeshTypes( i ) );
            }
        }

        private Mesh.MeshType[] GetMeshTypes( int index )
        {
            // I could create arrays for the ranges for cleaner code, but all this is doing is checking ranges
            var types = new List< Mesh.MeshType >();
            if( index >= File.Lods[ (int)Lod ].MeshIndex &&
                index < File.Lods[ (int)Lod ].MeshIndex + File.Lods[ (int)Lod ].MeshCount &&
                File.Lods[ (int)Lod ].MeshCount > 0 )
                types.Add( Mesh.MeshType.Main );
            if( index >= File.Lods[ (int)Lod ].WaterMeshIndex &&
                index < File.Lods[ (int)Lod ].WaterMeshIndex + File.Lods[ (int)Lod ].WaterMeshCount &&
                File.Lods[ (int)Lod ].WaterMeshCount > 0 )
                types.Add( Mesh.MeshType.Water );
            if( index >= File.Lods[ (int)Lod ].ShadowMeshIndex &&
                index < File.Lods[ (int)Lod ].ShadowMeshIndex + File.Lods[ (int)Lod ].ShadowMeshCount &&
                File.Lods[ (int)Lod ].ShadowMeshCount > 0 )
                types.Add( Mesh.MeshType.Shadow );
            if( index >= File.Lods[ (int)Lod ].TerrainShadowMeshIndex &&
                index < File.Lods[ (int)Lod ].TerrainShadowMeshIndex + File.Lods[ (int)Lod ].TerrainShadowMeshCount &&
                File.Lods[ (int)Lod ].TerrainShadowMeshCount > 0 )
                types.Add( Mesh.MeshType.TerrainShadow );
            if( index >= File.Lods[ (int)Lod ].VerticalFogMeshIndex &&
                index < File.Lods[ (int)Lod ].VerticalFogMeshIndex + File.Lods[ (int)Lod ].VerticalFogMeshCount &&
                File.Lods[ (int)Lod ].VerticalFogMeshCount > 0 )
                types.Add( Mesh.MeshType.VerticalFog );

            if( !File.ModelHeader.ExtraLodEnabled ) return types.ToArray();

            if( index >= File.ExtraLods[ (int)Lod ].LightShaftMeshIndex &&
                index < File.ExtraLods[ (int)Lod ].LightShaftMeshIndex + File.ExtraLods[ (int)Lod ].LightShaftMeshCount &&
                File.ExtraLods[ (int)Lod ].LightShaftMeshCount > 0 )
                types.Add( Mesh.MeshType.LightShaft );
            if( index >= File.ExtraLods[ (int)Lod ].GlassMeshIndex &&
                index < File.ExtraLods[ (int)Lod ].GlassMeshIndex + File.ExtraLods[ (int)Lod ].GlassMeshCount &&
                File.ExtraLods[ (int)Lod ].GlassMeshCount > 0 )
                types.Add( Mesh.MeshType.Glass );
            if( index >= File.ExtraLods[ (int)Lod ].MaterialChangeMeshIndex &&
                index < File.ExtraLods[ (int)Lod ].MaterialChangeMeshIndex + File.ExtraLods[ (int)Lod ].MaterialChangeMeshCount &&
                File.ExtraLods[ (int)Lod ].MaterialChangeMeshCount > 0 )
                types.Add( Mesh.MeshType.MaterialChange );
            if( index >= File.ExtraLods[ (int)Lod ].CrestChangeMeshIndex &&
                index < File.ExtraLods[ (int)Lod ].CrestChangeMeshIndex + File.ExtraLods[ (int)Lod ].CrestChangeMeshCount &&
                File.ExtraLods[ (int)Lod ].CrestChangeMeshCount > 0 )
                types.Add( Mesh.MeshType.CrestChange );


            return types.ToArray();
        }

        public Mesh[] GetMeshesByType( Mesh.MeshType mp )
        {
            return Meshes.Where( m => m.Types.Contains( mp ) ).ToArray();
        }
    }
}