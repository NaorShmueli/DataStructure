using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.Implementation
{
    class Element
    {
        public string Value { get; set; }
        public Element Next { get; set; }
        public Element(string value)
        {
            Value = value;
        }
    }
}
