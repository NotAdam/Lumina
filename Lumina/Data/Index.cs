using System;
using System.IO;

namespace Lumina.Data
{
    public class Index
    {
        public bool IsIndex2 { get; set; }
        
        public FileInfo IndexFile { get; set; }
        
        public Index( FileInfo indexFile )
        {
            IsIndex2 = indexFile.Extension == ".index2";
            IndexFile = indexFile;

            if( IsIndex2 )
            {
                LoadIndex2();
            }
            else
            {
                LoadIndex();
            }
        }

        private void LoadIndex()
        {
            
        }

        private void LoadIndex2()
        {
            
        }
    }
}