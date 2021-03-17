using GUI.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Util
{
    class IO
    {
        public T ReadFromSerial<T>()
        {
            throw new NotImplementedException();
        }
        public bool WriteToSerial<T>(T dto) where T : IWritableDTO
        {
            throw new NotImplementedException();
        }
        private string InputSerialData(int port)
        {
            throw new NotImplementedException();
        }
    }
}
