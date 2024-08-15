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
    /// <returns>An <see cref="IEnumerator{T}"/> of all rows or subrows in this sheet.</returns>
    public SheetEnumerator GetEnumerator() =>
        new( this );

    /// <inheritdoc/>
    IEnumerator<T> IEnumerable<T>.GetEnumerator() =>
        GetEnumerator();

    /// <inheritdoc/>
    IEnumerator IEnumerable.GetEnumerator() =>
        GetEnumerator();

    /// <summary>
    /// Returns an enumerator that can be used to iterate over all rows in this sheet. If this sheet has subrows, it will iterate over the first subrow of every row.
    /// </summary>
    /// <returns>An <see cref="IEnumerator{T}"/> of all rows (or first subrows) in this sheet.</returns>
    public RowEnumerator GetRowEnumerator() =>
        new( this );

    /// <summary>
    /// Represents an enumerator that iterates over all rows/subrows in a <see cref="ExcelSheet{T}"/>.
    /// </summary>
    /// <param name="sheet">The sheet to iterate over.</param>
    public struct SheetEnumerator( ExcelSheet<T> sheet ) : IEnumerator<T>, IEnumerable<T>
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

        /// <inheritdoc/>
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

        /// <inheritdoc/>
        public void Reset()
        {
            LookupIndex = -1;
            SubrowIndex = 0;
            SubrowCount = 0;
        }

        /// <inheritdoc/>
        public readonly void Dispose()
        {

        }

        /// <inheritdoc/>
        public readonly IEnumerator<T> GetEnumerator() => this;

        /// <inheritdoc/>
        readonly IEnumerator IEnumerable.GetEnumerator() => this;
    }

    /// <summary>
    /// Represents an enumerator that iterates over all rows or the first subrow of every row in a <see cref="ExcelSheet{T}"/>.
    /// </summary>
    /// <param name="sheet">The sheet to iterate over.</param>
    public struct RowEnumerator( ExcelSheet<T> sheet ) : IEnumerator<T>, IEnumerable<T>
    {
        private int LookupIndex { get; set; } = -1;

        private readonly int RowCount => sheet.Count;

        /// <inheritdoc cref="IEnumerator{T}.Current"/>
        public readonly T Current => sheet.GetRowAt( LookupIndex );

        /// <inheritdoc/>
        readonly object IEnumerator.Current => Current;

        /// <inheritdoc/>
        public bool MoveNext()
        {
            if( LookupIndex + 1 < RowCount )
            {
                LookupIndex++;
                return true;
            }
            return false;
        }

        /// <inheritdoc/>
        public void Reset()
        {
            LookupIndex = -1;
        }

        /// <inheritdoc/>
        public readonly void Dispose()
        {

        }

        /// <inheritdoc/>
        public readonly IEnumerator<T> GetEnumerator() => this;

        /// <inheritdoc/>
        readonly IEnumerator IEnumerable.GetEnumerator() => this;
    }
}
