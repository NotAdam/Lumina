using System;
using Lumina.Data.Files;
using Lumina.Data.Parsing;

namespace Lumina.Models.Materials
{
    public class Texture
    {
        /// <summary>
        /// Less specific, and easier to use texture usage enumeration
        /// See <see cref="TextureUsage"/> for a more complex enumeration.
        /// </summary>
        public enum Usage
        {
            Catchlight,
            Diffuse,
            Envmap,
            Mask,
            Normal,
            Reflection,
            Specular,
            Wave,
            Whitecap,
        }

        /// <summary>
        /// A convenience reference to the Material that instantiated this Texture.
        /// </summary>
        public Material Parent { get; private set; }
        
        /// <summary>
        /// The raw shader ID this Texture is used as input for.
        /// </summary>
        public TextureUsage TextureUsageRaw { get; private set; }
        
        /// <summary>
        /// The more user-friendly usage type of this Texture.
        /// </summary>
        public Usage TextureUsageSimple { get; private set; }
        
        /// <summary>
        /// The path to this Texture.
        /// </summary>
        public string TexturePath { get; private set; }

        private bool _isLoaded = false;
        private TexFile _tex;

        /// <summary>
        /// Creates a new Texture instance without resolving any game data.
        /// </summary>
        /// <param name="parent">The Material this Texture has been instantiated for.</param>
        /// <param name="raw">The <see cref="TextureUsage"/> this Texture is input for.</param>
        /// <param name="texturePath">The path to this Texture.</param>
        public Texture( Material parent, TextureUsage raw, string texturePath )
        {
            Parent = parent;
            TextureUsageRaw = raw;
            TextureUsageSimple = GetUsage( raw );
            TexturePath = texturePath;
        }
        
        /// <summary>
        /// Creates a new Texture instance without resolving any game data.
        /// </summary>
        /// <param name="raw">The <see cref="TextureUsage"/> this Texture is input for.</param>
        /// <param name="texturePath">The path to this Texture.</param>
        public Texture( TextureUsage raw, string texturePath ) : this( null, raw, texturePath ) { }
        
        /// <summary>
        /// Retrieve the TexFile referenced by this Texture, and store it
        /// in this Texture for future use.
        /// </summary>
        /// <param name="data">A reference to game data access.</param>
        /// <returns>The TexFile referenced by this Texture if found, null otherwise.</returns>
        public TexFile GetTexture(GameData data)
        {
            if( _isLoaded ) return _tex;
            if( data == null ) return null;

            _tex = data.GetFile< TexFile >( TexturePath );
            _isLoaded = true;

            return _tex;
        }
        
        /// <summary>
        /// Retrieve the TexFile referenced by this Texture without storing it
        /// or retrieving it from this Texture's local reference.
        /// </summary>
        /// <param name="data">A reference to game data access.</param>
        /// <returns>The TexFile referenced by this Texture if found, null otherwise.</returns>
        public TexFile GetTextureNc(GameData data)
        {
            return data.GetFile< TexFile >( TexturePath );
        }

        private static Usage GetUsage(TextureUsage usage)
        {
            return usage switch
            {
                TextureUsage.Sampler => Usage.Diffuse,
                TextureUsage.Sampler0 => Usage.Diffuse,
                TextureUsage.Sampler1 => Usage.Diffuse,
                TextureUsage.SamplerCatchlight => Usage.Catchlight,
                TextureUsage.SamplerColorMap0 => Usage.Diffuse,
                TextureUsage.SamplerColorMap1 => Usage.Diffuse,
                TextureUsage.SamplerDiffuse => Usage.Diffuse,
                TextureUsage.SamplerEnvMap => Usage.Envmap,
                TextureUsage.SamplerMask => Usage.Mask,
                TextureUsage.SamplerNormal => Usage.Normal,
                TextureUsage.SamplerNormalMap0 => Usage.Normal,
                TextureUsage.SamplerNormalMap1 => Usage.Normal,
                TextureUsage.SamplerReflection => Usage.Reflection,
                TextureUsage.SamplerSpecular => Usage.Specular,
                TextureUsage.SamplerSpecularMap0 => Usage.Specular,
                TextureUsage.SamplerSpecularMap1 => Usage.Specular,
                TextureUsage.SamplerWaveMap => Usage.Wave,
                TextureUsage.SamplerWaveletMap0 => Usage.Wave,
                TextureUsage.SamplerWaveletMap1 => Usage.Wave,
                TextureUsage.SamplerWhitecapMap => Usage.Whitecap,
                _ => throw new ArgumentOutOfRangeException( nameof( usage ), usage, null )
            };
        }
    }
}