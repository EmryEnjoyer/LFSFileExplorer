using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.dto
{
    interface IWritableDTO
    {
        string Name { get; set; }
        int Size { get; set; }
        bool CanRead { get; set; }
        bool CanWrite { get; set; }
    }
}
