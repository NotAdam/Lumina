// Derived from https://github.com/Nominom/BCnEncoder.NET
// Copyright 2020 Nomi Lakkala, 2025 Lumina contributors
//
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
namespace BCnEncoder.Shared
{
	internal static class ImageToBlocks
	{
		#region Blocks to colors

		internal static ColorRgba32[] ColorsFromRawBlocks(RawBlock4X4Rgba32[,] blocks, int pixelWidth, int pixelHeight)
		{
			var output = new ColorRgba32[pixelWidth * pixelHeight];

			for (var y = 0; y < pixelHeight; y++)
			{
				for (var x = 0; x < pixelWidth; x++)
				{
					var blockIndexX = x >> 2;
					var blockIndexY = y >> 2;
					var blockInternalIndexX = x & 3;
					var blockInternalIndexY = y & 3;

					output[x + y * pixelWidth] = blocks[blockIndexX, blockIndexY][blockInternalIndexX, blockInternalIndexY];
				}
			}

			return output;
		}

		internal static ColorRgba32[] ColorsFromRawBlocks(RawBlock4X4Rgba32[] blocks, int pixelWidth, int pixelHeight)
		{
			var blocksWidth = ((pixelWidth + 3) & ~3) >> 2;
			var output = new ColorRgba32[pixelWidth * pixelHeight];

			for (var y = 0; y < pixelHeight; y++)
			{
				for (var x = 0; x < pixelWidth; x++)
				{
					var blockIndexX = x >> 2;
					var blockIndexY = y >> 2;
					var blockInternalIndexX = x & 3;
					var blockInternalIndexY = y & 3;

					var blockIndex = blockIndexX + blockIndexY * blocksWidth;

					output[x + y * pixelWidth] = blocks[blockIndex][blockInternalIndexX, blockInternalIndexY];
				}
			}

			return output;
		}

		internal static ColorRgbFloat[] ColorsFromRawBlocks(RawBlock4X4RgbFloat[] blocks, int pixelWidth, int pixelHeight)
		{
			var blocksWidth = ((pixelWidth + 3) & ~3) >> 2;
			var output = new ColorRgbFloat[pixelWidth * pixelHeight];

			for (var y = 0; y < pixelHeight; y++)
			{
				for (var x = 0; x < pixelWidth; x++)
				{
					var blockIndexX = x >> 2;
					var blockIndexY = y >> 2;
					var blockInternalIndexX = x & 3;
					var blockInternalIndexY = y & 3;

					var blockIndex = blockIndexX + blockIndexY * blocksWidth;

					output[x + y * pixelWidth] = blocks[blockIndex][blockInternalIndexX, blockInternalIndexY];
				}
			}

			return output;
		}

		#endregion

		public static int CalculateNumOfBlocks(int pixelWidth, int pixelHeight)
		{
			var blocksWidth = ((pixelWidth + 3) & ~3) >> 2;
			var blocksHeight = ((pixelHeight + 3) & ~3) >> 2;

			return blocksWidth * blocksHeight;
		}
		public static void CalculateNumOfBlocks(int pixelWidth, int pixelHeight, out int blocksWidth, out int blocksHeight)
		{
			blocksWidth = ((pixelWidth + 3) & ~3) >> 2;
			blocksHeight = ((pixelHeight + 3) & ~3) >> 2;
		}
	}
}
