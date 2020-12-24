using System;
using System.Collections.Generic;
using System.Text;

namespace Base
{
    public class Provincia
    {
        public string Name { get; set; }
        public string Ubicacion { get; set; }
        public string Url { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
