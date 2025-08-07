// Derived from https://github.com/Nominom/BCnEncoder.NET
// Copyright 2020 Nomi Lakkala, 2025 Lumina contributors
//
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
using System;
using BCnEncoder.Shared;

namespace BCnEncoder.Decoder.Options
{
	/// <summary>
	/// General options for the decoder.
	/// </summary>
	internal class DecoderOptions
	{
		/// <summary>
		/// Whether the blocks should be decoded in parallel. This can be much faster than single-threaded decoding,
		/// but is slow if multiple textures are being processed at the same time.
		/// When a debugger is attached, the decoder defaults to single-threaded operation to ease debugging.
		/// Default is false.
		/// </summary>
		/// <remarks>Parallel execution will be ignored in RawDecoders, due to minimal performance gain.</remarks>
		public bool IsParallel { get; set; }

		/// <summary>
		/// Determines how many tasks should be used for parallel processing.
		/// </summary>
		public int TaskCount { get; set; } = Environment.ProcessorCount;
	}
}
