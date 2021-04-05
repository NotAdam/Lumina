using System;
using Lumina.Data.Parsing;
using Lumina.Extensions;

namespace Lumina.Data.Files
{
    public class MtrlFile : FileResource
    {
        public MaterialFileHeader FileHeader;
        public MaterialHeader MaterialHeader;
        public UvColorSet[] UvColorSets;
        public TextureOffset[] TextureOffsets;
        public int[] ColorSetOffsets;

        // Will have to double check this, this is from TexTools
        public ColorSetInfo ColorSetInfo;
        public ColorSetDyeInfo ColorSetDyeInfo;
        
        public ShaderKey[] ShaderKeys;
        public Constant[] Constants;
        public Sampler[] Samplers;

        public float[] ShaderValues;
        public byte[] Strings;

        public override void LoadFile()
        {
            FileHeader = Reader.ReadStructure<MaterialFileHeader>();
            TextureOffsets = Reader.ReadStructuresAsArray< TextureOffset >( FileHeader.TextureCount );

            UvColorSets = Reader.ReadStructuresAsArray< UvColorSet >( FileHeader.UvSetCount );

            ColorSetOffsets = Reader.ReadStructuresAsArray< Int32 >( FileHeader.ColorSetCount );

            Strings = Reader.ReadBytes( FileHeader.StringTableSize );
            
            // This seems to be a struct - do not know what it is
            Reader.Seek(Reader.BaseStream.Position + FileHeader.AdditionalDataSize);

            if( FileHeader.DataSetSize > 0 )
            {
                ColorSetInfo = Reader.ReadStructure< ColorSetInfo >();
                if (FileHeader.DataSetSize > 512)
                    ColorSetDyeInfo = Reader.ReadStructure< ColorSetDyeInfo >();
            }

            MaterialHeader = Reader.ReadStructure< MaterialHeader >();

            ShaderKeys = Reader.ReadStructuresAsArray< ShaderKey >( MaterialHeader.ShaderKeyCount );
            Constants = Reader.ReadStructuresAsArray< Constant >( MaterialHeader.ConstantCount );
            Samplers = Reader.ReadStructuresAsArray< Sampler >( MaterialHeader.SamplerCount );

            ShaderValues = Reader.ReadStructuresAsArray< float >( MaterialHeader.ShaderValueListSize / 4 );
        }
    }
}