using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Lumina.Data.Files;
using Lumina.Data.Parsing;
using Lumina.Extensions;
using Lumina.Models.Models;

namespace Lumina.Models.Materials
{
    public class Material
    {
        /// <summary>
        /// The path to this Material. May be relative or absolute.
        /// </summary>
        public string MaterialPath { get; private set; }
        
        /// <summary>
        /// The resolved path to this Material. Guaranteed to not be initialized
        /// in the case that <c>MaterialPath.StartsWith("/") == true</c>.
        /// </summary>
        public string ResolvedPath { get; private set; }
        
        /// <summary>
        /// A convenience reference to the Model that instantiated this Material.
        /// </summary>
        public Model Parent { get; private set; }
        
        /// <summary>
        /// The MtrlFile backing this Material. May not be initialized.
        /// </summary>
        public MtrlFile File { get; private set; }
        
        /// <summary>
        /// The Textures for this Material. May not be initialized.
        /// </summary>
        public Texture[] Textures { get; private set; }
        
        /// <summary>
        /// The shader package name used by this Material.
        /// </summary>
        public string ShaderPack { get; private set; }
        
        /// <summary>
        /// The variant ID for this Material. This is specified by the caller
        /// for relative paths and inferred for absolute paths or instantiation
        /// via the MtrlFile constructor.
        /// </summary>
        public int VariantId { get; set; }

        private Dictionary< int, string > StringOffsetToStringMap;

        /// <summary>
        /// Creates a new Material instance without resolving any game data.
        /// </summary>
        /// <param name="path">The path, relative or absolute, to this Material.</param>
        /// <param name="variantId">The variant ID for this material. This parameter is
        /// ignored if an absolute path is provided; the variant ID will be inferred.</param>
        public Material( string path, int variantId = 1 )
        {
            MaterialPath = path;
            VariantId = !path.StartsWith( "/" ) ? GetVariantIdFromPath( path ) : variantId;
        }

        /// <summary>
        /// Creates a new Material instance without resolving any data.
        /// This constructor is used by the <see cref="Model"/> class to
        /// provide a reference to the model within the material.
        /// </summary>
        /// <param name="parent">The Model this Material has been instantiated for.</param>
        /// <param name="path">The path, relative or absolute, to this Material.</param>
        /// <param name="variantId">The variant ID for this material. Default is 1.</param>
        public Material( Model parent, string path, int variantId = 1 )
        {
            Parent = parent;
            MaterialPath = path;
            VariantId = variantId;
        }

        /// <summary>
        /// Creates a new Material instance using the provided MtrlFile.
        /// Variant ID is inferred from the provided MtrlFile's path.
        /// </summary>
        /// <param name="file">The MtrlFile to back this Material.</param>
        public Material( MtrlFile file )
        {
            File = file;
            VariantId = GetVariantIdFromPath( file.FilePath );
            BuildMaterial();
        }

        /// <summary>
        /// Creates a new Material instance using the provided path and
        /// reference to game data. The Material will be built and then
        /// updated with game data.
        /// </summary>
        /// <param name="data">A reference to game data access.</param>
        /// <param name="path">The path, relative or absolute, to this Material.</param>
        /// <param name="variantId">The variant ID for this material. Default is 1.</param>
        public Material( GameData data, string path, int variantId = 1 )
        {
            MaterialPath = path;
            BuildMaterial();
            Update( data );
        }

        /// <summary>
        /// Update this Material using game data. If instantiated without a MtrlFile or
        /// GameData, this method will retrieve the MtrlFile referenced by this Material and use
        /// that file to update local fields. This method is not guaranteed to load the MtrlFile.
        /// </summary>
        /// <param name="data">A reference to game data access.</param>
        /// <returns>The existing Material instance, for method chaining.</returns>
        public Material Update( GameData data )
        {
            if( MaterialPath.StartsWith( "/" ) )
            {
                ResolvedPath = ResolveRelativeMaterialPath( MaterialPath, VariantId );
                File = data.GetFile< MtrlFile >( ResolvedPath );
            }
            else
            {
                File = data.GetFile< MtrlFile >( MaterialPath );
            }

            if( File != null )
                BuildMaterial();

            return this;
        }

        /// <summary>
        /// Resolves a relative material path in the form <c>/mt_c0101e0001_top_a.mtrl</c>
        /// into its full path, <c>chara/equipment/e0001/material/v{variantId}/mt_c0101e0001_top_a.mtrl</c>.
        /// <br/>This method will successfully resolve all known relative material paths.
        /// </summary>
        /// <param name="relativePath">The relative path of the provided material.</param>
        /// <param name="variantId">The variant to use in material resolution.</param>
        /// <returns>The resolved, absolute path to the requested material, or null if unsuccessful.</returns>
        public static string ResolveRelativeMaterialPath( string relativePath, int variantId )
        {
            var id1 = relativePath[4];
            var val1 = relativePath.Substring( 5, 4 );
            var id2 = relativePath[9];
            var val2 = relativePath.Substring( 10, 4 );

            return ( id1, id2 ) switch
            {
                ('c', 'a') => $"chara/accessory/a{val2}/material/v{variantId:D4}{relativePath}",
                ('c', 'b') => $"chara/human/c{val1}/obj/body/b{val2}/material/v{variantId:D4}{relativePath}",
                ('c', 'e') => $"chara/equipment/e{val2}/material/v{variantId:D4}{relativePath}",
                ('c', 'f') => $"chara/human/c{val1}/obj/face/f{val2}/material{relativePath}",
                ('c', 'h') => $"chara/human/c{val1}/obj/hair/h{val2}/material/v{variantId:D4}{relativePath}",
                ('c', 't') => $"chara/human/c{val1}/obj/tail/t{val2}/material/v{variantId:D4}{relativePath}",
                ('c', 'z') => $"chara/human/c{val1}/obj/zear/z{val2}/material{relativePath}",
                ('d', 'e') => $"chara/demihuman/d{val1}/obj/equipment/e{val2}/material/v{variantId:D4}{relativePath}",
                ('m', 'b') => $"chara/monster/m{val1}/obj/body/b{val2}/material/v{variantId:D4}{relativePath}",
                ('w', 'b') => $"chara/weapon/w{val1}/obj/body/b{val2}/material/v{variantId:D4}{relativePath}",
                (_, _) => null
            };
        }
        
        /// <summary>
        /// Parse the variant ID out of an existing absolute path to a .mtrl file.
        /// </summary>
        /// <param name="matPath">The absolute path to an existing .mtrl file.</param>
        /// <returns>The variant ID for the given .mtrl path. In case of error, 1.</returns>
        public static int GetVariantIdFromPath(string matPath) {
            var v = 1;
            var vStart = matPath.IndexOf("/v", StringComparison.Ordinal );
            if( vStart == -1 )
                return v;
            var vSub = matPath.Substring(vStart + 2, 4);
            try
            {
                v = int.Parse( vSub );
            }
            catch( FormatException ) { }
            
            return v;
        }

        private void BuildMaterial()
        {
            ReadStrings();
            ReadTextures();

            ShaderPack = StringOffsetToStringMap[ File.FileHeader.ShaderPackageNameOffset ];
        }

        private void ReadTextures()
        {
            Textures = new Texture[File.TextureOffsets.Length];

            for( int i = 0; i < File.TextureOffsets.Length; i++ )
            {
                TextureUsage raw = (TextureUsage) File.Samplers[ i ].SamplerId;
                var texIndex = File.Samplers[ i ].TextureIndex;
                var texOffset = File.TextureOffsets[ texIndex ].Offset;
                var texPath = StringOffsetToStringMap[ texOffset ];
                Textures[ i ] = new Texture( this, raw, texPath );
            }
        }

        private void ReadStrings()
        {
            StringOffsetToStringMap = new Dictionary< int, string >();
            var mr = new MemoryStream( File.Strings );
            var br = new BinaryReader( mr );

            // They re-use offsets, so the number of offsets is not equal to the number of unique members
            var uniqueTextureCount = File.TextureOffsets.Select( t => t.Offset ).Distinct().Count();
            var uniqueUvColorSetCount = File.UvColorSets.Select( t => t.NameOffset ).Distinct().Count();
            var uniqueColorOffsetCount = File.ColorSetOffsets.Select( t => t ).Distinct().Count();

            // Add one for the shader package name at the end
            var stringCount = uniqueTextureCount + uniqueUvColorSetCount + uniqueColorOffsetCount + 1;
            for( int i = 0; i < stringCount; i++ )
            {
                long startOffset = br.BaseStream.Position;
                string tmp = br.ReadStringData();
                StringOffsetToStringMap[ (int) startOffset ] = tmp;
            }

            br.Dispose();
            mr.Dispose();
        }
    }
}