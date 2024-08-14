using System;
using System.Collections;
using System.Collections.Generic;

namespace Lumina.Excel;

public sealed partial class ExcelSheet<T> : IReadOnlyCollection<T> where T : struct, IExcelRow<T>
{
    /// <inheritdoc cref="IExcelSheet.Count"/>
    public int Count => RowLookup.Count;

    private readonly int subrowCount;

    /// <inheritdoc/>
    public int SubrowCount => HasSubrows ? subrowCount : throw new NotSupportedException( "This sheet that doesn't support subrows." );

    /// <summary>
    /// Returns an enumerator that can be used to iterate over all rows in this sheet. If this sheet has subrows, it will iterate over every subrow of every row.
    /// </summary>
    /// <returns>An <see cref="IEnumerator{T}"/> of all rows or subrows in this sheet</returns>
    public SheetEnumerator GetEnumerator() =>
        new( this );

    /// <inheritdoc/>
    IEnumerator IEnumerable.GetEnumerator() =>
        GetEnumerator();

    /// <summary>
    /// Returns an enumerator that can be used to iterate over all rows in this sheet. If this sheet has subrows, it will iterate over the first subrow of every row.
    /// </summary>
    /// <returns>An <see cref="IEnumerator{T}"/> of all rows (or first subrows) in this sheet</returns>
    public RowEnumerator GetRowEnumerator() =>
        new( this );

    IEnumerator<T> IEnumerable<T>.GetEnumerator() =>
        GetEnumerator();

    public struct SheetEnumerator( ExcelSheet<T> sheet ) : IEnumerator<T>
    {
        private int LookupIndex { get; set; } = -1;
        private ushort SubrowIndex { get; set; } = 0;
        private ushort SubrowCount { get; set; } = 0;

        private readonly bool HasSubrows => sheet.HasSubrows;
        private readonly int RowCount => sheet.Count;

        /// <inheritdoc cref="IEnumerator{T}.Current"/>
        public readonly T Current => !HasSubrows ? sheet.GetRowAt( LookupIndex ) : sheet.GetSubrowAt( LookupIndex, SubrowIndex );

        /// <inheritdoc/>
        readonly object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            if( !HasSubrows )
            {
                if( LookupIndex + 1 < RowCount )
                {
                    LookupIndex++;
                    return true;
                }
            }
            else
            {
                if( SubrowIndex + 1 < SubrowCount && SubrowCount != 0 )
                {
                    SubrowIndex++;
                    return true;
                }
                else if( LookupIndex + 1 < RowCount )
                {
                    LookupIndex++;
                    SubrowIndex = 0;
                    SubrowCount = sheet.Subrows![LookupIndex].Data.RowCount;
                    return true;
                }
            }
            return false;
        }

        public void Reset()
        {
            LookupIndex = -1;
            SubrowIndex = 0;
            SubrowCount = 0;
        }

        public readonly void Dispose()
        {

        }
    }

    public struct RowEnumerator( ExcelSheet<T> sheet ) : IEnumerator<T>, IEnumerable<T>
    {
        private int LookupIndex { get; set; } = -1;

        private readonly int RowCount => sheet.Count;

        /// <inheritdoc cref="IEnumerator{T}.Current"/>
        public readonly T Current => sheet.GetRowAt( LookupIndex );

        /// <inheritdoc/>
        readonly object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            if( LookupIndex + 1 < RowCount )
            {
                LookupIndex++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            LookupIndex = -1;
        }

        public readonly void Dispose()
        {

        }

        public readonly IEnumerator<T> GetEnumerator() => this;

        readonly IEnumerator IEnumerable.GetEnumerator() => this;
    }
}
