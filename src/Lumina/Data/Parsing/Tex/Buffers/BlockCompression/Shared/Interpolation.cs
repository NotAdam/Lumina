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
	internal static class Interpolation
	{
		/// <summary>
		/// Interpolates two colors by half.
		/// </summary>
		/// <param name="c0">The first color endpoint.</param>
		/// <param name="c1">The second color endpoint.</param>
		/// <returns>The interpolated color.</returns>
		public static ColorRgb24 InterpolateHalf(this ColorRgb24 c0, ColorRgb24 c1) =>
			InterpolateColor(c0, c1, 1, 2);

		/// <summary>
		/// Interpolates two colors by third.
		/// </summary>
		/// <param name="c0">The first color endpoint.</param>
		/// <param name="c1">The second color endpoint.</param>
		/// <param name="num">The dividend in the third.</param>
		/// <returns>The interpolated color.</returns>
		public static ColorRgb24 InterpolateThird(this ColorRgb24 c0, ColorRgb24 c1, int num) =>
			InterpolateColor(c0, c1, num, 3);

		/// <summary>
		/// Interpolates two colors by fourth with ATC interpolation.
		/// </summary>
		/// <param name="c0">The first color endpoint.</param>
		/// <param name="c1">The second color endpoint.</param>
		/// <param name="num">The dividend in the fourth.</param>
		/// <returns>The interpolated color.</returns>
		public static ColorRgb24 InterpolateFourthAtc(this ColorRgb24 c0, ColorRgb24 c1, int num) =>
			InterpolateColorAtc(c0, c1, num, 4);

		/// <summary>
		/// Interpolates two colors by fifth.
		/// </summary>
		/// <param name="a0">The first component.</param>
		/// <param name="a1">The second component.</param>
		/// <param name="num">The dividend in the fifth.</param>
		/// <returns>The interpolated component.</returns>
		public static byte InterpolateFifth(this byte a0, byte a1, int num) =>
			(byte)Interpolate(a0, a1, num, 5, 2);

		/// <summary>
		/// Interpolates two colors by seventh.
		/// </summary>
		/// <param name="a0">The first component.</param>
		/// <param name="a1">The second component.</param>
		/// <param name="num">The dividend in the seventh.</param>
		/// <returns>The interpolated component.</returns>
		public static byte InterpolateSeventh(this byte a0, byte a1, int num) =>
			(byte)Interpolate(a0, a1, num, 7, 3);

		/// <summary>
		/// Interpolates two colors.
		/// </summary>
		/// <param name="c0">The first color.</param>
		/// <param name="c1">The second color.</param>
		/// <param name="num">The dividend on each color component.</param>
		/// <param name="den">The divisor on each color component.</param>
		/// <returns>The interpolated color.</returns>
		private static ColorRgb24 InterpolateColor(ColorRgb24 c0, ColorRgb24 c1, int num, int den) => new ColorRgb24(
			(byte)Interpolate(c0.r, c1.r, num, den),
			(byte)Interpolate(c0.g, c1.g, num, den),
			(byte)Interpolate(c0.b, c1.b, num, den));

		/// <summary>
		/// Interpolates two colors with the ATC interpolation.
		/// </summary>
		/// <param name="c0">The first color.</param>
		/// <param name="c1">The second color.</param>
		/// <param name="num">The dividend on each color component.</param>
		/// <param name="den">The divisor on each color component.</param>
		/// <returns>The interpolated color.</returns>
		private static ColorRgb24 InterpolateColorAtc(ColorRgb24 c0, ColorRgb24 c1, int num, int den) => new ColorRgb24(
			(byte)InterpolateAtc(c0.r, c1.r, num, den),
			(byte)InterpolateAtc(c0.g, c1.g, num, den),
			(byte)InterpolateAtc(c0.b, c1.b, num, den));

		/// <summary>
		/// Interpolates two components.
		/// </summary>
		/// <param name="a">The first component.</param>
		/// <param name="b">The second component.</param>
		/// <param name="num">The dividend.</param>
		/// <param name="den">The divisor.</param>
		/// <param name="correction">A correction value for increased accuracy when working with integer interpolated values.</param>
		/// <returns>The interpolated component.</returns>
		private static int Interpolate(int a, int b, int num, int den, int correction = 0) =>
			(int)(((den - num) * a + num * b + correction) / (float)den);

		/// <summary>
		/// Interpolates two components with the ATC interpolation.
		/// </summary>
		/// <param name="a">The first component.</param>
		/// <param name="b">The second component.</param>
		/// <param name="num">The dividend.</param>
		/// <param name="den">The divisor.</param>
		/// <returns>The interpolated component.</returns>
		private static int InterpolateAtc(int a, int b, int num, int den) =>
			(int)(a - num / (float)den * b);
	}
}
