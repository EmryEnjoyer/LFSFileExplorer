﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.dto
{
    class SpiffsFile : IWritable
    {
        public List<SpiffsDirectory> Path { get; set; }
        public string Name { get; set; }
        public int Size { get; set; }
        public bool CanRead { get; set; }
        public bool CanWrite { get; set; }
        public Byte[] Contents { get; set; }
    }
}
