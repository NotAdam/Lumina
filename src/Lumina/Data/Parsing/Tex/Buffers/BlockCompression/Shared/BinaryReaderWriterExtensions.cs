// Derived from https://github.com/Nominom/BCnEncoder.NET
// Copyright 2020 Nomi Lakkala, 2025 Lumina contributors
//
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace BCnEncoder.Shared
{
	internal static class BinaryReaderWriterExtensions
	{
		public static unsafe void WriteStruct<T>(this BinaryWriter bw, T t) where T : unmanaged
		{
			var size = Unsafe.SizeOf<T>();
			var bytes = stackalloc byte[size];
			Unsafe.Write(bytes, t);
			var bSpan = new Span<byte>(bytes, size);
			bw.Write(bSpan);
		}

		public static unsafe T ReadStruct<T>(this BinaryReader br) where T : unmanaged
		{
			var size = Unsafe.SizeOf<T>();
			var bytes = stackalloc byte[size];
			var bSpan = new Span<byte>(bytes, size);
			br.Read(bSpan);
			return Unsafe.Read<T>(bytes);
		}

		public static void AddPadding(this BinaryWriter bw, uint padding)
		{
			for (var i = 0; i < padding; i++)
			{
				bw.Write((byte)0);
			}
		}
		public static void AddPadding(this BinaryWriter bw, int padding)
			=> AddPadding(bw, (uint) padding);

		public static void SkipPadding(this BinaryReader br, uint padding)
		{
			br.BaseStream.Seek(padding, SeekOrigin.Current);
		}

		public static void SkipPadding(this BinaryReader br, int padding)
			=> SkipPadding(br, (uint) padding);
	}
}