using Lumina.Data.Attributes;
using Lumina.Data.Parsing.Scd;
using Lumina.Extensions;
using System;
using System.Collections.Generic;

namespace Lumina.Data.Files
{
    [FileExtension( ".scd" )]
    public class ScdFile : FileResource
    {
        public class Sound
        {
            public ScdSound.SoundBasicDesc SoundBasicDesc;
            public ScdSound.RoutingInfo? RoutingInfo;
            public ScdSound.SendInfo[]? SendInfos;
            public ScdSound.SoundEffectParam? SoundEffectParam;
            public ScdSound.BusDuckingInfo? BusDuckingInfo;
            public ScdSound.AccelerationInfo? AccelerationInfo;
            public ScdSound.AtomosgearInfo? AtomosgearInfo;
            public ScdSound.SoundExtraDesc? SoundExtraDesc;

            public object TrackInfos;
            public ScdSound.CycleInfo? CycleInfo;
        }

        public class Audio
        {
            public ScdAudio.AudioBasicDesc AudioBasicDesc;

            public ScdAudio.SubInfoMarkerChunk? MarkerChunkHeader;
            public uint[]? Markers;

            public object? AudioDataHeader;
            public uint[]? SeekTable;
            public byte[] AudioData;
        }

        // stolen from FFXIV Explorer
        private static readonly byte[] OggXorTable =
        {
            0x3A, 0x32, 0x32, 0x32, 0x03, 0x7E, 0x12, 0xF7, 0xB2, 0xE2, 0xA2, 0x67, 0x32, 0x32, 0x22, 0x32,
            0x32, 0x52, 0x16, 0x1B, 0x3C, 0xA1, 0x54, 0x7B, 0x1B, 0x97, 0xA6, 0x93, 0x1A, 0x4B, 0xAA, 0xA6,
            0x7A, 0x7B, 0x1B, 0x97, 0xA6, 0xF7, 0x02, 0xBB, 0xAA, 0xA6, 0xBB, 0xF7, 0x2A, 0x51, 0xBE, 0x03,
            0xF4, 0x2A, 0x51, 0xBE, 0x03, 0xF4, 0x2A, 0x51, 0xBE, 0x12, 0x06, 0x56, 0x27, 0x32, 0x32, 0x36,
            0x32, 0xB2, 0x1A, 0x3B, 0xBC, 0x91, 0xD4, 0x7B, 0x58, 0xFC, 0x0B, 0x55, 0x2A, 0x15, 0xBC, 0x40,
            0x92, 0x0B, 0x5B, 0x7C, 0x0A, 0x95, 0x12, 0x35, 0xB8, 0x63, 0xD2, 0x0B, 0x3B, 0xF0, 0xC7, 0x14,
            0x51, 0x5C, 0x94, 0x86, 0x94, 0x59, 0x5C, 0xFC, 0x1B, 0x17, 0x3A, 0x3F, 0x6B, 0x37, 0x32, 0x32,
            0x30, 0x32, 0x72, 0x7A, 0x13, 0xB7, 0x26, 0x60, 0x7A, 0x13, 0xB7, 0x26, 0x50, 0xBA, 0x13, 0xB4,
            0x2A, 0x50, 0xBA, 0x13, 0xB5, 0x2E, 0x40, 0xFA, 0x13, 0x95, 0xAE, 0x40, 0x38, 0x18, 0x9A, 0x92,
            0xB0, 0x38, 0x00, 0xFA, 0x12, 0xB1, 0x7E, 0x00, 0xDB, 0x96, 0xA1, 0x7C, 0x08, 0xDB, 0x9A, 0x91,
            0xBC, 0x08, 0xD8, 0x1A, 0x86, 0xE2, 0x70, 0x39, 0x1F, 0x86, 0xE0, 0x78, 0x7E, 0x03, 0xE7, 0x64,
            0x51, 0x9C, 0x8F, 0x34, 0x6F, 0x4E, 0x41, 0xFC, 0x0B, 0xD5, 0xAE, 0x41, 0xFC, 0x0B, 0xD5, 0xAE,
            0x41, 0xFC, 0x3B, 0x70, 0x71, 0x64, 0x33, 0x32, 0x12, 0x32, 0x32, 0x36, 0x70, 0x34, 0x2B, 0x56,
            0x22, 0x70, 0x3A, 0x13, 0xB7, 0x26, 0x60, 0xBA, 0x1B, 0x94, 0xAA, 0x40, 0x38, 0x00, 0xFA, 0xB2,
            0xE2, 0xA2, 0x67, 0x32, 0x32, 0x12, 0x32, 0xB2, 0x32, 0x32, 0x32, 0x32, 0x75, 0xA3, 0x26, 0x7B,
            0x83, 0x26, 0xF9, 0x83, 0x2E, 0xFF, 0xE3, 0x16, 0x7D, 0xC0, 0x1E, 0x63, 0x21, 0x07, 0xE3, 0x01
        };

        private uint[] _soundOffsets = Array.Empty< uint >();
        private uint[] _trackOffsets = Array.Empty< uint >();
        private uint[] _audioOffsets = Array.Empty< uint >();
        private uint _layoutOffset;
        private uint _routingOffset; // unused in FFXIV?
        private uint _attributeOffset;

        public int SoundDataCount => _soundOffsets.Length;
        public int TrackDataCount => _trackOffsets.Length;
        public int AudioDataCount => _audioOffsets.Length;

        public override void LoadFile()
        {
            var header = new ScdCommon.BinaryHeader( Reader );
            var scdHeader = Reader.ReadStructure< ScdCommon.ScdHeader >();

            _soundOffsets = new uint[ scdHeader.SoundCount ];
            for( var i = 0; i < scdHeader.SoundCount; i++ )
                _soundOffsets[ i ] = Reader.ReadUInt32();

            Reader.BaseStream.Position = scdHeader.TrackOffset;
            _trackOffsets = new uint[ scdHeader.TrackCount ];
            for( var i = 0; i < scdHeader.TrackCount; i++ )
                _trackOffsets[ i ] = Reader.ReadUInt32();

            Reader.BaseStream.Position = scdHeader.AudioOffset;
            _audioOffsets = new uint[ scdHeader.AudioCount ];
            for( var i = 0; i < scdHeader.AudioCount; i++ )
                _audioOffsets[ i ] = Reader.ReadUInt32();

            if( scdHeader.LayoutOffset != 0 )
            {
                Reader.Position = scdHeader.LayoutOffset;
                _layoutOffset = Reader.ReadUInt32();
            }

            if( scdHeader.RoutingOffset != 0 )
            {
                Reader.Position = scdHeader.RoutingOffset;
                _routingOffset = Reader.ReadUInt32();
            }

            if( scdHeader.AttributeOffset != 0 )
            {
                Reader.Position = scdHeader.AttributeOffset;
                _attributeOffset = Reader.ReadUInt32();
            }
        }

        /// <summary>Parses the sound data at the given index.</summary>
        /// <param name="index">The index into the stored sound offset array.</param>
        /// <returns>A <c>Sound</c> object with all the information stored in the selected sound section.</returns>
        public Sound GetSound( int index )
        {
            Reader.Position = _soundOffsets[ index ];
            var soundBasicDesc = Reader.ReadStructure< ScdSound.SoundBasicDesc >();

            var sound = new Sound();
            sound.SoundBasicDesc = soundBasicDesc;

            if( soundBasicDesc.Attribute.HasFlag( ScdSound.SoundAttribute.ExistRoutingSetting ) )
            {
                var routingInfo = Reader.ReadStructure< ScdSound.RoutingInfo >();
                sound.RoutingInfo = routingInfo;
                sound.SendInfos = Reader.ReadStructuresAsArray< ScdSound.SendInfo >( routingInfo.SendCount );
                sound.SoundEffectParam = Reader.ReadStructure< ScdSound.SoundEffectParam >();
            }

            if( soundBasicDesc.Attribute.HasFlag( ScdSound.SoundAttribute.BusDucking ) )
            {
                sound.BusDuckingInfo = Reader.ReadStructure< ScdSound.BusDuckingInfo >();
            }

            if( soundBasicDesc.Attribute.HasFlag( ScdSound.SoundAttribute.Acceleration ) )
            {
                sound.AccelerationInfo = new ScdSound.AccelerationInfo( Reader );
            }

            if( soundBasicDesc.Attribute.HasFlag( ScdSound.SoundAttribute.Atomosgear ) )
            {
                sound.AtomosgearInfo = Reader.ReadStructure< ScdSound.AtomosgearInfo >();
            }

            if( soundBasicDesc.Attribute.HasFlag( ScdSound.SoundAttribute.ExtraDesc ) )
            {
                sound.SoundExtraDesc = Reader.ReadStructure< ScdSound.SoundExtraDesc >();
            }

            if( soundBasicDesc.Type is ScdSound.SoundType.Random or ScdSound.SoundType.Cycle or ScdSound.SoundType.GroupRandom )
            {
                sound.TrackInfos = Reader.ReadStructures< ScdSound.RandomTrackInfo >( soundBasicDesc.TrackCount );

                if( soundBasicDesc.Type == ScdSound.SoundType.Cycle )
                {
                    sound.CycleInfo = Reader.ReadStructure< ScdSound.CycleInfo >();
                }
            }
            else
            {
                sound.TrackInfos = Reader.ReadStructures< ScdSound.TrackInfo >( soundBasicDesc.TrackCount );
            }

            return sound;
        }

        // Just a prototype, don't use it.
        public List< ( ScdTrack.TrackCmd cmd, object? data ) > GetTrack( int index )
        {
            Reader.Position = _trackOffsets[ index ];
            var trackCmdData = new List< (ScdTrack.TrackCmd, object?) >();

            while( true )
            {
                var cmd = (ScdTrack.TrackCmd)Reader.ReadUInt16();
                object? data = null;

                switch( cmd )
                {
                    case ScdTrack.TrackCmd.End:
                        trackCmdData.Add( ( cmd, null ) );
                        return trackCmdData;

                    case ScdTrack.TrackCmd.Volume:
                        data = Reader.ReadStructure< ScdTrack.TrackCmdParam >();
                        break;

                    case ScdTrack.TrackCmd.Pitch:
                        data = Reader.ReadStructure< ScdTrack.TrackCmdParam >();
                        break;

                    case ScdTrack.TrackCmd.Interval:
                        data = Reader.ReadUInt32();
                        break;

                    case ScdTrack.TrackCmd.Modulation:
                        data = Reader.ReadStructure< ScdTrack.ModulationCmdParam >();
                        break;

                    case ScdTrack.TrackCmd.ReleaseRate:
                        data = Reader.ReadUInt32();
                        break;

                    case ScdTrack.TrackCmd.Panning:
                        data = Reader.ReadStructure< ScdTrack.TrackCmdParam >();
                        break;

                    case ScdTrack.TrackCmd.KeyOn:
                        break;

                    case ScdTrack.TrackCmd.RandomVolume:
                        data = Reader.ReadStructure< ScdTrack.RandomCmdParam >();
                        break;

                    case ScdTrack.TrackCmd.RandomPitch:
                        data = Reader.ReadStructure< ScdTrack.RandomCmdParam >();
                        break;

                    case ScdTrack.TrackCmd.RandomPan:
                        data = Reader.ReadStructure< ScdTrack.RandomCmdParam >();
                        break;

                    case ScdTrack.TrackCmd.KeyOff:
                        break;

                    case ScdTrack.TrackCmd.LoopStart:
                        data = Reader.ReadUInt32Array( 2 ); // loopLowerCnt, loopUpperCnt
                        break;

                    case ScdTrack.TrackCmd.LoopEnd:
                        break;

                    case ScdTrack.TrackCmd.ExternalAudio:
                        data = new ScdTrack.ExternalAudioInfo( Reader );
                        break;

                    case ScdTrack.TrackCmd.EndForLoop:
                        trackCmdData.Add( ( cmd, null ) );
                        return trackCmdData;

                    case ScdTrack.TrackCmd.AddInterval:
                        data = Reader.ReadSingle();
                        break;

                    case ScdTrack.TrackCmd.Expression:
                        data = Reader.ReadSingleArray( 2 ); // lowerExpression, upperExpression
                        break;

                    case ScdTrack.TrackCmd.Velocity:
                        data = Reader.ReadSingle();
                        break;

                    case ScdTrack.TrackCmd.MidiVolume:
                        data = Reader.ReadSingleArray( 2 ); // lowerVolume, upperVolume
                        break;

                    case ScdTrack.TrackCmd.MidiAddVolume:
                        data = Reader.ReadSingle();
                        break;

                    case ScdTrack.TrackCmd.MidiPan:
                        data = Reader.ReadSingleArray( 2 ); // lowerPan, upperPan
                        break;

                    case ScdTrack.TrackCmd.MidiAddPan:
                        data = Reader.ReadSingle();
                        break;

                    case ScdTrack.TrackCmd.ModulationType:
                        data = ( (ScdTrack.OscillatorCarrier)Reader.ReadUInt32(), (ScdTrack.OscillatorMode)Reader.ReadUInt32() );
                        break;

                    case ScdTrack.TrackCmd.ModulationDepth:
                        data = new ScdTrack.ModulationDepth
                        {
                            Carrier = Reader.ReadUInt32(),
                            Depth = Reader.ReadSingle()
                        };
                        break;

                    case ScdTrack.TrackCmd.ModulationAddDepth:
                        data = new ScdTrack.ModulationDepth
                        {
                            Carrier = Reader.ReadUInt32(),
                            Depth = Reader.ReadSingle()
                        };
                        break;

                    case ScdTrack.TrackCmd.ModulationSpeed:
                        data = new ScdTrack.ModulationSpeed
                        {
                            Carrier = Reader.ReadUInt32(),
                            Speed = Reader.ReadUInt32()
                        };
                        break;

                    case ScdTrack.TrackCmd.ModulationAddSpeed:
                        data = new ScdTrack.ModulationSpeed
                        {
                            Carrier = Reader.ReadUInt32(),
                            Speed = Reader.ReadUInt32()
                        };
                        break;

                    case ScdTrack.TrackCmd.ModulationOff:
                        data = (ScdTrack.OscillatorCarrier)Reader.ReadUInt32();
                        break;

                    case ScdTrack.TrackCmd.PitchBend:
                        data = Reader.ReadSingleArray( 2 ); // lowerPitch, upperPitch
                        break;

                    case ScdTrack.TrackCmd.Transpose:
                        data = Reader.ReadSingleArray( 2 ); // lowerPitch, upperPitch
                        break;

                    case ScdTrack.TrackCmd.AddTranspose:
                        data = Reader.ReadSingle();
                        break;

                    case ScdTrack.TrackCmd.FrPanning:
                        data = Reader.ReadStructure< ScdTrack.TrackCmdParam >();
                        break;

                    case ScdTrack.TrackCmd.RandomWait:
                        data = Reader.ReadUInt32Array( 2 ); // lowerWait, upperWait
                        break;

                    case ScdTrack.TrackCmd.Adsr:
                        data = Reader.ReadStructure< ScdTrack.TrackCmdParam >();
                        break;

                    case ScdTrack.TrackCmd.CutOff:
                        break;

                    case ScdTrack.TrackCmd.Jump:
                        data = ( (ScdTrack.TrackCmdJump)Reader.ReadUInt32(), Reader.ReadInt32() ); // condition, offset
                        break;

                    case ScdTrack.TrackCmd.PlayContinueLoop:
                        break;

                    case ScdTrack.TrackCmd.Sweep:
                        data = ( Reader.ReadSingle(), Reader.ReadUInt32() ); // pitch, time
                        break;

                    case ScdTrack.TrackCmd.MidiKeyOnOld:
                        break;

                    case ScdTrack.TrackCmd.SlurOn:
                        break;

                    case ScdTrack.TrackCmd.SlurOff:
                        break;

                    case ScdTrack.TrackCmd.AutoAdsrEnvelope:
                        data = Reader.ReadStructure< ScdTrack.AutoAdsrEnvelope >();
                        break;

                    case ScdTrack.TrackCmd.MidiExternalAudio:
                        data = new ScdTrack.ExternalAudioInfo( Reader );
                        break;

                    case ScdTrack.TrackCmd.Marker:
                        break;

                    case ScdTrack.TrackCmd.InitParams:
                        break;

                    case ScdTrack.TrackCmd.Version:
                        data = Reader.ReadUInt16();
                        break;

                    case ScdTrack.TrackCmd.ReverbOn:
                        data = Reader.ReadSingle(); // reverbDryVolume
                        break;

                    case ScdTrack.TrackCmd.ReverbOff:
                        break;

                    case ScdTrack.TrackCmd.MidiKeyOn:
                        data = Reader.ReadSingleArray( 2 ); // velocity, pitch
                        break;

                    case ScdTrack.TrackCmd.PortamentoOn:
                        data = ( Reader.ReadInt32(), Reader.ReadSingle() ); // portamentoTime, pitch
                        break;

                    case ScdTrack.TrackCmd.PortamentoOff:
                        break;

                    case ScdTrack.TrackCmd.MidiEnd:
                        trackCmdData.Add( ( cmd, null ) );
                        return trackCmdData;

                    case ScdTrack.TrackCmd.ClearKeyInfo:
                        break;

                    case ScdTrack.TrackCmd.ModulationDepthFade:
                        data = new ScdTrack.ModulationDepth
                        {
                            Carrier = Reader.ReadUInt32(),
                            Depth = Reader.ReadSingle(),
                            FadeTime = Reader.ReadInt32()
                        };
                        break;

                    case ScdTrack.TrackCmd.ModulationSpeedFade:
                        data = new ScdTrack.ModulationSpeed
                        {
                            Carrier = Reader.ReadUInt32(),
                            Speed = Reader.ReadUInt32(),
                            FadeTime = Reader.ReadInt32()
                        };
                        break;

                    case ScdTrack.TrackCmd.AnalysisFlag:
                        data = Reader.ReadUInt16Array( Reader.ReadUInt16() );
                        break;

                    case ScdTrack.TrackCmd.Config:
                        var trackConfig = new ScdTrack.TrackConfig
                        {
                            Type = (ScdTrack.TrackCmdConfigType)Reader.ReadUInt16(),
                            Count = Reader.ReadUInt16()
                        };

                        if( trackConfig.Type == ScdTrack.TrackCmdConfigType.IntervalTypeFloat )
                        {
                            trackConfig.Data = Reader.ReadUInt16() != 0;
                        }
                        else if( trackConfig.Type > ScdTrack.TrackCmdConfigType.IntervalTypeFloat )
                        {
                            trackConfig.Data = Reader.ReadUInt16Array( trackConfig.Count );
                        }

                        data = trackConfig;
                        break;

                    case ScdTrack.TrackCmd.Filter:
                        data = Reader.ReadStructure< ScdTrack.TrackFilter >();
                        break;

                    case ScdTrack.TrackCmd.PlayInnerSound:
                        data = Reader.ReadUInt16Array( 2 ); // bankNumber, soundIndex
                        break;

                    case ScdTrack.TrackCmd.VolumeZeroOne:
                        var zeroOneHeader = Reader.ReadStructure< ScdTrack.TrackZeroOneParamHeader >();
                        data = Reader.ReadStructuresAsArray< ScdTrack.TrackZeroOnePoint >( zeroOneHeader.NumPoints );
                        break;

                    case ScdTrack.TrackCmd.ZeroOneJump:
                        data = Reader.ReadInt32(); // jumpTarget
                        break;

                    case ScdTrack.TrackCmd.ChannelVolumeZeroOne:
                        var channelZeroOneHeader = Reader.ReadStructure< ScdTrack.TrackChannelZeroOneParamHeader >();
                        var zeroOnePoints = new ScdTrack.TrackZeroOnePoint[ channelZeroOneHeader.NumChannels ][];

                        for( var i = 0; i < channelZeroOneHeader.NumChannels; i++ )
                        {
                            var zeroOneParamHeader = Reader.ReadStructure< ScdTrack.TrackZeroOneParamHeader >();
                            zeroOnePoints[ i ] = Reader.ReadStructuresAsArray< ScdTrack.TrackZeroOnePoint >( zeroOneParamHeader.NumPoints );
                        }

                        data = zeroOnePoints;
                        break;

                    case ScdTrack.TrackCmd.Unknown64:
                        var unknownHeader = Reader.ReadStructure< ScdTrack.TrackUnknown64Header >();
                        data = Reader.ReadStructures< ScdTrack.TrackUnknown64 >( unknownHeader.Count );
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

                trackCmdData.Add( ( cmd, data ) );
            }
        }

        /// <summary>Parses the audio data at the given index.</summary>
        /// <param name="index">The index into the stored audio offset array.</param>
        /// <returns>
        /// An <c>Audio</c> object with all the information stored in
        /// the selected audio section, including the audio stream.
        /// </returns>
        public Audio GetAudio( int index )
        {
            Reader.Position = _audioOffsets[ index ];
            var audioBasicDesc = Reader.ReadStructure< ScdAudio.AudioBasicDesc >();

            var audio = new Audio();
            audio.AudioBasicDesc = audioBasicDesc;

            var subInfoStartPos = Reader.Position;
            if( audioBasicDesc.Flg.HasFlag( ScdAudio.AudioFlag.MarkerChunk ) )
            {
                var subInfoMarkerChunk = Reader.ReadStructure< ScdAudio.SubInfoMarkerChunk >();
                audio.MarkerChunkHeader = subInfoMarkerChunk;
                audio.Markers = Reader.ReadUInt32Array( subInfoMarkerChunk.NumMarkers );

                Reader.Position = subInfoStartPos + subInfoMarkerChunk.Header.Size;
            }

            switch( audioBasicDesc.Format )
            {
                case ScdAudio.AudioFormat.Empty:
                    audio.AudioData = Array.Empty< byte >();
                    break;

                case ScdAudio.AudioFormat.OggVorbis:
                {
                    var oggSeekTableHeader = Reader.ReadStructure< ScdAudio.OggVorbisSeekTableHeader >();
                    audio.AudioDataHeader = oggSeekTableHeader;
                    audio.SeekTable = Reader.ReadUInt32Array( (int)( oggSeekTableHeader.SeekTableSize / 4 ) );

                    Reader.Position = subInfoStartPos + audioBasicDesc.SubInfoSize;

                    var oggFile = new byte[ oggSeekTableHeader.OggHeaderSize + audioBasicDesc.Size ];
                    Array.Copy( Reader.ReadBytes( (int)oggSeekTableHeader.OggHeaderSize ), oggFile, oggSeekTableHeader.OggHeaderSize );
                    Array.Copy( Reader.ReadBytes( (int)audioBasicDesc.Size ), 0, oggFile, oggSeekTableHeader.OggHeaderSize, audioBasicDesc.Size );

                    switch( oggSeekTableHeader.Version )
                    {
                        case 2:
                            for( var j = 0; j < oggSeekTableHeader.OggHeaderSize; j++ )
                                oggFile[ j ] ^= oggSeekTableHeader.XorByte;
                            break;

                        case 3:
                            var byte1 = (byte)( audioBasicDesc.Size & 0x7F );
                            var byte2 = (byte)( byte1 & 0x3F );

                            for( var j = 0; j < oggFile.Length; j++ )
                            {
                                byte xorByte = OggXorTable[ ( byte2 + j ) & 0xFF ];
                                xorByte ^= oggFile[ j ];
                                xorByte ^= byte1;
                                oggFile[ j ] = xorByte;
                            }

                            break;
                    }

                    audio.AudioData = oggFile;
                    break;
                }

                case ScdAudio.AudioFormat.Mp3:
                    var id = Reader.PeekBytes( 4 );
                    if( id[ 0 ] == 'S' && id[ 1 ] == 'T' && id[ 2 ] == 'B' && id[ 3 ] == 'L' )
                    {
                        var mp3SeekTableHeader = Reader.ReadStructure< ScdAudio.PS3MP3SeekTableHeader >();
                        audio.AudioDataHeader = mp3SeekTableHeader;
                        audio.SeekTable = Reader.ReadUInt32Array( mp3SeekTableHeader.NumElement );
                    }
                    else
                    {
                        // step size is 1 second
                        audio.SeekTable = Reader.ReadUInt32Array( Reader.ReadInt32() );
                    }

                    Reader.Position = subInfoStartPos + audioBasicDesc.SubInfoSize;
                    audio.AudioData = Reader.ReadBytes( (int)audioBasicDesc.Size );
                    break;

                case ScdAudio.AudioFormat.MsAdpcm:
                    audio.AudioDataHeader = Reader.ReadStructure< ScdAudio.AdpcmWaveFormat >();
                    Reader.Position = subInfoStartPos + audioBasicDesc.SubInfoSize;
                    audio.AudioData = Reader.ReadBytes( (int)audioBasicDesc.Size );
                    break;

                case ScdAudio.AudioFormat.Atrac9:
                    audio.AudioDataHeader = Reader.ReadStructure< ScdAudio.ATRAC9Header >();
                    Reader.Position = subInfoStartPos + audioBasicDesc.SubInfoSize;
                    audio.AudioData = Reader.ReadBytes( (int)audioBasicDesc.Size );
                    break;

                case (ScdAudio.AudioFormat)5: // headerless Atrac3 stream?
                default:
                    System.Diagnostics.Debug.WriteLine( "Unknown audio format type id " + audioBasicDesc.Format );

                    Reader.Position = subInfoStartPos + audioBasicDesc.SubInfoSize;
                    audio.AudioData = Reader.ReadBytes( (int)audioBasicDesc.Size );
                    break;
            }

            return audio;
        }

        /// <summary>Parses the layout data.</summary>
        public ScdLayout.SoundObject? GetLayout()
        {
            if( _layoutOffset == 0 )
                return null;

            Reader.BaseStream.Position = _layoutOffset;
            return new ScdLayout.SoundObject( Reader );
        }

        /// <summary>Parses the attribute data.</summary>
        public ScdAttribute.AttributeData? GetAttributeData()
        {
            if( _attributeOffset == 0 )
                return null;

            Reader.Position = _attributeOffset;
            return new ScdAttribute.AttributeData( Reader );
        }
    }
}
