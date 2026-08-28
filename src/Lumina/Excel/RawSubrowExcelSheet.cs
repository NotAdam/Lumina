using System;
using System.Runtime.CompilerServices;
using Lumina.Data;
using Lumina.Data.Files.Excel;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel;

/// <summary>An excel sheet of <see cref="ExcelVariant.Subrows"/> variant.</summary>
public sealed class RawSubrowExcelSheet : RawExcelSheet, ISubrowExcelSheet
{
    internal RawSubrowExcelSheet( ExcelModule module, ExcelHeaderFile headerFile, Language language, string name )
        : base( module, headerFile, language, name )
    {
        foreach( var f in OffsetLookupTable )
            TotalSubrowCount += f.SubrowCount;
    }

    /// <inheritdoc/>
    public int TotalSubrowCount { get; }

    /// <inheritdoc/>
    public bool HasSubrow( uint rowId, ushort subrowId )
    {
        ref readonly var lookup = ref GetRowLookupOrNullRef( rowId );
        return !Unsafe.IsNullRef( in lookup ) && subrowId < lookup.SubrowCount;
    }

    /// <inheritdoc/>
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

    /// <inheritdoc/>
    public ushort GetSubrowCount( uint rowId )
    {
        ref readonly var lookup = ref GetRowLookupOrNullRef( rowId );
        return Unsafe.IsNullRef( in lookup ) ? throw new ArgumentOutOfRangeException( nameof( rowId ), rowId, null ) : lookup.SubrowCount;
    }

    [MethodImpl( MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization )]
    public SubrowCollection<T>? GetRowOrDefault<T>( uint rowId ) where T : struct, IExcelSubrow<T>
    {
        ref readonly var lookup = ref GetRowLookupOrNullRef( rowId );
        return Unsafe.IsNullRef( in lookup ) ? null : new( this, in lookup );
    }
}