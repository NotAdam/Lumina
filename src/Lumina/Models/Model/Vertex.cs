using System.IO;
using System.Linq;
using System.Numerics;
using Lumina.Data.Files;
using Lumina.Data.Parsing.Mdl;

namespace Lumina.Models.Model {

    public struct Vertex {
        
        public enum VertexType : byte {
            Single3 = 2,
            Single4 = 3,
            UInt = 5,
            ByteFloat4 = 8,
            Half2 = 13,
            Half4 = 14
        }
    
        public enum VertexUsage : byte {
            Position = 0,
            BlendWeights = 1,
            BlendIndices = 2,
            Normal = 3,
            UV = 4,
            Tangent2 = 5,
            Tangent1 = 6,
            Color = 7,
        }
        
        public static int[] ElementSizes = {0, 0, 12, 16, 4, 4, 4, 8};
        
        public Vector4? Position;
        public Vector4? BlendWeights;
        public byte[] BlendIndices;
        public Vector3? Normal;
        public Vector4? UV;
        public Vector4? Color;
        public Vector4? Tangent2;
        public Vector4? Tangent1;
    }
}