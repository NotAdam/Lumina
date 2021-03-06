using System;

namespace Lumina.Excel.Exceptions
{
    public class ExcelSheetColumnChecksumMismatchException : Exception
    {
        public readonly string SheetName;
        public readonly uint ExpectedHash;
        public readonly uint ActualHash;
        
        public ExcelSheetColumnChecksumMismatchException( string name, uint expectedHash, uint actualHash )
        {
            SheetName = name;
            ExpectedHash = expectedHash;
            ActualHash = actualHash;
        }

        public override string Message => $"sheet {SheetName} column hash mismatch! expected hash: {ExpectedHash:x8}, actual hash: {ActualHash:x8}!";
    }
}