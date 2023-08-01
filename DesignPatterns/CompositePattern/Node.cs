using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
     abstract class Node
    {
        public abstract string Name { get; }

        public virtual void Add(Node node) { throw new NotImplementedException(); }
        public virtual void Remove(Node node) { }
        public virtual void PrintNodes() { }

        public virtual void Printparent() { }
    }
}
