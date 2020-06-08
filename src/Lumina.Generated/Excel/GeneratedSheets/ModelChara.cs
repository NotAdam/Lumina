using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ModelChara", columnHash: 0xc49c9dc2 )]
    public class ModelChara : IExcelRow
    {
        
        public byte Type;
        public ushort Model;
        public byte Base;
        public byte Variant;
        public ushort SEPack;
        public byte Unknown5;
        public bool Unknown6;
        public bool PapVariation;
        public byte Unknown8;
        public sbyte Unknown9;
        public bool Unknown10;
        public bool Unknown11;
        public bool Unknown12;
        public bool Unknown13;
        public bool Unknown14;
        public byte Unknown15;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Type = parser.ReadColumn< byte >( 0 );
            Model = parser.ReadColumn< ushort >( 1 );
            Base = parser.ReadColumn< byte >( 2 );
            Variant = parser.ReadColumn< byte >( 3 );
            SEPack = parser.ReadColumn< ushort >( 4 );
            Unknown5 = parser.ReadColumn< byte >( 5 );
            Unknown6 = parser.ReadColumn< bool >( 6 );
            PapVariation = parser.ReadColumn< bool >( 7 );
            Unknown8 = parser.ReadColumn< byte >( 8 );
            Unknown9 = parser.ReadColumn< sbyte >( 9 );
            Unknown10 = parser.ReadColumn< bool >( 10 );
            Unknown11 = parser.ReadColumn< bool >( 11 );
            Unknown12 = parser.ReadColumn< bool >( 12 );
            Unknown13 = parser.ReadColumn< bool >( 13 );
            Unknown14 = parser.ReadColumn< bool >( 14 );
            Unknown15 = parser.ReadColumn< byte >( 15 );
        }
    }
}