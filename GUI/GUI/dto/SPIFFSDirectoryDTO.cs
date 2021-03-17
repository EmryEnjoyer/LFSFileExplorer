using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.dto
{
    class SPIFFSDirectoryDTO : IWritableDTO
    {
        public List<SPIFFSFileDTO> Children { get; set; }
        public List<SPIFFSDirectoryDTO> ChildDirectories { get; set; }
        public string Name { get; set; }
        public int Size { get; set; }
        public bool CanRead { get; set; }
        public bool CanWrite { get; set; }
    }
}
