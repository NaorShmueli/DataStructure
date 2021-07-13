using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs.Implementation
{
    class Vertex
    {
        public string Name { get; set; }
        public IList<string> Edges { get; set; }

        public Vertex(string name)
        {
            Name = name;
            Edges = new List<string>();
        }
    }
}
