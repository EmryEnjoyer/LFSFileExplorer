using GUI.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Objects
{
    class SPIFFSFile : IInteractable
    {
        public string Name { get; set; }

        private static List<SPIFFSFile> cache;
        private SPIFFSFileDTO data;
        public SPIFFSFile(SPIFFSFileDTO data)
        {
            cache.Append(this);
            this.data = data;
        }
        

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public byte[] Read()
        {
            throw new NotImplementedException();
        }

        public void Write()
        {
            throw new NotImplementedException();
        }
        public string getName()
        {
            return data.Name;
        }
        public int getSize()
        {
            return data.Size;
        }
        public bool getCanRead()
        {
            return data.CanRead;
        }
        public bool getCanWrite()
        {
            return data.CanWrite;
        }
    }
}
