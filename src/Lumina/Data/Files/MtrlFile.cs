using Lumina.Data.Parsing;
using Lumina.Extensions;

namespace Lumina.Data.Files
{
    public class MtrlFile : FileResource
    {
        public MaterialFileHeader FileHeader;
        public MaterialHeader MaterialHeader;
        public TextureOffset[] TextureOffsets = null!;
        public UvColorSet[] UvColorSets = null!;
        public ColorSet[] ColorSets = null!;

        // Will have to double check this, this is from TexTools
        public ColorSetInfo ColorSetInfo;
        public ColorSetDyeInfo ColorSetDyeInfo;

        public ShaderKey[] ShaderKeys = null!;
        public Constant[] Constants = null!;
        public Sampler[] Samplers = null!;

        public float[] ShaderValues = null!;
        public byte[] Strings = null!;

        public override void LoadFile()
        {
            FileHeader = MaterialFileHeader.Read( Reader );
            TextureOffsets = new TextureOffset[ FileHeader.TextureCount ];

            uint[] offsets = Reader.ReadUInt32s( FileHeader.TextureCount );

            for( int i = 0; i < offsets.Length; i++ )
            {
                TextureOffsets[ i ].Offset = (ushort)offsets[ i ];
                TextureOffsets[ i ].Flags = (ushort)( offsets[ i ] >> 16 );
            }

            UvColorSets = Reader.ReadStructuresAsArray< UvColorSet >( FileHeader.UvSetCount );
            
            ColorSets = Reader.ReadStructuresAsArray< ColorSet >( FileHeader.ColorSetCount );

            Strings = Reader.ReadBytes( FileHeader.StringTableSize );

            // This seems to be a struct - do not know what it is
            Reader.Seek( Reader.BaseStream.Position + FileHeader.AdditionalDataSize );

            if( FileHeader.DataSetSize > 0 )
            {
                ColorSetInfo = Reader.ReadStructure< ColorSetInfo >();
                if( FileHeader.DataSetSize > 512 )
                    ColorSetDyeInfo = Reader.ReadStructure< ColorSetDyeInfo >();
            }

            MaterialHeader = Reader.ReadStructure< MaterialHeader >();

            ShaderKeys = Reader.ReadStructuresAsArray< ShaderKey >( MaterialHeader.ShaderKeyCount );
            Constants = Reader.ReadStructuresAsArray< Constant >( MaterialHeader.ConstantCount );
            Samplers = Reader.ReadStructuresAsArray< Sampler >( MaterialHeader.SamplerCount );

            ShaderValues = Reader.ReadSingles( MaterialHeader.ShaderValueListSize / 4 );
        }
    }
}