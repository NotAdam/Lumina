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
    public SeStringBuilder AppendStringExpression( ReadOnlySpan< char > str ) =>
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

    /// <summary>Pushes a link.</summary>
    /// <param name="type">Type of the link.</param>
    /// <param name="arg1">The 1st argument.</param>
    /// <param name="arg2">The 2nd argument.</param>
    /// <param name="arg3">The 3rd argument.</param>
    /// <returns>A reference of this instance after the push operation is completed.</returns>
    /// <remarks>Nested link can be done, but only the outermost link will be handled by the game, as of patch 6.58.</remarks>
    public SeStringBuilder PushLink( LinkMacroPayloadType type, uint arg1, uint arg2, uint arg3 ) =>
        BeginMacro( MacroCode.Link )
            .AppendUIntExpression( (uint) type )
            .AppendUIntExpression( arg1 )
            .AppendUIntExpression( arg2 )
            .AppendUIntExpression( arg3 );

    /// <summary>Pushes a link.</summary>
    /// <param name="type">Type of the link.</param>
    /// <param name="arg1">The 1st argument.</param>
    /// <param name="arg2">The 2nd argument.</param>
    /// <param name="arg3">The 3rd argument.</param>
    /// <param name="displayName">The optional display name.</param>
    /// <returns>A reference of this instance after the push operation is completed.</returns>
    /// <remarks>Nested link can be done, but only the outermost link will be handled by the game, as of patch 6.58.</remarks>
    public SeStringBuilder PushLink( LinkMacroPayloadType type, uint arg1, uint arg2, uint arg3, ReadOnlySeStringSpan displayName ) =>
        BeginMacro( MacroCode.Link )
            .AppendUIntExpression( (uint) type )
            .AppendUIntExpression( arg1 )
            .AppendUIntExpression( arg2 )
            .AppendUIntExpression( arg3 )
            .AppendStringExpression( displayName );

    /// <summary>Pushes a link.</summary>
    /// <param name="type">Type of the link.</param>
    /// <param name="arg1">The 1st argument.</param>
    /// <param name="arg2">The 2nd argument.</param>
    /// <param name="arg3">The 3rd argument.</param>
    /// <param name="displayName">The optional display name.</param>
    /// <returns>A reference of this instance after the push operation is completed.</returns>
    /// <remarks>Nested link can be done, but only the outermost link will be handled by the game, as of patch 6.58.</remarks>
    public SeStringBuilder PushLink( LinkMacroPayloadType type, uint arg1, uint arg2, uint arg3, ReadOnlySpan< char > displayName ) =>
        BeginMacro( MacroCode.Link )
            .AppendUIntExpression( (uint) type )
            .AppendUIntExpression( arg1 )
            .AppendUIntExpression( arg2 )
            .AppendUIntExpression( arg3 )
            .AppendStringExpression( displayName );

    /// <summary>Pushes a link to a character.</summary>
    /// <param name="characterName">The name of the target player.</param>
    /// <param name="worldId">Optional world ID.</param>
    /// <returns>A reference of this instance after the push operation is completed.</returns>
    public SeStringBuilder PushLinkCharacter( ReadOnlySpan< char > characterName, uint worldId = 0u ) =>
        PushLink( LinkMacroPayloadType.Character, 0u, worldId, 0u, characterName );

    /// <summary>Pushes a link to an item.</summary>
    /// <param name="itemId">The item ID.</param>
    /// <returns>A reference of this instance after the push operation is completed.</returns>
    public SeStringBuilder PushLinkItem( uint itemId ) =>
        PushLink( LinkMacroPayloadType.Item, itemId, 1u, 0u );

    /// <summary>Pushes a link to an item.</summary>
    /// <param name="itemId">The item ID.</param>
    /// <param name="displayName">The display name.</param>
    /// <returns>A reference of this instance after the push operation is completed.</returns>
    public SeStringBuilder PushLinkItem( uint itemId, ReadOnlySpan< char > displayName ) =>
        PushLink( LinkMacroPayloadType.Item, itemId, 1u, 0u, displayName );

    /// <summary>Pushes a link to a map position.</summary>
    /// <param name="territoryId">The territory ID.</param>
    /// <param name="mapId">The map ID.</param>
    /// <param name="rawX">The raw X coordinate.</param>
    /// <param name="rawY">The raw Y coordinate.</param>
    /// <returns>A reference of this instance after the push operation is completed.</returns>
    public SeStringBuilder PushLinkMapPosition( uint territoryId, uint mapId, int rawX, int rawY )
    {
        if( territoryId > ushort.MaxValue )
            throw new ArgumentOutOfRangeException( nameof( territoryId ), territoryId, null );
        if( mapId > ushort.MaxValue )
            throw new ArgumentOutOfRangeException( nameof( mapId ), mapId, null );
        return PushLink(
            LinkMacroPayloadType.MapPosition,
            ( territoryId << 16 ) | mapId,
            unchecked( (uint) rawX ),
            unchecked( (uint) rawY ),
            default( ReadOnlySeStringSpan ) );
    }
    
    /// <summary>Pushes a link to a quest.</summary>
    /// <param name="questId">The quest ID.</param>
    /// <returns>A reference of this instance after the push operation is completed.</returns>
    public SeStringBuilder PushLinkQuest(uint questId) => PushLink( LinkMacroPayloadType.Quest, questId, 0u, 0u );

    /// <summary>Pushes a link to an achievement.</summary>
    /// <param name="achievementId">The achievement ID.</param>
    /// <returns>A reference of this instance after the push operation is completed.</returns>
    public SeStringBuilder PushLinkAchievement(uint achievementId) => PushLink( LinkMacroPayloadType.Achievement, achievementId, 0u, 0u );

    /// <summary>Pushes a link to a How-To entry.</summary>
    /// <param name="howToId">The How-To entry ID.</param>
    /// <returns>A reference of this instance after the push operation is completed.</returns>
    public SeStringBuilder PushLinkHowTo(uint howToId) => PushLink( LinkMacroPayloadType.HowTo, howToId, 0u, 0u );

    /// <summary>Pushes a link to the party finder dialog.</summary>
    /// <returns>A reference of this instance after the push operation is completed.</returns>
    public SeStringBuilder PushLinkPartyFinderNotification() => PushLink( LinkMacroPayloadType.PartyFinderNotification, 0u, 0u, 0u );

    /// <summary>Pushes a link to a status.</summary>
    /// <param name="statusId">The status ID.</param>
    /// <returns>A reference of this instance after the push operation is completed.</returns>
    public SeStringBuilder PushLinkStatus(uint statusId) => PushLink( LinkMacroPayloadType.Status, statusId, 0u, 0u, " "u8 );

    /// <summary>Pushes a link to a cross-world party finder listing entry.</summary>
    /// <param name="listingId">The party finder listing ID.</param>
    /// <param name="worldId">The party finder owner's world ID.</param>
    /// <returns>A reference of this instance after the push operation is completed.</returns>
    public SeStringBuilder PushLinkPartyFinderCrossWorld(uint listingId, uint worldId)
    {
        if( worldId > ushort.MaxValue )
            throw new ArgumentOutOfRangeException( nameof( worldId ), worldId, null );
        return PushLink( LinkMacroPayloadType.PartyFinder, listingId, 0u, worldId );
    }

    /// <summary>Pushes a link to a party finder listing entry.</summary>
    /// <param name="listingId">The party finder listing ID.</param>
    /// <returns>A reference of this instance after the push operation is completed.</returns>
    public SeStringBuilder PushLinkPartyFinder(uint listingId) => PushLink( LinkMacroPayloadType.PartyFinder, listingId, 0u, 0x10000u );

    /// <summary>Pushes a link to an AkatsukiNote entry.</summary>
    /// <param name="akatsukiNoteId">The AkatsukiNote entry ID.</param>
    /// <returns>A reference of this instance after the push operation is completed.</returns>
    public SeStringBuilder PushLinkAkatsukiNote(uint akatsukiNoteId) => PushLink( LinkMacroPayloadType.AkatsukiNote, akatsukiNoteId, 0u, 0u );

    /// <summary>Pops a link.</summary>
    /// <returns>A reference of this instance after the pop operation is completed.</returns>
    public SeStringBuilder PopLink() => PushLink( LinkMacroPayloadType.Terminator, 0, 0, 0, default( ReadOnlySeStringSpan ) );

    /// <summary>Pushes a text foreground color from UIColor sheet.</summary>
    /// <param name="uiColorRowId">The row ID in the UIColor sheet. Specifying <c>0</c> will pop the color.</param>
    /// <returns>A reference of this instance after the push operation is completed.</returns>
    /// <remarks>UIColor sheet contains color values as 0xRRGGBBAA (0xAA 0xBB 0xGG 0xRR), and should be treated as having ABGR pixel format.
    /// See <a href="https://learn.microsoft.com/en-us/windows/win32/wic/-wic-codec-native-pixel-formats#rgbbgr-color-model">RGB/BGR color model</a>
    /// if the naming gets confusing.</remarks>
    public SeStringBuilder PushColorType( uint uiColorRowId ) =>
        BeginMacro( MacroCode.ColorType ).AppendUIntExpression( uiColorRowId ).EndMacro();

    /// <summary>Pops a text foreground color pushed with <see cref="PushColorType"/>.</summary>
    /// <returns>A reference of this instance after the pop operation is completed.</returns>
    public SeStringBuilder PopColorType() => PushColorType( 0u );

    /// <summary>Pushes a text border color from UIColor sheet.</summary>
    /// <param name="uiColorRowId">The row ID in the UIColor sheet. Specifying <c>0</c> will pop the color.</param>
    /// <returns>A reference of this instance after the push operation is completed.</returns>
    /// <remarks>UIColor sheet contains color values as 0xRRGGBBAA (0xAA 0xBB 0xGG 0xRR), and should be treated as having ABGR pixel format.
    /// See <a href="https://learn.microsoft.com/en-us/windows/win32/wic/-wic-codec-native-pixel-formats#rgbbgr-color-model">RGB/BGR color model</a>
    /// if the naming gets confusing.</remarks>
    public SeStringBuilder PushEdgeColorType( uint uiColorRowId ) =>
        BeginMacro( MacroCode.EdgeColorType ).AppendUIntExpression( uiColorRowId ).EndMacro();

    /// <summary>Pops a text border color pushed with <see cref="PushEdgeColorType"/>.</summary>
    /// <returns>A reference of this instance after the pop operation is completed.</returns>
    public SeStringBuilder PopEdgeColorType() => PushEdgeColorType( 0u );
}