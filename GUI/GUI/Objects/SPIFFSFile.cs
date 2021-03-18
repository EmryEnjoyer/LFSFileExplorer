using GUI.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Objects
{
    class SpiffsFile : IInteractable
    {
        public string name { get; set; }
        public int size { get; set; }
        public bool canRead { get; set; }
        public bool canWrite { get; set; }
        public byte[] contents { get; set; }

        private static List<SpiffsFile> cache;
        public SpiffsFile(dto.SpiffsFile data)
        {
            cache.Append(this);
            name = data.Name;
            size = data.Size;
            canRead = data.CanRead;
            canWrite = data.CanWrite;
            contents = data.Contents;
        }
        

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public byte[] Read()
        {
            throw new NotImplementedException();
        }

        public void Write(byte[] content)
        {
            throw new NotImplementedException();
        }
    }
}
