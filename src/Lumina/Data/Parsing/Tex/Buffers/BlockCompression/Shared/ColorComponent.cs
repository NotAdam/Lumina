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
	/// <summary>
	/// The component to take from colors for BC4 and BC5.
	/// </summary>
	internal enum ColorComponent
	{
		/// <summary>
		/// The red component of an Rgba32 color.
		/// </summary>
		R,

		/// <summary>
		/// The green component of an Rgba32 color.
		/// </summary>
		G,

		/// <summary>
		/// The blue component of an Rgba32 color.
		/// </summary>
		B,

		/// <summary>
		/// The alpha component of an Rgba32 color.
		/// </summary>
		A,

		/// <summary>
		/// Use the color's luminance value as the component.
		/// </summary>
		Luminance
	}
}
