using GUI.dto;
using System;
using System.Text.Json;

namespace GUI.Util
{
    class IO
    {
        public T ReadFromSerial<T>()
        {
            throw new NotImplementedException();
        }
        public bool WriteToSerial<T>(T dto) where T : IWritable
        {
            throw new NotImplementedException();
        }
        private string InputSerialData(int port)
        {
            throw new NotImplementedException();
        }
    }
}
