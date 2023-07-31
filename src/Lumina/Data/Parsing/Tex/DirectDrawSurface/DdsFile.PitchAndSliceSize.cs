using System;

namespace Lumina.Data.Parsing.Tex.DirectDrawSurface;

public partial class DdsFile
{
    /// <summary>
    /// Get the pitch(stride) and slice size of the specified mipmap in this file.
    /// </summary>
    /// <param name="mipmapIndex">Index of the mipmap.</param>
    /// <param name="pitch">Calculated pitch.</param>
    /// <param name="sliceSize">Calculated slice size.</param>
    /// <returns>Whether the operation has succeeded.</returns>
    public bool PitchAndSliceSize( int mipmapIndex, out int pitch, out int sliceSize )
    {
        pitch = sliceSize = 0;

        var w = Width( mipmapIndex );
        var h = Height( mipmapIndex );
        if( !Header.PixelFormat.Flags.HasFlag( DdsPixelFormatFlags.FourCc ) )
        {
            if( 0 == ( Header.PixelFormat.Flags & DdsPixelFormatFlags.ValidRgbBitCountFieldMask ) )
                return false;
            pitch = ( w * Header.PixelFormat.RgbBitCount + 7 ) / 8;
            sliceSize = pitch * h;
            return true;
        }

        switch( Header.PixelFormat.FourCc )
        {
            case DdsFourCc.Dxt1:
            case DdsFourCc.Bc4S:
            case DdsFourCc.Bc4U:
            {
                var nbw = Math.Max( 1, ( w + 3 ) / 4 );
                var nbh = Math.Max( 1, ( h + 3 ) / 4 );
                pitch = nbw * 8;
                sliceSize = pitch * nbh;
                return true;
            }
            case DdsFourCc.Dxt2:
            case DdsFourCc.Dxt3:
            case DdsFourCc.Dxt4:
            case DdsFourCc.Dxt5:
            case DdsFourCc.Ati1:
            case DdsFourCc.Ati2:
            case DdsFourCc.Atc:
            case DdsFourCc.AtcI:
            case DdsFourCc.AtcA:
            case DdsFourCc.Bc5S:
            case DdsFourCc.Bc5U:
            {
                var nbw = Math.Max( 1, ( w + 3 ) / 4 );
                var nbh = Math.Max( 1, ( h + 3 ) / 4 );
                pitch = nbw * 16;
                sliceSize = pitch * nbh;
                return true;
            }
            case DdsFourCc.D3dFmtR8G8B8G8:
            case DdsFourCc.D3dFmtG8R8G8B8:
            case DdsFourCc.D3dFmtUyvy:
            case DdsFourCc.D3dFmtYuy2:
                pitch = ( ( w + 1 ) >> 1 ) * 4;
                sliceSize = pitch * h;
                return true;
            case DdsFourCc.Dx10:

                // https://github.com/microsoft/DirectXTex/blob/4d9d7a8ceba6d6a121cd1aae160a0b856ef03d89/DirectXTex/DirectXTexUtil.cpp#L919
                int bpp;
                switch( HeaderDxt10.DxgiFormat )
                {
                    case DxgiFormat.Bc1Typeless:
                    case DxgiFormat.Bc1Unorm:
                    case DxgiFormat.Bc1UnormSrgb:
                    case DxgiFormat.Bc4Typeless:
                    case DxgiFormat.Bc4Unorm:
                    case DxgiFormat.Bc4Snorm:
                    {
                        var nbw = Math.Max( 1, ( w + 3 ) / 4 );
                        var nbh = Math.Max( 1, ( h + 3 ) / 4 );
                        pitch = nbw * 8;
                        sliceSize = pitch * nbh;
                        return true;
                    }
                    case DxgiFormat.Bc2Typeless:
                    case DxgiFormat.Bc2Unorm:
                    case DxgiFormat.Bc2UnormSrgb:
                    case DxgiFormat.Bc3Typeless:
                    case DxgiFormat.Bc3Unorm:
                    case DxgiFormat.Bc3UnormSrgb:
                    case DxgiFormat.Bc5Typeless:
                    case DxgiFormat.Bc5Unorm:
                    case DxgiFormat.Bc5Snorm:
                    case DxgiFormat.Bc6HTypeless:
                    case DxgiFormat.Bc6HUf16:
                    case DxgiFormat.Bc6HSf16:
                    case DxgiFormat.Bc7Typeless:
                    case DxgiFormat.Bc7Unorm:
                    case DxgiFormat.Bc7UnormSrgb:
                    {
                        var nbw = Math.Max( 1, ( w + 3 ) / 4 );
                        var nbh = Math.Max( 1, ( h + 3 ) / 4 );
                        pitch = nbw * 16;
                        sliceSize = pitch * nbh;
                        return true;
                    }
                    case DxgiFormat.R8G8B8G8Unorm:
                    case DxgiFormat.G8R8G8B8Unorm:
                    case DxgiFormat.Yuy2:
                        pitch = ( ( w + 1 ) >> 1 ) * 4;
                        sliceSize = pitch * h;
                        return true;
                    case DxgiFormat.Y210:
                    case DxgiFormat.Y216:
                        pitch = ( ( w + 1 ) >> 1 ) * 8;
                        sliceSize = pitch * h;
                        return true;
                    case DxgiFormat.Nv12:
                    case DxgiFormat.Yuv420Opaque:
                        if( h % 2 != 0 )
                            return false;
                        pitch = ( ( w + 1 ) >> 1 ) * 2;
                        sliceSize = pitch * ( h + ( ( h + 1 ) >> 1 ) );
                        return true;
                    case DxgiFormat.P010:
                    case DxgiFormat.P016:
                        if( h % 2 != 0 )
                            return false;
                        goto case DxgiFormat.D16UnormS8Uint;
                    case DxgiFormat.D16UnormS8Uint:
                    case DxgiFormat.R16UnormX8Typeless:
                    case DxgiFormat.X16TypelessG8Uint:
                        pitch = ( ( w + 1 ) >> 1 ) * 4;
                        sliceSize = pitch * ( h + ( ( h + 1 ) >> 1 ) );
                        return true;
                    case DxgiFormat.Nv11:
                        pitch = ( ( w + 3 ) >> 2 ) * 4;
                        sliceSize = pitch * h * 2;
                        return true;
                    case DxgiFormat.P208:
                        pitch = ( ( w + 1 ) >> 1 ) * 2;
                        sliceSize = pitch * h * 2;
                        return true;
                    case DxgiFormat.V208:
                        if( h % 2 != 0 )
                            return false;
                        pitch = w;
                        sliceSize = pitch * ( h + ( ( h + 1 ) >> 1 ) * 2 );
                        return true;
                    case DxgiFormat.V408:
                        pitch = w;
                        sliceSize = pitch * ( h + ( h >> 1 ) * 4 );
                        return true;
                    case DxgiFormat.R32G32B32A32Typeless:
                    case DxgiFormat.R32G32B32A32Float:
                    case DxgiFormat.R32G32B32A32Uint:
                    case DxgiFormat.R32G32B32A32Sint:
                        bpp = 128;
                        break;
                    case DxgiFormat.R32G32B32Typeless:
                    case DxgiFormat.R32G32B32Float:
                    case DxgiFormat.R32G32B32Uint:
                    case DxgiFormat.R32G32B32Sint:
                        bpp = 96;
                        break;
                    case DxgiFormat.R16G16B16A16Typeless:
                    case DxgiFormat.R16G16B16A16Float:
                    case DxgiFormat.R16G16B16A16Unorm:
                    case DxgiFormat.R16G16B16A16Uint:
                    case DxgiFormat.R16G16B16A16Snorm:
                    case DxgiFormat.R16G16B16A16Sint:
                    case DxgiFormat.R32G32Typeless:
                    case DxgiFormat.R32G32Float:
                    case DxgiFormat.R32G32Uint:
                    case DxgiFormat.R32G32Sint:
                    case DxgiFormat.R32G8X24Typeless:
                    case DxgiFormat.D32FloatS8X24Uint:
                    case DxgiFormat.R32FloatX8X24Typeless:
                    case DxgiFormat.X32TypelessG8X24Uint:
                    case DxgiFormat.Y416:
                        bpp = 64;
                        break;
                    case DxgiFormat.R10G10B10A2Typeless:
                    case DxgiFormat.R10G10B10A2Unorm:
                    case DxgiFormat.R10G10B10A2Uint:
                    case DxgiFormat.R11G11B10Float:
                    case DxgiFormat.R8G8B8A8Typeless:
                    case DxgiFormat.R8G8B8A8Unorm:
                    case DxgiFormat.R8G8B8A8UnormSrgb:
                    case DxgiFormat.R8G8B8A8Uint:
                    case DxgiFormat.R8G8B8A8Snorm:
                    case DxgiFormat.R8G8B8A8Sint:
                    case DxgiFormat.R16G16Typeless:
                    case DxgiFormat.R16G16Float:
                    case DxgiFormat.R16G16Unorm:
                    case DxgiFormat.R16G16Uint:
                    case DxgiFormat.R16G16Snorm:
                    case DxgiFormat.R16G16Sint:
                    case DxgiFormat.R32Typeless:
                    case DxgiFormat.D32Float:
                    case DxgiFormat.R32Float:
                    case DxgiFormat.R32Uint:
                    case DxgiFormat.R32Sint:
                    case DxgiFormat.R24G8Typeless:
                    case DxgiFormat.D24UnormS8Uint:
                    case DxgiFormat.R24UnormX8Typeless:
                    case DxgiFormat.X24TypelessG8Uint:
                    case DxgiFormat.R9G9B9E5Sharedexp:
                    case DxgiFormat.B8G8R8A8Unorm:
                    case DxgiFormat.B8G8R8X8Unorm:
                    case DxgiFormat.R10G10B10XrBiasA2Unorm:
                    case DxgiFormat.B8G8R8A8Typeless:
                    case DxgiFormat.B8G8R8A8UnormSrgb:
                    case DxgiFormat.B8G8R8X8Typeless:
                    case DxgiFormat.B8G8R8X8UnormSrgb:
                    case DxgiFormat.Ayuv:
                    case DxgiFormat.Y410:
                    case DxgiFormat.R10G10B10_7E3_A2Float:
                    case DxgiFormat.R10G10B10_6E4_A2Float:
                    case DxgiFormat.R10G10B10SnormA2Unorm:
                        bpp = 32;
                        break;
                    case DxgiFormat.R8G8Typeless:
                    case DxgiFormat.R8G8Unorm:
                    case DxgiFormat.R8G8Uint:
                    case DxgiFormat.R8G8Snorm:
                    case DxgiFormat.R8G8Sint:
                    case DxgiFormat.R16Typeless:
                    case DxgiFormat.R16Float:
                    case DxgiFormat.D16Unorm:
                    case DxgiFormat.R16Unorm:
                    case DxgiFormat.R16Uint:
                    case DxgiFormat.R16Snorm:
                    case DxgiFormat.R16Sint:
                    case DxgiFormat.B5G6R5Unorm:
                    case DxgiFormat.B5G5R5A1Unorm:
                    case DxgiFormat.A8P8:
                    case DxgiFormat.B4G4R4A4Unorm:
                    case DxgiFormat.A4B4G4R4Unorm:
                        bpp = 16;
                        break;
                    case DxgiFormat.R8Typeless:
                    case DxgiFormat.R8Unorm:
                    case DxgiFormat.R8Uint:
                    case DxgiFormat.R8Snorm:
                    case DxgiFormat.R8Sint:
                    case DxgiFormat.A8Unorm:
                    case DxgiFormat.Ai44:
                    case DxgiFormat.Ia44:
                    case DxgiFormat.P8:
                    case DxgiFormat.R4G4Unorm:
                        bpp = 8;
                        break;
                    case DxgiFormat.R1Unorm:
                        bpp = 1;
                        break;
                    default:
                        return false;
                }

                pitch = bpp * ( w + 7 ) / 8;
                sliceSize = pitch * h;
                return true;
            default:
                return false;
        }
    }
}