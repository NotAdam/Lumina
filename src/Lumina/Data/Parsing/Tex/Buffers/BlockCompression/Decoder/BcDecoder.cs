// Derived from https://github.com/Nominom/BCnEncoder.NET
// Copyright 2020 Nomi Lakkala, 2025 Lumina contributors
//
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
using BCnEncoder.Decoder.Options;
using BCnEncoder.Shared;
using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;

namespace BCnEncoder.Decoder
{
	/// <summary>
	/// Decodes compressed files into Rgba Format.
	/// </summary>
	internal class BcDecoder
	{
		/// <summary>
		/// The options for the decoder.
		/// </summary>
		public DecoderOptions Options { get; } = new DecoderOptions();

		/// <summary>
		/// The output options of the decoder.
		/// </summary>
		public DecoderOutputOptions OutputOptions { get; } = new DecoderOutputOptions();
		#region LDR
        
		#region Sync API

		/// <summary>
		/// Decode a single encoded image from raw bytes.
		/// This method will read the expected amount of bytes from the given input stream and decode it.
		/// Make sure there is no file header information left in the stream before the encoded data.
		/// </summary>
		/// <param name="inputStream">The stream containing the raw encoded data.</param>
		/// <param name="pixelWidth">The pixelWidth of the image.</param>
		/// <param name="pixelHeight">The pixelHeight of the image.</param>
		/// <param name="format">The Format the encoded data is in.</param>
		/// <returns>The decoded image.</returns>
		public ColorRgba32[] DecodeRaw(Stream inputStream, int pixelWidth, int pixelHeight, CompressionFormat format)
		{
			var dataArray = new byte[GetBufferSize(format, pixelWidth, pixelHeight)];
			inputStream.Read(dataArray, 0, dataArray.Length);

			return DecodeRaw(dataArray, pixelWidth, pixelHeight, format);
		}

		/// <summary>
		/// Decode a single encoded image from raw bytes.
		/// </summary>
		/// <param name="input">The byte array containing the raw encoded data.</param>
		/// <param name="pixelWidth">The pixelWidth of the image.</param>
		/// <param name="pixelHeight">The pixelHeight of the image.</param>
		/// <param name="format">The Format the encoded data is in.</param>
		/// <returns>The decoded image.</returns>
		public ColorRgba32[] DecodeRaw(byte[] input, int pixelWidth, int pixelHeight, CompressionFormat format)
		{
			return DecodeRaw(input, pixelWidth, pixelHeight, format, default);
		}

		#endregion
		#endregion

		/// <summary>
		/// Decode raw encoded image asynchronously.
		/// </summary>
		/// <param name="input">The <see cref="Memory{T}"/> containing the encoded data.</param>
		/// <param name="pixelWidth">The width of the image.</param>
		/// <param name="pixelHeight">The height of the image.</param>
		/// <param name="format">The Format the encoded data is in.</param>
		/// <param name="token">The cancellation token for this operation. May be default, if the operation is not asynchronous.</param>
		/// <returns>The decoded Rgba32 image.</returns>
		public ColorRgba32[] DecodeRaw(ReadOnlyMemory<byte> input, int pixelWidth, int pixelHeight, CompressionFormat format, CancellationToken token)
		{
			if (format == CompressionFormat.Unknown)
			{
				throw new ArgumentException($"Unsupported compression format: {format}");
			}
			if (input.Length % GetBlockSize(format) != 0)
			{
				throw new ArgumentException("The size of the input buffer does not align with the compression format.");
			}

			var context = new OperationContext
			{
				CancellationToken = token,
				IsParallel = Options.IsParallel,
				TaskCount = Options.TaskCount
			};
            
			var isCompressedFormat = format.IsCompressedFormat();
			if (isCompressedFormat)
			{
				// DecodeInternal as compressed data
				var decoder = GetRgba32Decoder(format);

				if (format.IsHdrFormat())
				{
					throw new NotSupportedException($"This Format is not an RGBA32 compatible format: {format}, please use the HDR versions of the decode methods.");
				}
				if (decoder == null)
				{
					throw new NotSupportedException($"This Format is not supported: {format}");
				}

				var blocks = decoder.Decode(input, context);

				return ImageToBlocks.ColorsFromRawBlocks(blocks, pixelWidth, pixelHeight); ;
			}

			// DecodeInternal as raw data
			var rawDecoder = GetRawDecoder(format);

			return rawDecoder.Decode(input, context);
		}
        
		
		#region Support

		#region Get decoder

		private IBcBlockDecoder<RawBlock4X4Rgba32> GetRgba32Decoder(CompressionFormat format)
		{
			switch (format)
			{
				case CompressionFormat.Bc1:
					return new Bc1NoAlphaDecoder();

				case CompressionFormat.Bc1WithAlpha:
					return new Bc1ADecoder();

				case CompressionFormat.Bc2:
					return new Bc2Decoder();

				case CompressionFormat.Bc3:
					return new Bc3Decoder();

				case CompressionFormat.Bc4:
					return new Bc4Decoder(OutputOptions.Bc4Component);

				case CompressionFormat.Bc5:
					return new Bc5Decoder(OutputOptions.Bc5Component1, OutputOptions.Bc5Component2);

				case CompressionFormat.Bc7:
					return new Bc7Decoder();

				case CompressionFormat.Atc:
					return new AtcDecoder();

				case CompressionFormat.AtcExplicitAlpha:
					return new AtcExplicitAlphaDecoder();

				case CompressionFormat.AtcInterpolatedAlpha:
					return new AtcInterpolatedAlphaDecoder();

				default:
					return null;
			}
		}
        
		private IBcBlockDecoder<RawBlock4X4RgbFloat> GetRgbFloatDecoder(CompressionFormat format)
		{
			switch (format)
			{
				case CompressionFormat.Bc6S:
					return new Bc6SDecoder();
				case CompressionFormat.Bc6U:
					return new Bc6UDecoder();
				default:
					return null;
			}
		}

		#endregion

		#region Get raw decoder
        
		private IRawDecoder GetRawDecoder(CompressionFormat format)
		{
			switch (format)
			{
				case CompressionFormat.R:
					return new RawRDecoder(OutputOptions.RedAsLuminance);

				case CompressionFormat.Rg:
					return new RawRgDecoder();

				case CompressionFormat.Rgb:
					return new RawRgbDecoder();

				case CompressionFormat.Rgba:
					return new RawRgbaDecoder();

				case CompressionFormat.Bgra:
					return new RawBgraDecoder();

				default:
					throw new ArgumentOutOfRangeException(nameof(format), format, null);
			}
		}

		#endregion

		#region Get block size

		/// <summary>
		/// Get the size of blocks for the given compression format in bytes.
		/// </summary>
		/// <param name="format">The compression format used.</param>
		/// <returns>The size of a single block in bytes.</returns>
		public int GetBlockSize(CompressionFormat format)
		{
			switch (format)
			{
				case CompressionFormat.R:
					return 1;

				case CompressionFormat.Rg:
					return 2;

				case CompressionFormat.Rgb:
					return 3;

				case CompressionFormat.Rgba:
					return 4;

				case CompressionFormat.Bgra:
					return 4;

				case CompressionFormat.Bc1:
				case CompressionFormat.Bc1WithAlpha:
					return Unsafe.SizeOf<Bc1Block>();

				case CompressionFormat.Bc2:
					return Unsafe.SizeOf<Bc2Block>();

				case CompressionFormat.Bc3:
					return Unsafe.SizeOf<Bc3Block>();

				case CompressionFormat.Bc4:
					return Unsafe.SizeOf<Bc4Block>();

				case CompressionFormat.Bc5:
					return Unsafe.SizeOf<Bc5Block>();

				case CompressionFormat.Bc6S:
				case CompressionFormat.Bc6U:
					return Unsafe.SizeOf<Bc6Block>();

				case CompressionFormat.Bc7:
					return Unsafe.SizeOf<Bc7Block>();

				case CompressionFormat.Atc:
					return Unsafe.SizeOf<AtcBlock>();

				case CompressionFormat.AtcExplicitAlpha:
					return Unsafe.SizeOf<AtcExplicitAlphaBlock>();

				case CompressionFormat.AtcInterpolatedAlpha:
					return Unsafe.SizeOf<AtcInterpolatedAlphaBlock>();

				case CompressionFormat.Unknown:
					return 0;

				default:
					throw new ArgumentOutOfRangeException(nameof(format), format, null);
			}
		}

		#endregion

		private int GetBufferSize(CompressionFormat format, int pixelWidth, int pixelHeight)
		{
			switch (format)
			{
				case CompressionFormat.R:
					return pixelWidth * pixelHeight;

				case CompressionFormat.Rg:
					return 2 * pixelWidth * pixelHeight;

				case CompressionFormat.Rgb:
					return 3 * pixelWidth * pixelHeight;

				case CompressionFormat.Rgba:
				case CompressionFormat.Bgra:
					return 4 * pixelWidth * pixelHeight;

				case CompressionFormat.Bc1:
				case CompressionFormat.Bc1WithAlpha:
				case CompressionFormat.Bc2:
				case CompressionFormat.Bc3:
				case CompressionFormat.Bc4:
				case CompressionFormat.Bc5:
				case CompressionFormat.Bc6S:
				case CompressionFormat.Bc6U:
				case CompressionFormat.Bc7:
				case CompressionFormat.Atc:
				case CompressionFormat.AtcExplicitAlpha:
				case CompressionFormat.AtcInterpolatedAlpha:
					return GetBlockSize(format) * ImageToBlocks.CalculateNumOfBlocks(pixelWidth, pixelHeight);

				case CompressionFormat.Unknown:
					return 0;
				default:
					throw new ArgumentOutOfRangeException(nameof(format), format, null);
			}
		}

		#endregion
	}
}
