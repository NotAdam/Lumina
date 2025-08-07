// Derived from https://github.com/Nominom/BCnEncoder.NET
// Copyright 2020 Nomi Lakkala, 2025 Lumina contributors
//
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
using System;
using BCnEncoder.Encoder;

namespace BCnEncoder.Shared
{
	internal static class ComponentHelper
	{
		public static ColorRgba32 ComponentToColor(ColorComponent component, byte componentValue)
		{
			switch (component)
			{
				case ColorComponent.R:
					return new ColorRgba32(componentValue, 0, 0, 255);

				case ColorComponent.G:
					return new ColorRgba32(0, componentValue, 0, 255);

				case ColorComponent.B:
					return new ColorRgba32(0, 0, componentValue, 255);

				case ColorComponent.A:
					return new ColorRgba32(0, 0, 0, componentValue);

				case ColorComponent.Luminance:
					return new ColorRgba32(componentValue, componentValue, componentValue, 255);

				default:
					throw new InvalidOperationException("Unsupported component.");
			}
		}

		public static ColorRgba32 ComponentToColor(ColorRgba32 existingColor, ColorComponent component, byte componentValue)
		{
			switch (component)
			{
				case ColorComponent.R:
					existingColor.r = componentValue;
					break;

				case ColorComponent.G:
					existingColor.g = componentValue;
					break;

				case ColorComponent.B:
					existingColor.b = componentValue;
					break;

				case ColorComponent.A:
					existingColor.a = componentValue;
					break;

				case ColorComponent.Luminance:
					existingColor.r = existingColor.g = existingColor.b = componentValue;
					break;

				default:
					throw new InvalidOperationException("Unsupported component.");
			}

			return existingColor;
		}

		public static byte ColorToComponent(ColorRgba32 color, ColorComponent component)
		{
			switch (component)
			{
				case ColorComponent.R:
					return color.r;

				case ColorComponent.G:
					return color.g;

				case ColorComponent.B:
					return color.b;

				case ColorComponent.A:
					return color.a;

				case ColorComponent.Luminance:
					return (byte)(new ColorYCbCr(color).y * 255);

				default:
					throw new InvalidOperationException("Unsupported component.");
			}
		}
	}
}
