using System.Collections.Generic;
using System.Linq;
using Lumina.Data.Files;

namespace Lumina.Models.Models
{
    public struct ShapeMesh {
        public Mesh AssociatedMesh;

        public ( ushort BaseIndicesIndex, ushort ReplacedVertexIndex )[] Values;

        public static IReadOnlyList< ShapeMesh > ConstructList( MdlFile file, IReadOnlyList< Mesh > meshes )
        {
            var ret = new ShapeMesh[ file.ModelHeader.ShapeMeshCount ];
            var idx = 0;
            
            var meshDict = new Dictionary< uint, Mesh >();
            foreach( var mesh in meshes ) {
                // skip meshes that are already in the dictionary
                if( meshDict.ContainsKey( file.Meshes[ mesh.MeshIndex ].StartIndex ) ) continue;
                meshDict.Add( file.Meshes[ mesh.MeshIndex ].StartIndex, mesh );
            }

            foreach( var shapeMeshStruct in file.ShapeMeshes ) {

                if( !meshDict.TryGetValue( shapeMeshStruct.MeshIndexOffset, out var mesh ) ) continue;

                var values = Enumerable
                    .Range( (int)shapeMeshStruct.ShapeValueOffset, (int)shapeMeshStruct.ShapeValueCount )
                    .Select( i => ( file.ShapeValues[ i ].BaseIndicesIndex, file.ShapeValues[ i ].ReplacingVertexIndex ) )
                    .ToArray();

                ret[ idx++ ] = new ShapeMesh {
                    AssociatedMesh = mesh,
                    Values = values,
                };
            }

            return ret;
        }
    }

    public class Shape {
        public string Name { get; private set; }
        public ShapeMesh[] Meshes { get; private set; }

        public Shape( Model model, Model.ModelLod lod, IReadOnlyList< ShapeMesh > shapeMeshes, int shapeIndex )
        {
            var currentShape = model.File.Shapes[ shapeIndex ];

            // handle cases where the name is not found in the StringOffsetToStringMap
            Name = model.StringOffsetToStringMap.TryGetValue( (int)currentShape.StringOffset, out var name )
                ? name
                : $"UnknownShape_{shapeIndex}";

            Meshes = new ShapeMesh[ currentShape.ShapeMeshCount[ (int)lod ] ];
            var end    = currentShape.ShapeMeshCount[ (int)lod ];
            var offset = currentShape.ShapeMeshStartIndex[ (int)lod ];
            for( var i = 0; i < end; ++i ) {
                Meshes[ i ] = shapeMeshes[ i + offset ];
            }
        }
    }
}
