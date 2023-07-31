using System.Diagnostics.CodeAnalysis;

namespace Lumina.Data.Parsing.Tex.DirectDrawSurface;

/// <summary>
/// Resource data formats, including fully-typed and typeless formats.
///
/// See: https://learn.microsoft.com/en-us/windows/win32/api/dxgiformat/ne-dxgiformat-dxgi_format
/// </summary>
public enum DxgiFormat
{
#pragma warning disable CS1591
    Unknown = 0,
    R32G32B32A32Typeless = 1,
    R32G32B32A32Float = 2,
    R32G32B32A32Uint = 3,
    R32G32B32A32Sint = 4,
    R32G32B32Typeless = 5,
    R32G32B32Float = 6,
    R32G32B32Uint = 7,
    R32G32B32Sint = 8,
    R16G16B16A16Typeless = 9,
    R16G16B16A16Float = 10, // 0x0000000A
    R16G16B16A16Unorm = 11, // 0x0000000B
    R16G16B16A16Uint = 12, // 0x0000000C
    R16G16B16A16Snorm = 13, // 0x0000000D
    R16G16B16A16Sint = 14, // 0x0000000E
    R32G32Typeless = 15, // 0x0000000F
    R32G32Float = 16, // 0x00000010
    R32G32Uint = 17, // 0x00000011
    R32G32Sint = 18, // 0x00000012
    R32G8X24Typeless = 19, // 0x00000013
    D32FloatS8X24Uint = 20, // 0x00000014
    R32FloatX8X24Typeless = 21, // 0x00000015
    X32TypelessG8X24Uint = 22, // 0x00000016
    R10G10B10A2Typeless = 23, // 0x00000017
    R10G10B10A2Unorm = 24, // 0x00000018
    R10G10B10A2Uint = 25, // 0x00000019
    R11G11B10Float = 26, // 0x0000001A
    R8G8B8A8Typeless = 27, // 0x0000001B
    R8G8B8A8Unorm = 28, // 0x0000001C
    R8G8B8A8UnormSrgb = 29, // 0x0000001D
    R8G8B8A8Uint = 30, // 0x0000001E
    R8G8B8A8Snorm = 31, // 0x0000001F
    R8G8B8A8Sint = 32, // 0x00000020
    R16G16Typeless = 33, // 0x00000021
    R16G16Float = 34, // 0x00000022
    R16G16Unorm = 35, // 0x00000023
    R16G16Uint = 36, // 0x00000024
    R16G16Snorm = 37, // 0x00000025
    R16G16Sint = 38, // 0x00000026
    R32Typeless = 39, // 0x00000027
    D32Float = 40, // 0x00000028
    R32Float = 41, // 0x00000029
    R32Uint = 42, // 0x0000002A
    R32Sint = 43, // 0x0000002B
    R24G8Typeless = 44, // 0x0000002C
    D24UnormS8Uint = 45, // 0x0000002D
    R24UnormX8Typeless = 46, // 0x0000002E
    X24TypelessG8Uint = 47, // 0x0000002F
    R8G8Typeless = 48, // 0x00000030
    R8G8Unorm = 49, // 0x00000031
    R8G8Uint = 50, // 0x00000032
    R8G8Snorm = 51, // 0x00000033
    R8G8Sint = 52, // 0x00000034
    R16Typeless = 53, // 0x00000035
    R16Float = 54, // 0x00000036
    D16Unorm = 55, // 0x00000037
    R16Unorm = 56, // 0x00000038
    R16Uint = 57, // 0x00000039
    R16Snorm = 58, // 0x0000003A
    R16Sint = 59, // 0x0000003B
    R8Typeless = 60, // 0x0000003C
    R8Unorm = 61, // 0x0000003D
    R8Uint = 62, // 0x0000003E
    R8Snorm = 63, // 0x0000003F
    R8Sint = 64, // 0x00000040
    A8Unorm = 65, // 0x00000041
    R1Unorm = 66, // 0x00000042
    R9G9B9E5Sharedexp = 67, // 0x00000043
    R8G8B8G8Unorm = 68, // 0x00000044
    G8R8G8B8Unorm = 69, // 0x00000045
    Bc1Typeless = 70, // 0x00000046
    Bc1Unorm = 71, // 0x00000047
    Bc1UnormSrgb = 72, // 0x00000048
    Bc2Typeless = 73, // 0x00000049
    Bc2Unorm = 74, // 0x0000004A
    Bc2UnormSrgb = 75, // 0x0000004B
    Bc3Typeless = 76, // 0x0000004C
    Bc3Unorm = 77, // 0x0000004D
    Bc3UnormSrgb = 78, // 0x0000004E
    Bc4Typeless = 79, // 0x0000004F
    Bc4Unorm = 80, // 0x00000050
    Bc4Snorm = 81, // 0x00000051
    Bc5Typeless = 82, // 0x00000052
    Bc5Unorm = 83, // 0x00000053
    Bc5Snorm = 84, // 0x00000054
    B5G6R5Unorm = 85, // 0x00000055
    B5G5R5A1Unorm = 86, // 0x00000056
    B8G8R8A8Unorm = 87, // 0x00000057
    B8G8R8X8Unorm = 88, // 0x00000058
    R10G10B10XrBiasA2Unorm = 89, // 0x00000059
    B8G8R8A8Typeless = 90, // 0x0000005A
    B8G8R8A8UnormSrgb = 91, // 0x0000005B
    B8G8R8X8Typeless = 92, // 0x0000005C
    B8G8R8X8UnormSrgb = 93, // 0x0000005D
    Bc6HTypeless = 94, // 0x0000005E
    Bc6HUf16 = 95, // 0x0000005F
    Bc6HSf16 = 96, // 0x00000060
    Bc7Typeless = 97, // 0x00000061
    Bc7Unorm = 98, // 0x00000062
    Bc7UnormSrgb = 99, // 0x00000063
    Ayuv = 100, // 0x00000064
    Y410 = 101, // 0x00000065
    Y416 = 102, // 0x00000066
    Nv12 = 103, // 0x00000067
    P010 = 104, // 0x00000068
    P016 = 105, // 0x00000069
    Yuv420Opaque = 106, // 0x0000006A
    Yuy2 = 107, // 0x0000006B
    Y210 = 108, // 0x0000006C
    Y216 = 109, // 0x0000006D
    Nv11 = 110, // 0x0000006E
    Ai44 = 111, // 0x0000006F
    Ia44 = 112, // 0x00000070
    P8 = 113, // 0x00000071
    A8P8 = 114, // 0x00000072
    B4G4R4A4Unorm = 115, // 0x00000073

    [SuppressMessage( "ReSharper", "InconsistentNaming" )]
    R10G10B10_7E3_A2Float = 116,

    [SuppressMessage( "ReSharper", "InconsistentNaming" )]
    R10G10B10_6E4_A2Float = 117,
    D16UnormS8Uint = 118,
    R16UnormX8Typeless = 119,
    X16TypelessG8Uint = 120,
    P208 = 130, // 0x00000082
    V208 = 131, // 0x00000083
    V408 = 132, // 0x00000084
    R10G10B10SnormA2Unorm = 189, // 0x000000BD
    R4G4Unorm = 190, // 0x000000BE
    A4B4G4R4Unorm = 191, // 0x000000BF
#pragma warning restore CS1591
}