using System;
using System.Numerics;
using Lumina.Text.Expressions;
using Lumina.Text.Payloads;

namespace Lumina.Text;

/// <summary>A builder for <see cref="SeString"/>.</summary>
public sealed partial class SeStringBuilder
{
    /// <summary>Appends a BGRA integer calculated from RGBA values as an expression.</summary>
    /// <param name="rgba">A normalized RGBA <see cref="System.Numerics.Vector4"/> value to append.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    /// <remarks>See <a href="https://learn.microsoft.com/en-us/windows/win32/wic/-wic-codec-native-pixel-formats#rgbbgr-color-model">RGB/BGR color model</a>
    /// if the naming gets confusing.</remarks>
    public SeStringBuilder AppendBgraIntExpressionFromRgba( Vector4 rgba ) => AppendBgraIntExpression( rgba with { X = rgba.Z, Z = rgba.X } );

    /// <summary>Appends a BGRA integer calculated from RGBA values as an expression.</summary>
    /// <param name="r">A red byte value to append.</param>
    /// <param name="g">A green byte value to append.</param>
    /// <param name="b">A blue byte value to append.</param>
    /// <param name="a">A alpha byte value to append.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    /// <remarks>See <a href="https://learn.microsoft.com/en-us/windows/win32/wic/-wic-codec-native-pixel-formats#rgbbgr-color-model">RGB/BGR color model</a>
    /// if the naming gets confusing.</remarks>
    public SeStringBuilder AppendBgraIntExpressionFromRgba( byte r, byte g, byte b, byte a ) => AppendBgraIntExpression( b, g, r, a );

    /// <summary>Appends a BGRA integer calculated from RGBA values as an expression.</summary>
    /// <param name="rgba">The RGBA color value, which is 0xAABBGGRR (0xRR 0xGG 0xBB 0xAA) on Windows version.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    /// <remarks>See <a href="https://learn.microsoft.com/en-us/windows/win32/wic/-wic-codec-native-pixel-formats#rgbbgr-color-model">RGB/BGR color model</a>
    /// if the naming gets confusing.</remarks>
    public SeStringBuilder AppendBgraIntExpressionFromRgba( uint rgba ) =>
        AppendUIntExpression( ( rgba & 0xFF00FF00 ) | ( ( rgba >> 16 ) & 0xFF ) | ( ( rgba & 0xFF ) << 16 ) );

    /// <summary>Appends a BGRA integer calculated from BGRA values as an expression.</summary>
    /// <param name="rgba">A normalized RGBA <see cref="System.Numerics.Vector4"/> value to append.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    /// <remarks>See <a href="https://learn.microsoft.com/en-us/windows/win32/wic/-wic-codec-native-pixel-formats#rgbbgr-color-model">RGB/BGR color model</a>
    /// if the naming gets confusing.</remarks>
    public SeStringBuilder AppendBgraIntExpression( Vector4 rgba ) =>
        AppendBgraIntExpression(
            (byte) Math.Clamp( 256 * rgba.X, 0, 255 ),
            (byte) Math.Clamp( 256 * rgba.Y, 0, 255 ),
            (byte) Math.Clamp( 256 * rgba.Z, 0, 255 ),
            (byte) Math.Clamp( 256 * rgba.W, 0, 255 ) );

    /// <summary>Appends a BGRA integer calculated from BGRA values as an expression.</summary>
    /// <param name="b">A blue byte value to append.</param>
    /// <param name="g">A green byte value to append.</param>
    /// <param name="r">A red byte value to append.</param>
    /// <param name="a">A alpha byte value to append.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    /// <remarks>See <a href="https://learn.microsoft.com/en-us/windows/win32/wic/-wic-codec-native-pixel-formats#rgbbgr-color-model">RGB/BGR color model</a>
    /// if the naming gets confusing.</remarks>
    public SeStringBuilder AppendBgraIntExpression( byte b, byte g, byte r, byte a ) =>
        AppendUIntExpression( ( (uint) a << 24 ) | ( (uint) r << 16 ) | ( (uint) g << 8 ) | b );

    /// <summary>Pushes a text foreground color.</summary>
    /// <param name="b">A blue byte value to append.</param>
    /// <param name="g">A green byte value to append.</param>
    /// <param name="r">A red byte value to append.</param>
    /// <param name="a">A alpha byte value to append.</param>
    /// <returns>A reference of this instance after the push operation is completed.</returns>
    /// <remarks>See <a href="https://learn.microsoft.com/en-us/windows/win32/wic/-wic-codec-native-pixel-formats#rgbbgr-color-model">RGB/BGR color model</a>
    /// if the naming gets confusing.</remarks>
    public SeStringBuilder PushColorBgra( byte b, byte g, byte r, byte a ) =>
        BeginMacro( MacroCode.Color ).AppendBgraIntExpression( b, g, r, a ).EndMacro();

    /// <summary>Pushes a text foreground color.</summary>
    /// <param name="bgra">The BGRA color value, which is 0xAARRGGBB (0xBB 0xGG 0xRR 0xAA) on Windows version.</param>
    /// <returns>A reference of this instance after the push operation is completed.</returns>
    /// <remarks>See <a href="https://learn.microsoft.com/en-us/windows/win32/wic/-wic-codec-native-pixel-formats#rgbbgr-color-model">RGB/BGR color model</a>
    /// if the naming gets confusing.</remarks>
    public SeStringBuilder PushColorBgra( uint bgra ) =>
        BeginMacro( MacroCode.Color ).AppendUIntExpression( bgra ).EndMacro();

    /// <summary>Pushes a text foreground color.</summary>
    /// <param name="bgra">The BGRA color value, which is 0xAARRGGBB (0xBB 0xGG 0xRR 0xAA) on Windows version.</param>
    /// <returns>A reference of this instance after the push operation is completed.</returns>
    /// <remarks>See <a href="https://learn.microsoft.com/en-us/windows/win32/wic/-wic-codec-native-pixel-formats#rgbbgr-color-model">RGB/BGR color model</a>
    /// if the naming gets confusing.</remarks>
    public SeStringBuilder PushColorBgra( Vector4 bgra ) =>
        BeginMacro( MacroCode.Color ).AppendBgraIntExpression( bgra ).EndMacro();

    /// <summary>Pushes a text foreground color.</summary>
    /// <param name="r">A red byte value to append.</param>
    /// <param name="g">A green byte value to append.</param>
    /// <param name="b">A blue byte value to append.</param>
    /// <param name="a">A alpha byte value to append.</param>
    /// <returns>A reference of this instance after the push operation is completed.</returns>
    /// <remarks>See <a href="https://learn.microsoft.com/en-us/windows/win32/wic/-wic-codec-native-pixel-formats#rgbbgr-color-model">RGB/BGR color model</a>
    /// if the naming gets confusing.</remarks>
    public SeStringBuilder PushColorRgba( byte r, byte g, byte b, byte a ) =>
        BeginMacro( MacroCode.Color ).AppendBgraIntExpressionFromRgba( r, g, b, a ).EndMacro();

    /// <summary>Pushes a text foreground color.</summary>
    /// <param name="rgba">The RGBA color value, which is 0xAABBGGRR (0xRR 0xGG 0xBB 0xAA) on Windows version.</param>
    /// <returns>A reference of this instance after the push operation is completed.</returns>
    /// <remarks>See <a href="https://learn.microsoft.com/en-us/windows/win32/wic/-wic-codec-native-pixel-formats#rgbbgr-color-model">RGB/BGR color model</a>
    /// if the naming gets confusing.</remarks>
    public SeStringBuilder PushColorRgba( uint rgba ) =>
        BeginMacro( MacroCode.Color ).AppendBgraIntExpressionFromRgba( rgba ).EndMacro();

    /// <summary>Pushes a text foreground color.</summary>
    /// <param name="rgba">The RGBA color value, which is 0xAABBGGRR (0xRR 0xGG 0xBB 0xAA) on Windows version.</param>
    /// <returns>A reference of this instance after the push operation is completed.</returns>
    /// <remarks>See <a href="https://learn.microsoft.com/en-us/windows/win32/wic/-wic-codec-native-pixel-formats#rgbbgr-color-model">RGB/BGR color model</a>
    /// if the naming gets confusing.</remarks>
    public SeStringBuilder PushColorRgba( Vector4 rgba ) =>
        BeginMacro( MacroCode.Color ).AppendBgraIntExpressionFromRgba( rgba ).EndMacro();

    /// <summary>Pops a text foreground color.</summary>
    /// <returns>A reference of this instance after the pop operation is completed.</returns>
    public SeStringBuilder PopColor() =>
        BeginMacro( MacroCode.Color ).AppendNullaryExpression( ExpressionType.StackColor ).EndMacro();

    /// <summary>Pushes a text edge color.</summary>
    /// <param name="b">A blue byte value to append.</param>
    /// <param name="g">A green byte value to append.</param>
    /// <param name="r">A red byte value to append.</param>
    /// <param name="a">A alpha byte value to append.</param>
    /// <returns>A reference of this instance after the push operation is completed.</returns>
    /// <remarks>See <a href="https://learn.microsoft.com/en-us/windows/win32/wic/-wic-codec-native-pixel-formats#rgbbgr-color-model">RGB/BGR color model</a>
    /// if the naming gets confusing.</remarks>
    public SeStringBuilder PushEdgeColorBgra( byte b, byte g, byte r, byte a ) =>
        BeginMacro( MacroCode.EdgeColor ).AppendBgraIntExpression( b, g, r, a ).EndMacro();

    /// <summary>Pushes a text edge color.</summary>
    /// <param name="bgra">The BGRA color value, which is 0xAARRGGBB (0xBB 0xGG 0xRR 0xAA) on Windows version.</param>
    /// <returns>A reference of this instance after the push operation is completed.</returns>
    /// <remarks>See <a href="https://learn.microsoft.com/en-us/windows/win32/wic/-wic-codec-native-pixel-formats#rgbbgr-color-model">RGB/BGR color model</a>
    /// if the naming gets confusing.</remarks>
    public SeStringBuilder PushEdgeColorBgra( uint bgra ) =>
        BeginMacro( MacroCode.EdgeColor ).AppendUIntExpression( bgra ).EndMacro();

    /// <summary>Pushes a text edge color.</summary>
    /// <param name="bgra">The BGRA color value, which is 0xAARRGGBB (0xBB 0xGG 0xRR 0xAA) on Windows version.</param>
    /// <returns>A reference of this instance after the push operation is completed.</returns>
    /// <remarks>See <a href="https://learn.microsoft.com/en-us/windows/win32/wic/-wic-codec-native-pixel-formats#rgbbgr-color-model">RGB/BGR color model</a>
    /// if the naming gets confusing.</remarks>
    public SeStringBuilder PushEdgeColorBgra( Vector4 bgra ) =>
        BeginMacro( MacroCode.EdgeColor ).AppendBgraIntExpression( bgra ).EndMacro();

    /// <summary>Pushes a text edge color.</summary>
    /// <param name="r">A red byte value to append.</param>
    /// <param name="g">A green byte value to append.</param>
    /// <param name="b">A blue byte value to append.</param>
    /// <param name="a">A alpha byte value to append.</param>
    /// <returns>A reference of this instance after the push operation is completed.</returns>
    /// <remarks>See <a href="https://learn.microsoft.com/en-us/windows/win32/wic/-wic-codec-native-pixel-formats#rgbbgr-color-model">RGB/BGR color model</a>
    /// if the naming gets confusing.</remarks>
    public SeStringBuilder PushEdgeColorRgba( byte r, byte g, byte b, byte a ) =>
        BeginMacro( MacroCode.EdgeColor ).AppendBgraIntExpressionFromRgba( r, g, b, a ).EndMacro();

    /// <summary>Pushes a text edge color.</summary>
    /// <param name="rgba">The RGBA color value, which is 0xAABBGGRR (0xRR 0xGG 0xBB 0xAA) on Windows version.</param>
    /// <returns>A reference of this instance after the push operation is completed.</returns>
    /// <remarks>See <a href="https://learn.microsoft.com/en-us/windows/win32/wic/-wic-codec-native-pixel-formats#rgbbgr-color-model">RGB/BGR color model</a>
    /// if the naming gets confusing.</remarks>
    public SeStringBuilder PushEdgeColorRgba( uint rgba ) =>
        BeginMacro( MacroCode.EdgeColor ).AppendBgraIntExpressionFromRgba( rgba ).EndMacro();

    /// <summary>Pushes a text edge color.</summary>
    /// <param name="rgba">The RGBA color value, which is 0xAABBGGRR (0xRR 0xGG 0xBB 0xAA) on Windows version.</param>
    /// <returns>A reference of this instance after the push operation is completed.</returns>
    /// <remarks>See <a href="https://learn.microsoft.com/en-us/windows/win32/wic/-wic-codec-native-pixel-formats#rgbbgr-color-model">RGB/BGR color model</a>
    /// if the naming gets confusing.</remarks>
    public SeStringBuilder PushEdgeColorRgba( Vector4 rgba ) =>
        BeginMacro( MacroCode.EdgeColor ).AppendBgraIntExpressionFromRgba( rgba ).EndMacro();

    /// <summary>Pops a text border color.</summary>
    /// <returns>A reference of this instance after the pop operation is completed.</returns>
    public SeStringBuilder PopEdgeColor() =>
        BeginMacro( MacroCode.EdgeColor ).AppendNullaryExpression( ExpressionType.StackColor ).EndMacro();

    /// <summary>Pushes a text shadow color.</summary>
    /// <param name="b">A blue byte value to append.</param>
    /// <param name="g">A green byte value to append.</param>
    /// <param name="r">A red byte value to append.</param>
    /// <param name="a">A alpha byte value to append.</param>
    /// <returns>A reference of this instance after the push operation is completed.</returns>
    /// <remarks>See <a href="https://learn.microsoft.com/en-us/windows/win32/wic/-wic-codec-native-pixel-formats#rgbbgr-color-model">RGB/BGR color model</a>
    /// if the naming gets confusing.</remarks>
    public SeStringBuilder PushShadowColorBgra( byte b, byte g, byte r, byte a ) =>
        BeginMacro( MacroCode.ShadowColor ).AppendBgraIntExpression( b, g, r, a ).EndMacro();

    /// <summary>Pushes a text shadow color.</summary>
    /// <param name="bgra">The BGRA color value, which is 0xAARRGGBB (0xBB 0xGG 0xRR 0xAA) on Windows version.</param>
    /// <returns>A reference of this instance after the push operation is completed.</returns>
    /// <remarks>See <a href="https://learn.microsoft.com/en-us/windows/win32/wic/-wic-codec-native-pixel-formats#rgbbgr-color-model">RGB/BGR color model</a>
    /// if the naming gets confusing.</remarks>
    public SeStringBuilder PushShadowColorBgra( uint bgra ) =>
        BeginMacro( MacroCode.ShadowColor ).AppendUIntExpression( bgra ).EndMacro();

    /// <summary>Pushes a text shadow color.</summary>
    /// <param name="bgra">The BGRA color value, which is 0xAARRGGBB (0xBB 0xGG 0xRR 0xAA) on Windows version.</param>
    /// <returns>A reference of this instance after the push operation is completed.</returns>
    /// <remarks>See <a href="https://learn.microsoft.com/en-us/windows/win32/wic/-wic-codec-native-pixel-formats#rgbbgr-color-model">RGB/BGR color model</a>
    /// if the naming gets confusing.</remarks>
    public SeStringBuilder PushShadowColorBgra( Vector4 bgra ) =>
        BeginMacro( MacroCode.ShadowColor ).AppendBgraIntExpression( bgra ).EndMacro();

    /// <summary>Pushes a text shadow color.</summary>
    /// <param name="r">A red byte value to append.</param>
    /// <param name="g">A green byte value to append.</param>
    /// <param name="b">A blue byte value to append.</param>
    /// <param name="a">A alpha byte value to append.</param>
    /// <returns>A reference of this instance after the push operation is completed.</returns>
    /// <remarks>See <a href="https://learn.microsoft.com/en-us/windows/win32/wic/-wic-codec-native-pixel-formats#rgbbgr-color-model">RGB/BGR color model</a>
    /// if the naming gets confusing.</remarks>
    public SeStringBuilder PushShadowColorRgba( byte r, byte g, byte b, byte a ) =>
        BeginMacro( MacroCode.ShadowColor ).AppendBgraIntExpressionFromRgba( r, g, b, a ).EndMacro();

    /// <summary>Pushes a text shadow color.</summary>
    /// <param name="rgba">The RGBA color value, which is 0xAABBGGRR (0xRR 0xGG 0xBB 0xAA) on Windows version.</param>
    /// <returns>A reference of this instance after the push operation is completed.</returns>
    /// <remarks>See <a href="https://learn.microsoft.com/en-us/windows/win32/wic/-wic-codec-native-pixel-formats#rgbbgr-color-model">RGB/BGR color model</a>
    /// if the naming gets confusing.</remarks>
    public SeStringBuilder PushShadowColorRgba( uint rgba ) =>
        BeginMacro( MacroCode.ShadowColor ).AppendBgraIntExpressionFromRgba( rgba ).EndMacro();

    /// <summary>Pushes a text shadow color.</summary>
    /// <param name="rgba">The RGBA color value, which is 0xAABBGGRR (0xRR 0xGG 0xBB 0xAA) on Windows version.</param>
    /// <returns>A reference of this instance after the push operation is completed.</returns>
    /// <remarks>See <a href="https://learn.microsoft.com/en-us/windows/win32/wic/-wic-codec-native-pixel-formats#rgbbgr-color-model">RGB/BGR color model</a>
    /// if the naming gets confusing.</remarks>
    public SeStringBuilder PushShadowColorRgba( Vector4 rgba ) =>
        BeginMacro( MacroCode.ShadowColor ).AppendBgraIntExpressionFromRgba( rgba ).EndMacro();

    /// <summary>Pops a text shadow color.</summary>
    /// <returns>A reference of this instance after the pop operation is completed.</returns>
    public SeStringBuilder PopShadowColor() =>
        BeginMacro( MacroCode.ShadowColor ).AppendNullaryExpression( ExpressionType.StackColor ).EndMacro();
}