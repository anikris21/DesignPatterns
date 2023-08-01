using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
     class LeafNode:Node
    {
        private readonly string _name;
        private readonly Node? parent;
        public LeafNode(string name, Node p) { _name = name; parent = p; }

        public override string Name => _name;

        public override void PrintNodes()
        {
            Console.WriteLine(_name);
        }
    }
}
