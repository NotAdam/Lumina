using System.IO;

namespace Lumina.Data.Parsing
{
    public class Common
    {
        public struct Vector3
        {
            public float X, Y, Z;

            public static Vector3 Read( BinaryReader br )
            {
                return new Vector3 { X = br.ReadSingle(), Y = br.ReadSingle(), Z = br.ReadSingle() };
            }
        };

        public struct Vector4
        {
            public float x, y, z, w;

            public static Vector4 Read( BinaryReader br )
            {
                return new Vector4
                {
                    x = br.ReadSingle(), y = br.ReadSingle(), z = br.ReadSingle(), w = br.ReadSingle()
                };
            }
        };

        public struct Matrix43f { public Vector4 col1, col2, col3, col4; };

        public struct Matrix43 { public Vector4 col1, col2, col3; };

        public struct Transformation
        {
            public Vector3 Translation, Rotation, Scale;

            public static Transformation Read( BinaryReader br )
            {
                return new Transformation
                {
                    Translation = Vector3.Read( br ), Rotation = Vector3.Read( br ), Scale = Vector3.Read( br )
                };
            }
        };
    }
}
