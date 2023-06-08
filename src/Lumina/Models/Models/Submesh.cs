using System.Collections.Generic;
using Lumina.Data.Parsing;

namespace Lumina.Models.Models
{
    public class Submesh
    {
        /// <summary>
        /// The offset to the index that this submesh begins.
        /// </summary>
        public uint IndexOffset;
        
        /// <summary>
        /// The number of indices present in this submesh.
        /// </summary>
        public uint IndexNum;
        
        /// <summary>
        /// The attributes that are enabled for this submesh.
        /// </summary>
        public string[] Attributes;
        
        /// <summary>
        /// The bones referenced by this submesh.
        /// </summary>
        public string[] Bones;

        public Submesh( Model model, int meshIndex, int subMeshIndex )
        {
            var currentMesh = model.File.Meshes[ meshIndex ];
            int subMeshListIndex = currentMesh.SubMeshIndex + subMeshIndex;
            var currentSubMesh = model.File.Submeshes[ subMeshListIndex ];

            IndexOffset = currentSubMesh.IndexOffset - currentMesh.StartIndex;
            IndexNum = currentSubMesh.IndexCount;

            // AttributeIndexMask is a bit-based index mask
            // i.e. "5" is 0101 so it applies attrs 0 and 2
            var attributeList = new List< string >();
            for( int i = 0; i < model.File.ModelHeader.AttributeCount; i++ )
            {
                if( ( ( 1 << i ) & currentSubMesh.AttributeIndexMask ) > 0 )
                {
                    uint nameOffset = model.File.AttributeNameOffsets[ i ];
                    attributeList.Add( model.StringOffsetToStringMap[ (int) nameOffset ] );
                }
            }

            Attributes = attributeList.ToArray();

            // I don't know what this is for
            if( currentSubMesh.BoneStartIndex == 65535 ) return;
            var affectedBoneTable = new List< string >();
            int boneEndIndex = currentSubMesh.BoneStartIndex + currentSubMesh.BoneCount;
            for( int i = currentSubMesh.BoneStartIndex; i < boneEndIndex; i++ )
            {
                var boneIndex = model.File.SubmeshBoneMap[ i ];
                var boneOffset = model.File.BoneNameOffsets[ boneIndex ];
                string boneName = model.StringOffsetToStringMap[ (int) boneOffset ];
                affectedBoneTable.Add( boneName );
            }

            Bones = affectedBoneTable.ToArray();
        }
    }
}