using GUI.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Objects
{
    interface IInteractable
    {
        void Write(byte[] data);
        byte[] Read();
        void Delete(); 
        
    }
}
