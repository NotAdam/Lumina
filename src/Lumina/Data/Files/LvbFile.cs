using System;
using System.Text;
using Lumina.Data.Attributes;

namespace Lumina.Data.Files
{
    /// <summary>
    /// Territory layout scene. LVB and SGB share the same SCN1 container representation, plus a
    /// FileSceneGeneral-rooted weather-id table and an .envb (environment/lighting) file path that
    /// only LVB files carry.
    /// </summary>
    [FileExtension( ".lvb" )]
    public class LvbFile : SgbFile
    {
        /// <summary>
        /// Up to 32 raw weather ids. 0 entries if the section is absent.
        /// </summary>
        public ushort[] WeatherIds { get; private set; } = [];

        public string? EnvbFile { get; private set; }

        public override void LoadFile()
        {
            base.LoadFile();
            if( Data == null ) return;

            WeatherIds = ParseWeatherIds( Data, ChunkHeader.OffsetGeneral );
            EnvbFile = FindEnvbPath( Data );
        }

        private static ushort[] ParseWeatherIds( byte[] data, int offsetGeneral )
        {
            if( offsetGeneral <= 0 ) return [];
            int settingsStart = 20 + offsetGeneral;
            if( settingsStart + 0x44 > data.Length ) return [];

            int weatherTableOffset = BitConverter.ToInt32( data, settingsStart + 0x40 );
            int weatherTableStart = settingsStart + weatherTableOffset;
            if( weatherTableStart < 0 || weatherTableStart + 64 > data.Length ) return [];

            var ids = new ushort[32];
            for( int i = 0; i < 32; i++ )
                ids[i] = BitConverter.ToUInt16( data, weatherTableStart + i * 2 );
            return ids;
        }

        private static readonly byte[] EnvbExtensionBytes = { 0x2E, 0x65, 0x6E, 0x76, 0x62, 0x00 }; // ".envb\0"

        private static string? FindEnvbPath( byte[] data )
        {
            for( int i = 0; i <= data.Length - EnvbExtensionBytes.Length; i++ )
            {
                bool match = true;
                for( int j = 0; j < EnvbExtensionBytes.Length; j++ )
                {
                    if( data[i + j] != EnvbExtensionBytes[j] ) { match = false; break; }
                }
                if( !match ) continue;

                int end = i + EnvbExtensionBytes.Length - 1;
                int start = i;
                while( start > 0 && data[start - 1] != 0 ) start--;
                return Encoding.UTF8.GetString( data, start, end - start );
            }
            return null;
        }
    }
}
