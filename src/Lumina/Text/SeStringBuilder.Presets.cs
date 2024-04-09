using System;
using Lumina.Text.Expressions;
using Lumina.Text.Payloads;
using Lumina.Text.ReadOnly;

namespace Lumina.Text;

/// <summary>A builder for <see cref="SeString"/>.</summary>
public sealed partial class SeStringBuilder
{
    /// <summary>Appends a local number unary expression.</summary>
    /// <param name="id">The value ID.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder AppendLocalNumberExpression( int id ) =>
        BeginUnaryExpression( ExpressionType.LocalNumber ).AppendIntExpression( id ).EndExpression();

    /// <summary>Appends a local string unary expression.</summary>
    /// <param name="id">The value ID.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder AppendLocalStringExpression( int id ) =>
        BeginUnaryExpression( ExpressionType.LocalString ).AppendIntExpression( id ).EndExpression();

    /// <summary>Appends a global number unary expression.</summary>
    /// <param name="id">The value ID.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder AppendGlobalNumberExpression( int id ) =>
        BeginUnaryExpression( ExpressionType.GlobalNumber ).AppendIntExpression( id ).EndExpression();

    /// <summary>Appends a global string unary expression.</summary>
    /// <param name="id">The value ID.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder AppendGlobalStringExpression( int id ) =>
        BeginUnaryExpression( ExpressionType.GlobalString ).AppendIntExpression( id ).EndExpression();

    /// <summary>Appends a string expression.</summary>
    /// <param name="rosss">The value.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder AppendStringExpression( ReadOnlySeStringSpan rosss ) =>
        BeginStringExpression().Append( rosss ).EndExpression();

    /// <summary>Appends a string expression.</summary>
    /// <param name="str">The value.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder AppendStringExpression( ReadOnlySpan<char> str ) =>
        BeginStringExpression().Append( str ).EndExpression();

    /// <summary>Appends an icon.</summary>
    /// <param name="icon">The icon ID.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder AppendIcon( uint icon ) =>
        BeginMacro( MacroCode.Icon ).AppendUIntExpression( icon ).EndMacro();

    /// <summary>Appends an italicized text.</summary>
    /// <param name="rosss">The string to append italicized.</param>
    /// <returns></returns>
    public SeStringBuilder AppendItalicized( ReadOnlySeStringSpan rosss ) =>
        AppendSetItalic( true ).Append( rosss ).AppendSetItalic( false );

    /// <summary>Appends an italicized text.</summary>
    /// <param name="str">The string to append italicized.</param>
    /// <returns></returns>
    public SeStringBuilder AppendItalicized( ReadOnlySpan< char > str ) =>
        AppendSetItalic( true ).Append( str ).AppendSetItalic( false );

    /// <summary>Appends a payload to either turn italic on or off.</summary>
    /// <param name="enable">Whether to enable italics.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder AppendSetItalic( bool enable ) =>
        BeginMacro( MacroCode.Italic ).AppendUIntExpression( enable ? 1u : 0u ).EndMacro();

    /// <summary>Appends a bold text.</summary>
    /// <param name="rosss">The string to append italicized.</param>
    /// <returns></returns>
    public SeStringBuilder AppendBold( ReadOnlySeStringSpan rosss ) =>
        AppendSetBold( true ).Append( rosss ).AppendSetBold( false );

    /// <summary>Appends a bold text.</summary>
    /// <param name="str">The string to append italicized.</param>
    /// <returns></returns>
    public SeStringBuilder AppendBold( ReadOnlySpan< char > str ) =>
        AppendSetBold( true ).Append( str ).AppendSetBold( false );

    /// <summary>Appends a payload to either bold italic on or off.</summary>
    /// <param name="enable">Whether to enable bold.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder AppendSetBold( bool enable ) =>
        BeginMacro( MacroCode.Bold ).AppendUIntExpression( enable ? 1u : 0u ).EndMacro();

    /// <summary>Pushes a text foreground color.</summary>
    /// <param name="rgba">The RGBA color value.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder PushColor( uint rgba ) =>
        BeginMacro( MacroCode.Color ).AppendUIntExpression( rgba ).EndMacro();

    /// <summary>Pops a text foreground color.</summary>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder PopColor() =>
        BeginMacro( MacroCode.Color ).AppendNullaryExpression( ExpressionType.StackColor ).EndMacro();

    /// <summary>Pushes a text border color.</summary>
    /// <param name="rgba">The RGBA color value.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder PushEdgeColor( uint rgba ) =>
        BeginMacro( MacroCode.EdgeColor ).AppendUIntExpression( rgba ).EndMacro();

    /// <summary>Pops a text border color.</summary>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder PopEdgeColor() =>
        BeginMacro( MacroCode.EdgeColor ).AppendNullaryExpression( ExpressionType.StackColor ).EndMacro();

    /// <summary>Pushes a text shadow color.</summary>
    /// <param name="rgba">The RGBA color value.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder PushShadowColor( uint rgba ) =>
        BeginMacro( MacroCode.ShadowColor ).AppendUIntExpression( rgba ).EndMacro();

    /// <summary>Pops a text shadow color.</summary>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder PopShadowColor() =>
        BeginMacro( MacroCode.ShadowColor ).AppendNullaryExpression( ExpressionType.StackColor ).EndMacro();

    /// <summary>Pushes a text foreground color from UIColor sheet.</summary>
    /// <param name="uiColorRowId">The row ID in the UIColor sheet.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder PushColorType( uint uiColorRowId ) =>
        BeginMacro( MacroCode.ColorType ).AppendUIntExpression( uiColorRowId ).EndMacro();

    /// <summary>Pops a text foreground color pushed with <see cref="PushColorType"/>.</summary>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder PopColorType() => PushColorType( 0u );

    /// <summary>Pushes a text border color from UIColor sheet.</summary>
    /// <param name="uiColorRowId">The row ID in the UIColor sheet.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder PushEdgeColorType( uint uiColorRowId ) =>
        BeginMacro( MacroCode.EdgeColorType ).AppendUIntExpression( uiColorRowId ).EndMacro();

    /// <summary>Pops a text border color pushed with <see cref="PushEdgeColorType"/>.</summary>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder PopEdgeColorType() => PushEdgeColorType( 0u );
}