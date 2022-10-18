using System.Numerics;

#pragma warning disable CS1591

namespace Lumina.Data.Parsing.Scd
{
    public static class ScdLayout
    {
        public enum SoundObjectType : byte
        {
            Null,
            Ambient,
            Direction,
            Point,
            PointDir,
            Line,
            Polyline,
            Surface,
            BoardObstruction,
            BoxObstruction,
            PolylineObstruction,
            Polygon,
            BoxExtController,
            LineExtController,
            PolygonObstruction
        }

        public struct SoundObject
        {
            public ushort Size;
            public SoundObjectType Type;
            public byte Version;

            private byte _flags1;
            public bool UseFixedDirection => ( _flags1 & 0x01 ) != 0;
            public bool UnboundedDistance => ( _flags1 & 0x02 ) != 0;
            public bool FirstInactive => ( _flags1 & 0x04 ) != 0;
            public bool BottomInfinity => ( _flags1 & 0x08 ) != 0;
            public bool TopInfinity => ( _flags1 & 0x10 ) != 0;
            public bool Flag3D => ( _flags1 & 0x20 ) != 0;
            public bool PointExpansion => ( _flags1 & 0x40 ) != 0;
            public bool IsLittleEndian => ( _flags1 & 0x80 ) != 0;

            public byte GroupNo;
            public ushort LocalId;
            public uint BankId;

            private byte _flags2;
            public bool IsMaxRangeInterior => ( _flags2 & 0x01 ) != 0;
            public bool UseDistanceFilters => ( _flags2 & 0x02 ) != 0;
            public bool UseDirFirstPos => ( _flags2 & 0x04 ) != 0;
            public bool IsWooferOnly => ( _flags2 & 0x08 ) != 0;
            public bool IsFixedVolume => ( _flags2 & 0x10 ) != 0;
            public bool IsIgnoreObstruction => ( _flags2 & 0x20 ) != 0;
            public bool IsFirstFixedDirection => ( _flags2 & 0x40 ) != 0;
            public bool IsLocalFixedDirection => ( _flags2 & 0x80 ) != 0;

            public byte ReverbType;
            public ushort AbGroupNo;
            public float[] ArrayVolume;

            public object? Data;

            public SoundObject( LuminaBinaryReader binaryReader )
            {
                Size = binaryReader.ReadUInt16();
                Type = (SoundObjectType)binaryReader.ReadByte();
                Version = binaryReader.ReadByte();
                _flags1 = binaryReader.ReadByte();
                GroupNo = binaryReader.ReadByte();
                LocalId = binaryReader.ReadUInt16();
                BankId = binaryReader.ReadUInt32();
                _flags2 = binaryReader.ReadByte();
                ReverbType = binaryReader.ReadByte();
                AbGroupNo = binaryReader.ReadUInt16();
                ArrayVolume = binaryReader.ReadSingleArray( 4 );

                switch( Type )
                {
                    case SoundObjectType.Ambient:
                        Data = new SoundObjectAmbientSound( binaryReader );
                        break;

                    case SoundObjectType.Direction:
                        Data = new SoundObjectDirectionSound( binaryReader );
                        break;

                    case SoundObjectType.Point:
                        Data = new SoundObjectPointSound( binaryReader );
                        break;

                    case SoundObjectType.PointDir:
                        Data = new SoundObjectPointDirSound( binaryReader );
                        break;

                    case SoundObjectType.Line:
                        Data = new SoundObjectLineSound( binaryReader );
                        break;

                    case SoundObjectType.Polyline:
                        Data = new SoundObjectPolyLineSound( binaryReader );
                        break;

                    case SoundObjectType.Surface:
                        Data = new SoundObjectSurfaceSound( binaryReader );
                        break;

                    case SoundObjectType.BoardObstruction:
                        Data = new SoundObjectBoardObstruction( binaryReader );
                        break;

                    case SoundObjectType.BoxObstruction:
                        Data = new SoundObjectBoxObstruction( binaryReader );
                        break;

                    case SoundObjectType.PolylineObstruction:
                        Data = new SoundObjectPolyLineObstruction( binaryReader );
                        break;

                    case SoundObjectType.Polygon:
                        Data = new SoundObjectPolygonSound( binaryReader );
                        break;

                    case SoundObjectType.LineExtController:
                        Data = new SoundObjectLineExtController( binaryReader );
                        break;

                    case SoundObjectType.PolygonObstruction:
                        Data = new SoundObjectPolygonObstruction( binaryReader );
                        break;

                    case SoundObjectType.Null:
                    case SoundObjectType.BoxExtController:
                    default:
                        Data = null;
                        break;
                }
            }
        }

        public struct SoundObjectAmbientSound
        {
            public float Volume;
            public float Pitch;
            public float ReverbFac;
            public float[] DirectVolume;
            private uint _reserved_i;

            public SoundObjectAmbientSound( LuminaBinaryReader binaryReader )
            {
                Volume = binaryReader.ReadSingle();
                Pitch = binaryReader.ReadSingle();
                ReverbFac = binaryReader.ReadSingle();
                DirectVolume = binaryReader.ReadSingleArray( 8 );
                _reserved_i = binaryReader.ReadUInt32();
            }
        }

        public struct SoundObjectDirectionSound
        {
            public float Volume;
            public float Pitch;
            public float ReverbFac;
            public float Direction;
            public float RotSpeed;
            private uint[] _reserved_i;

            public SoundObjectDirectionSound( LuminaBinaryReader binaryReader )
            {
                Volume = binaryReader.ReadSingle();
                Pitch = binaryReader.ReadSingle();
                ReverbFac = binaryReader.ReadSingle();
                Direction = binaryReader.ReadSingle();
                RotSpeed = binaryReader.ReadSingle();
                _reserved_i = binaryReader.ReadUInt32Array( 3 );
            }
        }

        public struct SoundObjectPointSound
        {
            public Vector4 Position;
            public float MaxRange;
            public float MinRange;
            public float[] Height;
            public float RangeVolume;
            public float Volume;
            public float Pitch;
            public float ReverbFac;
            public float DopplerFac;
            public float CenterFac;
            public float InteriorFac;
            public float Direction;
            public float NearFadeStart;
            public float NearFadeEnd;
            public float FarDelayFac;

            private byte _environmentFlags;
            public byte EnvironmentType => (byte)( _environmentFlags & 0x3F );
            public bool IsUseEnvFilterDepth => ( _environmentFlags & 0x40 ) != 0;
            public bool IsFireWorks => ( _environmentFlags & 0x80 ) != 0;

            private byte _flags;
            public bool IsReverbObject => ( _flags & 0x40 ) != 0;
            public bool IsWhizGenerate => ( _flags & 0x80 ) != 0;

            private byte[] _reserved_c;
            public float LowerLimit;
            public ushort FadeInTime;
            public ushort FadeOutTime;
            public float ConvergenceFac;
            private uint _reserved_i;

            public SoundObjectPointSound( LuminaBinaryReader binaryReader )
            {
                Position = binaryReader.ReadStructure< Vector4 >();
                MaxRange = binaryReader.ReadSingle();
                MinRange = binaryReader.ReadSingle();
                Height = binaryReader.ReadSingleArray( 2 );
                RangeVolume = binaryReader.ReadSingle();
                Volume = binaryReader.ReadSingle();
                Pitch = binaryReader.ReadSingle();
                ReverbFac = binaryReader.ReadSingle();
                DopplerFac = binaryReader.ReadSingle();
                CenterFac = binaryReader.ReadSingle();
                InteriorFac = binaryReader.ReadSingle();
                Direction = binaryReader.ReadSingle();
                NearFadeStart = binaryReader.ReadSingle();
                NearFadeEnd = binaryReader.ReadSingle();
                FarDelayFac = binaryReader.ReadSingle();
                _environmentFlags = binaryReader.ReadByte();
                _flags = binaryReader.ReadByte();
                _reserved_c = binaryReader.ReadBytes( 2 );
                LowerLimit = binaryReader.ReadSingle();
                FadeInTime = binaryReader.ReadUInt16();
                FadeOutTime = binaryReader.ReadUInt16();
                ConvergenceFac = binaryReader.ReadSingle();
                _reserved_i = binaryReader.ReadUInt32();
            }
        }

        public struct SoundObjectPointDirSound
        {
            public Vector4 Position;
            public Vector4 Direction;
            public float RangeX;
            public float RangeY;
            public float MaxRange;
            public float MinRange;
            public float[] Height;
            public float RangeVolume;
            public float Volume;
            public float Pitch;
            public float ReverbFac;
            public float DopplerFac;
            public float InteriorFac;
            public float FixedDirection;
            private uint[] _reserved_i;

            public SoundObjectPointDirSound( LuminaBinaryReader binaryReader )
            {
                Position = binaryReader.ReadStructure< Vector4 >();
                Direction = binaryReader.ReadStructure< Vector4 >();
                RangeX = binaryReader.ReadSingle();
                RangeY = binaryReader.ReadSingle();
                MaxRange = binaryReader.ReadSingle();
                MinRange = binaryReader.ReadSingle();
                Height = binaryReader.ReadSingleArray( 2 );
                RangeVolume = binaryReader.ReadSingle();
                Volume = binaryReader.ReadSingle();
                Pitch = binaryReader.ReadSingle();
                ReverbFac = binaryReader.ReadSingle();
                DopplerFac = binaryReader.ReadSingle();
                InteriorFac = binaryReader.ReadSingle();
                FixedDirection = binaryReader.ReadSingle();
                _reserved_i = binaryReader.ReadUInt32Array( 3 );
            }
        }

        public struct SoundObjectLineSound
        {
            public Vector4[] Position;
            public float MaxRange;
            public float MinRange;
            public float[] Height;
            public float RangeVolume;
            public float Volume;
            public float Pitch;
            public float ReverbFac;
            public float DopplerFac;
            public float InteriorFac;
            public float Direction;
            private uint _reserved_i;

            public SoundObjectLineSound( LuminaBinaryReader binaryReader )
            {
                Position = binaryReader.ReadStructuresAsArray< Vector4 >( 2 );
                MaxRange = binaryReader.ReadSingle();
                MinRange = binaryReader.ReadSingle();
                Height = binaryReader.ReadSingleArray( 2 );
                RangeVolume = binaryReader.ReadSingle();
                Volume = binaryReader.ReadSingle();
                Pitch = binaryReader.ReadSingle();
                ReverbFac = binaryReader.ReadSingle();
                DopplerFac = binaryReader.ReadSingle();
                InteriorFac = binaryReader.ReadSingle();
                Direction = binaryReader.ReadSingle();
                _reserved_i = binaryReader.ReadUInt32();
            }
        }

        public struct SoundObjectPolyLineSound
        {
            public Vector4[] Position;
            public float MaxRange;
            public float MinRange;
            public float[] Height;
            public float RangeVolume;
            public float Volume;
            public float Pitch;
            public float ReverbFac;
            public float DopplerFac;
            public byte VertexCount;
            private byte[] _reserved_c;
            public float InteriorFac;
            public float Direction;

            public SoundObjectPolyLineSound( LuminaBinaryReader binaryReader )
            {
                Position = binaryReader.ReadStructuresAsArray< Vector4 >( 16 );
                MaxRange = binaryReader.ReadSingle();
                MinRange = binaryReader.ReadSingle();
                Height = binaryReader.ReadSingleArray( 2 );
                RangeVolume = binaryReader.ReadSingle();
                Volume = binaryReader.ReadSingle();
                Pitch = binaryReader.ReadSingle();
                ReverbFac = binaryReader.ReadSingle();
                DopplerFac = binaryReader.ReadSingle();
                VertexCount = binaryReader.ReadByte();
                _reserved_c = binaryReader.ReadBytes( 3 );
                InteriorFac = binaryReader.ReadSingle();
                Direction = binaryReader.ReadSingle();
            }
        }

        public struct SoundObjectSurfaceSound
        {
            public Vector4[] Position;
            public float MaxRange;
            public float MinRange;
            public float[] Height;
            public float RangeVolume;
            public float Volume;
            public float Pitch;
            public float ReverbFac;
            public float DopplerFac;
            public float InteriorFac;
            public float Direction;
            public byte SubSoundType;

            private byte _flags;
            public bool IsReverbObject => ( _flags & 0x80 ) != 0;

            private byte[] _reserved_c;
            public float RotSpeed;
            private uint[] _reserved_i;

            public SoundObjectSurfaceSound( LuminaBinaryReader binaryReader )
            {
                Position = binaryReader.ReadStructuresAsArray< Vector4 >( 4 );
                MaxRange = binaryReader.ReadSingle();
                MinRange = binaryReader.ReadSingle();
                Height = binaryReader.ReadSingleArray( 2 );
                RangeVolume = binaryReader.ReadSingle();
                Volume = binaryReader.ReadSingle();
                Pitch = binaryReader.ReadSingle();
                ReverbFac = binaryReader.ReadSingle();
                DopplerFac = binaryReader.ReadSingle();
                InteriorFac = binaryReader.ReadSingle();
                Direction = binaryReader.ReadSingle();
                SubSoundType = binaryReader.ReadByte();
                _flags = binaryReader.ReadByte();
                _reserved_c = binaryReader.ReadBytes( 2 );
                RotSpeed = binaryReader.ReadSingle();
                _reserved_i = binaryReader.ReadUInt32Array( 3 );
            }
        }

        public struct SoundObjectBoardObstruction
        {
            public Vector4[] Position;
            public float ObstacleFac;
            public float HiCutFac;

            private byte _flags;
            public bool UseHiCutFac => ( _flags & 0x08 ) != 0;

            private byte[] _reserved_c;
            public ushort OpenTime;
            public ushort CloseTime;

            public SoundObjectBoardObstruction( LuminaBinaryReader binaryReader )
            {
                Position = binaryReader.ReadStructuresAsArray< Vector4 >( 4 );
                ObstacleFac = binaryReader.ReadSingle();
                HiCutFac = binaryReader.ReadSingle();
                _flags = binaryReader.ReadByte();
                _reserved_c = binaryReader.ReadBytes( 3 );
                OpenTime = binaryReader.ReadUInt16();
                CloseTime = binaryReader.ReadUInt16();
            }
        }

        public struct SoundObjectBoxObstruction
        {
            public Vector4[] Position;
            public float[] Height;
            public float ObstacleFac;
            public float HicutFac;

            private byte _flags;
            public bool UseHiCutFac => ( _flags & 0x08 ) != 0;

            private byte[] _reserved_c;
            public float FadeRange;
            public ushort OpenTime;
            public ushort CloseTime;
            private uint _reserved_i;

            public SoundObjectBoxObstruction( LuminaBinaryReader binaryReader )
            {
                Position = binaryReader.ReadStructuresAsArray< Vector4 >( 4 );
                Height = binaryReader.ReadSingleArray( 2 );
                ObstacleFac = binaryReader.ReadSingle();
                HicutFac = binaryReader.ReadSingle();
                _flags = binaryReader.ReadByte();
                _reserved_c = binaryReader.ReadBytes( 3 );
                FadeRange = binaryReader.ReadSingle();
                OpenTime = binaryReader.ReadUInt16();
                CloseTime = binaryReader.ReadUInt16();
                _reserved_i = binaryReader.ReadUInt32();
            }
        }

        public struct SoundObjectPolyLineObstruction
        {
            public Vector4[] Position;
            public float[] Height;
            public float ObstacleFac;
            public float HiCutFac;

            private byte _flags;
            public bool UseHiCutFac => ( _flags & 0x08 ) != 0;

            public byte VertexCount;
            private byte[] _reserved_c;
            public float Width;
            public float FadeRange;
            public ushort OpenTime;
            public ushort CloseTime;

            public SoundObjectPolyLineObstruction( LuminaBinaryReader binaryReader )
            {
                Position = binaryReader.ReadStructuresAsArray< Vector4 >( 16 );
                Height = binaryReader.ReadSingleArray( 2 );
                ObstacleFac = binaryReader.ReadSingle();
                HiCutFac = binaryReader.ReadSingle();
                _flags = binaryReader.ReadByte();
                VertexCount = binaryReader.ReadByte();
                _reserved_c = binaryReader.ReadBytes( 2 );
                Width = binaryReader.ReadSingle();
                FadeRange = binaryReader.ReadSingle();
                OpenTime = binaryReader.ReadUInt16();
                CloseTime = binaryReader.ReadUInt16();
            }
        }

        public struct SoundObjectPolygonSound
        {
            public float MaxRange;
            public float MinRange;
            public float[] Height;
            public float RangeVolume;
            public float Volume;
            public float Pitch;
            public float ReverbFac;
            public float DopplerFac;
            public float InteriorFac;
            public float Direction;
            public byte SubSoundType;

            private byte _flags;
            public bool IsReverbObject => ( _flags & 0x80 ) != 0;

            public byte VertexCount;
            private byte _reserved_c;
            public float RotSpeed;
            private uint[] _reserved_i;
            public Vector4[] Position;

            public SoundObjectPolygonSound( LuminaBinaryReader binaryReader )
            {
                MaxRange = binaryReader.ReadSingle();
                MinRange = binaryReader.ReadSingle();
                Height = binaryReader.ReadSingleArray( 2 );
                RangeVolume = binaryReader.ReadSingle();
                Volume = binaryReader.ReadSingle();
                Pitch = binaryReader.ReadSingle();
                ReverbFac = binaryReader.ReadSingle();
                DopplerFac = binaryReader.ReadSingle();
                InteriorFac = binaryReader.ReadSingle();
                Direction = binaryReader.ReadSingle();
                SubSoundType = binaryReader.ReadByte();
                _flags = binaryReader.ReadByte();
                VertexCount = binaryReader.ReadByte();
                _reserved_c = binaryReader.ReadByte();
                RotSpeed = binaryReader.ReadSingle();
                _reserved_i = binaryReader.ReadUInt32Array( 3 );
                Position = binaryReader.ReadStructuresAsArray< Vector4 >( 32 );
            }
        }

        public struct SoundObjectLineExtController
        {
            public Vector4[] Position;
            public float MaxRange;
            public float MinRange;
            public float[] Height;
            public float RangeVolume;
            public float Volume;
            public float LowerLimit;
            public uint FuncNo;
            public byte CalcType;
            private byte[] _reserved_c;
            private uint[] _reserved_i;

            public SoundObjectLineExtController( LuminaBinaryReader binaryReader )
            {
                Position = binaryReader.ReadStructuresAsArray< Vector4 >( 2 );
                MaxRange = binaryReader.ReadSingle();
                MinRange = binaryReader.ReadSingle();
                Height = binaryReader.ReadSingleArray( 2 );
                RangeVolume = binaryReader.ReadSingle();
                Volume = binaryReader.ReadSingle();
                LowerLimit = binaryReader.ReadSingle();
                FuncNo = binaryReader.ReadUInt32();
                CalcType = binaryReader.ReadByte();
                _reserved_c = binaryReader.ReadBytes( 3 );
                _reserved_i = binaryReader.ReadUInt32Array( 4 );
            }
        }

        public struct SoundObjectPolygonObstruction
        {
            public Vector4[] Position;
            public float ObstacleFac;
            public float HiCutFac;

            private byte _flags;
            public bool UseHiCutFac => ( _flags & 0x08 ) != 0;

            public byte VertexCount;
            private byte[] _reserved_c;
            public ushort OpenTime;
            public ushort CloseTime;

            public SoundObjectPolygonObstruction( LuminaBinaryReader binaryReader )
            {
                Position = binaryReader.ReadStructuresAsArray< Vector4 >( 32 );
                ObstacleFac = binaryReader.ReadSingle();
                HiCutFac = binaryReader.ReadSingle();
                _flags = binaryReader.ReadByte();
                VertexCount = binaryReader.ReadByte();
                _reserved_c = binaryReader.ReadBytes( 2 );
                OpenTime = binaryReader.ReadUInt16();
                CloseTime = binaryReader.ReadUInt16();
            }
        }
    }
}
