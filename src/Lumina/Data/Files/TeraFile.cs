using System.Numerics;
using Lumina.Extensions;

#pragma warning disable 649

namespace Lumina.Data.Files
{
    struct PlatePos
    {
        public short X;
        public short Y;
    }
    
    public class TeraFile : FileResource
    {
        public uint Version;
        public uint PlateCount;
        public uint PlateSize;
        public float ClipDistance;
        public float Unknown;
        public byte[] Padding;

        private PlatePos[] _positions; 
        
        public override void LoadFile()
        {
            Version = Reader.ReadUInt32();
            PlateCount = Reader.ReadUInt32();
            PlateSize = Reader.ReadUInt32();
            ClipDistance = Reader.ReadSingle();
            Unknown = Reader.ReadSingle();
            Padding = Reader.ReadBytes( 32 );

            _positions = Reader.ReadStructuresAsArray< PlatePos >( (int) PlateCount );
        }

        /// <summary>
        /// Retrieve the X and Z coordinates of the specified plate index. Note that
        /// the Y coordinate is unnecessary as bg plates each contain all necessary vertical
        /// data in their respective plate.
        /// </summary>
        /// <param name="plateIndex">The index of the bg plate to obtain the coordinates for.</param>
        /// <returns></returns>
        public Vector2 GetPlatePosition( int plateIndex )
        {
            var pos = _positions[ plateIndex ];
            return new Vector2( PlateSize * ( pos.X + 0.5f ), PlateSize * ( pos.Y + 0.5f ) );
        }
    }
}