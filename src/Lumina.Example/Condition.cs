using Lumina.Excel;

namespace Lumina.Example;

[Sheet( "Condition" )]
readonly public struct Condition( ExcelPage page, uint offset, uint row ) : IExcelRow<Condition>
{
    public ExcelPage ExcelPage => page;
    public uint RowOffset => offset;
    public uint RowId => row;

    public readonly RowRef<LogMessage> LogMessage => new( page.Module, page.ReadUInt32( offset ), page.Language );

    static Condition IExcelRow<Condition>.Create( ExcelPage page, uint offset, uint row ) =>
        new( page, offset, row );
}
