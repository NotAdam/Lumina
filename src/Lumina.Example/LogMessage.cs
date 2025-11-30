using Lumina.Excel;
using Lumina.Text.ReadOnly;

namespace Lumina.Example;

[Sheet( "LogMessage" )]
readonly public struct LogMessage( ExcelPage page, uint offset, uint row ) : IExcelRow<LogMessage>
{
    public ExcelPage ExcelPage => page;
    public uint RowOffset => offset;
    public uint RowId => row;

    public readonly ReadOnlySeString Text => page.ReadString( offset, offset );

    static LogMessage IExcelRow<LogMessage>.Create( ExcelPage page, uint offset, uint row ) =>
        new( page, offset, row );
}