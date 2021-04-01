using System;
using System.Collections.Generic;
using System.IO;
using Lumina.Data.Attributes;

namespace Lumina.Data.Files
{
    //TODO: add gear-specific functionality, hopefully when we get 
    //useful enums like GearSlot.Mainhand or something
    [FileExtension( ".imc" )]
    public class ImcFile : FileResource
    {
        public struct ImageChangeData
        {
            public byte MaterialId;

            public byte DecalId;

            // AttrMask : 10, SoundId : 6
            private ushort _AttributeAndSound;
            public ushort AttributeMask => (ushort)( _AttributeAndSound & 0x3FF );
            public ushort SoundId => (ushort)( _AttributeAndSound & 0xFC00 );

            public byte VfxId;
            private byte _MaterialAnimationIdMask;
            public byte MaterialAnimationId => (byte)( _MaterialAnimationIdMask & 0xF000 );

            public static ImageChangeData Read( BinaryReader br )
            {
                var imc = new ImageChangeData();

                imc.MaterialId = br.ReadByte();
                imc.DecalId = br.ReadByte();
                imc._AttributeAndSound = br.ReadUInt16();
                imc.VfxId = br.ReadByte();
                imc._MaterialAnimationIdMask = br.ReadByte();

                return imc;
            }
        }

        public struct ImageChangeParts
        {
            public ImageChangeData DefaultVariant;
            public ImageChangeData[] Variants;
            internal List< ImageChangeData > VariantList;

            public static ImageChangeParts Read( BinaryReader br, int variantCount )
            {
                var parts = new ImageChangeParts();

                parts.DefaultVariant = ImageChangeData.Read( br );
                parts.Variants = new ImageChangeData[variantCount];
                for( var i = 0; i < variantCount; i++ )
                    parts.Variants[ i ] = ImageChangeData.Read( br );

                return parts;
            }

            internal void Init()
            {
                Variants = VariantList.ToArray();
                VariantList = null;
            }
        }

        /// <summary>
        /// The number of variants per part, excluding the default variant.
        /// </summary>
        public ushort Count;

        /// <summary>
        /// The mask defining which parts exist in this ImcFile. Weapons and
        /// monsters have a PartMask of 1. Accessories and Equipment have a
        /// PartMask of 31. This defines how many parts there are as well.
        /// This information is unverified.
        /// </summary>
        public ushort PartMask;

        private ImageChangeParts[] Parts;

        public ImageChangeParts[] GetParts()
        {
            return Parts;
        }

        public ImageChangeParts GetPart( int index )
        {
            return Parts[ index ];
        }

        public ImageChangeData GetDefaultVariant()
        {
            if( Parts.Length > 1 )
                throw new NotImplementedException(
                    "This file has more than one Part. Please specify the part with" +
                    "the GetDefaultVariant( int partIndex ) signature." );

            return Parts[ 0 ].DefaultVariant;
        }

        public ImageChangeData GetDefaultVariant( int partIndex )
        {
            return Parts[ partIndex ].DefaultVariant;
        }

        public ImageChangeData GetVariant( int index )
        {
            if( Parts.Length > 1 )
                throw new NotImplementedException(
                    "This file has more than one Part. Please specify the part with" +
                    "the GetVariant( int partIndex, int variantIndex ) signature." );

            return Parts[ 0 ].Variants[ index ];
        }

        public ImageChangeData GetVariant( int partIndex, int variantIndex )
        {
            return Parts[ partIndex ].Variants[ variantIndex ];
        }

        public override void LoadFile()
        {
            Count = Reader.ReadUInt16();
            PartMask = Reader.ReadUInt16();

            var partList = new List< ImageChangeParts >();
            var parts = 0;

            // Initialize the parts we have
            for( var i = 0; i < 8; i++ )
            {
                var val = 1 << i;
                if( ( PartMask & val ) == val )
                    parts++;
            }

            // Grab the list of default variants, one for each part
            for( var i = 0; i < parts; i++ )
            {
                var currentPart = new ImageChangeParts
                {
                    VariantList = new List< ImageChangeData >(),
                    DefaultVariant = ImageChangeData.Read( Reader )
                };
                partList.Add( currentPart );
            }

            // Dish out variants 1, 2, etc... to each part
            for( var i = 0; i < Count; i++ )
                foreach( var imageChangeParts in partList )
                    imageChangeParts.VariantList.Add( ImageChangeData.Read( Reader ) );

            Parts = new ImageChangeParts[parts];
            for( var i = 0; i < parts; i++ )
            {
                var imcParts = partList[ i ];
                imcParts.Init();
                Parts[ i ] = imcParts;
            }

            partList.Clear();
        }
    }
}