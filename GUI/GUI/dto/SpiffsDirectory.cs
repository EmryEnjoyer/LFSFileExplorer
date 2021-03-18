using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.dto
{
    class SpiffsDirectory : IWritable
    {
        public List<SpiffsFile> Children { get; set; }
        public List<SpiffsDirectory> ChildDirectories { get; set; }
        public string Name { get; set; }
        public int Size { get; set; }
        public bool CanRead { get; set; }
        public bool CanWrite { get; set; }
    }
}
