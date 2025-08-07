// Derived from https://github.com/Nominom/BCnEncoder.NET
// Copyright 2020 Nomi Lakkala, 2025 Lumina contributors
//
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
using BCnEncoder.Shared;

namespace BCnEncoder.Decoder.Options
{
	/// <summary>
	/// A class for the decoder output options.
	/// </summary>
	internal class DecoderOutputOptions
	{
		/// <summary>
		/// If true, when decoding from R8 raw format,
		/// output pixels will have all colors set to the same value (greyscale).
		/// Default is true. (Does not apply to BC4 format.)
		/// </summary>
		public bool RedAsLuminance { get; set; } = true;

		/// <summary>
		/// The color channel to populate with the values of a BC4 block.
		/// </summary>
		public ColorComponent Bc4Component { get; set; } = ColorComponent.R;

		/// <summary>
		/// The color channel to populate with the values of the first BC5 block.
		/// </summary>
		public ColorComponent Bc5Component1 { get; set; } = ColorComponent.R;

		/// <summary>
		/// The color channel to populate with the values of the second BC5 block.
		/// </summary>
		public ColorComponent Bc5Component2 { get; set; } = ColorComponent.G;
	}
}
