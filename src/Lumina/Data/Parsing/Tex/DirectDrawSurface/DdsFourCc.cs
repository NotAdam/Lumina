namespace Lumina.Data.Parsing.Tex.DirectDrawSurface;

/// <summary>
/// Specify how pixels are represented.
/// </summary>
public enum DdsFourCc
{
#pragma warning disable CS1591
    Unknown = 0,

    Dx10 = 0x30315844,

    Dxt1 = 0x31545844,
    Dxt2 = 0x32545844,
    Dxt3 = 0x33545844,
    Dxt4 = 0x34545844,
    Dxt5 = 0x35545844,
    Ati1 = 0x31495441,
    Ati2 = 0x32495441,
    Atc = 0x20435441,
    AtcI = 0x49435441,
    AtcA = 0x41435441,

    Bc1 = Dxt1,
    Bc2 = Dxt3,
    Bc3 = Dxt5,
    Bc4 = Ati1,
    Bc4S = 0x53344342,
    Bc4U = 0x55344342,
    Bc5 = Ati2,
    Bc5S = 0x53354342,
    Bc5U = 0x55354342,

    // https://github.com/microsoft/DirectXTK/wiki/DDSTextureLoader

    D3dFmtR8G8B8 = 20,
    D3dFmtA8R8G8B8 = 21,
    D3dFmtX8R8G8B8 = 22,
    D3dFmtR5G6B5 = 23,
    D3dFmtX1R5G5B5 = 24,
    D3dFmtA1R5G5B5 = 25,
    D3dFmtA4R4G4B4 = 26,
    D3dFmtR3G3B2 = 27,
    D3dFmtA8 = 28,
    D3dFmtA8R3G3B2 = 29,
    D3dFmtX4R4G4B4 = 30,
    D3dFmtA2B10G10R10 = 31,
    D3dFmtA8B8G8R8 = 32,
    D3dFmtX8B8G8R8 = 33,
    D3dFmtG16R16 = 34,
    D3dFmtA2R10G10B10 = 35,
    D3dFmtA16B16G16R16 = 36,

    D3dFmtA8P8 = 40,
    D3dFmtP8 = 41,

    D3dFmtL8 = 50,
    D3dFmtA8L8 = 51,
    D3dFmtA4L4 = 52,

    D3dFmtV8U8 = 60,
    D3dFmtL6V5U5 = 61,
    D3dFmtX8L8V8U8 = 62,
    D3dFmtQ8W8V8U8 = 63,
    D3dFmtV16U16 = 64,
    D3dFmtA2W10V10U10 = 67,

    D3dFmtUyvy = 0x59565955,
    D3dFmtR8G8B8G8 = 0x47424752,
    D3dFmtYuy2 = 0x32595559,
    D3dFmtG8R8G8B8 = 0x42475247,

    D3dFmtD16Lockable = 70,
    D3dFmtD32 = 71,
    D3dFmtD15S1 = 73,
    D3dFmtD24S8 = 75,
    D3dFmtD24X8 = 77,
    D3dFmtD24X4S4 = 79,
    D3dFmtD16 = 80,

    D3dFmtD32FLockable = 82,
    D3dFmtD24Fs8 = 83,

    D3dFmtD32Lockable = 84,
    D3dFmtS8Lockable = 85,

    D3dFmtL16 = 81,

    D3dFmtVertexdata = 100,
    D3dFmtIndex16 = 101,
    D3dFmtIndex32 = 102,

    D3dFmtQ16W16V16U16 = 110,

    D3dFmtMulti2Argb8 = 0x3154454D,

    D3dFmtR16F = 111,
    D3dFmtG16R16F = 112,
    D3dFmtA16B16G16R16F = 113,

    D3dFmtR32F = 114,
    D3dFmtG32R32F = 115,
    D3dFmtA32B32G32R32F = 116,

    D3dFmtCxV8U8 = 117,

    D3dFmtA1 = 118,
    D3dFmtA2B10G10R10XrBias = 119,
    D3dFmtBinarybuffer = 199,
#pragma warning restore CS1591
}