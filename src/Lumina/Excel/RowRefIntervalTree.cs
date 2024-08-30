using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Lumina.Excel;

internal sealed class RowRefIntervalTree
{
    private readonly record struct Interval( uint From, uint To, Type Type );

    private readonly struct Point( uint rowId ) : IComparable< Interval >
    {
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public int CompareTo( Interval other )
        {
            if( rowId < other.From )
                return -1;
            else if( rowId >= other.To )
                return 1;
            return 0;
        }
    }

    private readonly Interval[] Intervals;

    public RowRefIntervalTree( ExcelModule module, ReadOnlySpan< Type > types )
    {
        List< Interval > retIntervals = [];

        List< Interval > currentIntervals = [];
        foreach( var type in types )
        {
            var sheet = module.GetSheetByType( type );

            currentIntervals.Clear();
            uint? from = null;
            uint to = 0;
            foreach( var row in sheet.OffsetLookupTable )
            {
                var id = row.RowId;
                if( !from.HasValue )
                {
                    from = id;
                    to = id + 1;
                }
                else if( row.RowId == to )
                    to = id + 1;
                else
                {
                    currentIntervals.Add( new( from.Value, to, type ) );
                    from = id;
                    to = id + 1;
                }
            }
            if( from.HasValue )
                currentIntervals.Add( new( from.Value, to, type ) );

            var lstI = 0;
            var curI = 0;
            while( lstI < retIntervals.Count && curI < currentIntervals.Count )
            {
                var lst = retIntervals[lstI];
                var cur = currentIntervals[curI];
                // list item is fully before current item
                if( lst.To <= cur.From )
                    lstI++;
                // current item is fully before list item
                else if( cur.To <= lst.From )
                {
                    retIntervals.Insert( lstI, cur );
                    curI++;
                    lstI++;
                }
                // list item is before or begins at current item
                else if( lst.From <= cur.From )
                {
                    // list item fully contains current item
                    if( lst.To >= cur.To )
                        curI++;
                    // current item ends ahead of list item
                    else
                    {
                        cur = cur with { From = lst.To };
                        retIntervals.Insert( lstI + 1, cur );
                        curI++;
                        lstI += 2;
                    }
                }
                // current item is before list item
                else if( cur.From < lst.From )
                {
                    // current item fully contains list item
                    if( cur.To >= lst.To )
                        lstI++;
                    // list item ends ahead of current item
                    else
                    {
                        cur = cur with { To = lst.From };
                        retIntervals.Insert( lstI, cur );
                        curI++;
                        lstI++;
                    }
                }
                else
                    throw new UnreachableException();
            }
            while( curI < currentIntervals.Count )
                retIntervals.Add( currentIntervals[curI++] );
        }

        Intervals = [.. retIntervals];
    }

    public Type? Get( uint rowId )
    {
        ReadOnlySpan< Interval > intervals = Intervals.AsSpan();
        var idx = intervals.BinarySearch( new Point( rowId ) );
        return idx >= 0 ? intervals[idx].Type : null;
    }
}
