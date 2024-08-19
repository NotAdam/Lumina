using System;
using System.Runtime.CompilerServices;
using Lumina.Data;
using Lumina.Data.Files.Excel;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel;

/// <summary>An excel sheet of <see cref="ExcelVariant.Subrows"/> variant.</summary>
public abstract class BaseSubrowExcelSheet : BaseExcelSheet
{
    private protected BaseSubrowExcelSheet( ExcelModule module, Language requestedLanguage, string sheetName, uint? columnHash )
        : base( module, requestedLanguage, sheetName, columnHash, ExcelVariant.Subrows )
    {
        foreach( var f in OffsetLookupTable )
            TotalSubrowCount += f.SubrowCount;
    }

    /// <summary>
    /// The total number of subrows in this sheet across all rows.
    /// </summary>
    public int TotalSubrowCount { get; }

    /// <summary>
    /// Whether this sheet has a subrow with the given <paramref name="rowId"/> and <paramref name="subrowId"/>.
    /// </summary>
    /// <param name="rowId">The row id to check.</param>
    /// <param name="subrowId">The subrow id to check.</param>
    /// <returns>Whether the subrow exists.</returns>
    public bool HasSubrow( uint rowId, ushort subrowId )
    {
        ref readonly var lookup = ref GetRowLookupOrNullRef( rowId );
        return !Unsafe.IsNullRef( in lookup ) && subrowId < lookup.SubrowCount;
    }

    /// <summary>
    /// Tries to get the number of subrows in the <paramref name="rowId"/>th row in this sheet.
    /// </summary>
    /// <param name="rowId">The row id to get.</param>
    /// <param name="subrowCount">The number of subrows in this row.</param>
    /// <returns><see langword="true"/> if the row exists and <paramref name="subrowCount"/> is written to and <see langword="false"/> otherwise.</returns>
    public bool TryGetSubrowCount( uint rowId, out ushort subrowCount )
    {
        ref readonly var lookup = ref GetRowLookupOrNullRef( rowId );
        if( Unsafe.IsNullRef( in lookup ) )
        {
            subrowCount = 0;
            return false;
        }

        subrowCount = lookup.SubrowCount;
        return true;
    }

    /// <summary>
    /// Gets the number of subrows in the <paramref name="rowId"/>th row in this sheet. Throws if the row does not exist.
    /// </summary>
    /// <param name="rowId">The row id to get.</param>
    /// <returns>The number of subrows in this row. Returns null if the row does not exist.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown if the sheet does not have a row at that <paramref name="rowId"/>.</exception>
    public ushort GetSubrowCount( uint rowId )
    {
        ref readonly var lookup = ref GetRowLookupOrNullRef( rowId );
        return Unsafe.IsNullRef( in lookup ) ? throw new ArgumentOutOfRangeException( nameof( rowId ), rowId, null ) : lookup.SubrowCount;
    }
}