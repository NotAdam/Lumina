using Lumina.Text.ReadOnly;
using System;
using System.Collections.Generic;

namespace Lumina.Excel.Rsv;

public class DictionaryRsvProvider : Dictionary<ReadOnlySeString, ReadOnlySeString>, IRsvProvider
{
    /// <inheritdoc/>
    public bool CanResolve( ReadOnlySeString rsvString ) =>
        rsvString.IsRsv() && ContainsKey( rsvString );

    /// <inheritdoc/>
    public ReadOnlySeString Resolve( ReadOnlySeString rsvString ) =>
        rsvString.IsRsv() ? this[rsvString] : throw new ArgumentException( "rsvString is not a valid RSV string", nameof( rsvString ) );

    /// <inheritdoc/>
    public ReadOnlySeString ResolveOrSelf( ReadOnlySeString rsvString ) =>
        ( rsvString.IsRsv() && TryGetValue( rsvString, out var replacedString ) ) ? replacedString : rsvString;

    /// <inheritdoc/>
    public ReadOnlySeString? TryResolve( ReadOnlySeString rsvString ) =>
        ( rsvString.IsRsv() && TryGetValue( rsvString, out var replacedString ) ) ? replacedString : default;
}
