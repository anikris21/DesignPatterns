using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
     class CompositeNode :Node
    {
        private readonly string name;
        private readonly Node? parent;

        private List<Node> nodeList;
        public CompositeNode(string name, Node parentNode) 
        { 
            this.name = name; 
            this.parent = parentNode;
            nodeList = new List<Node>();
        }
        public override string Name { get { return name; } }

        public override void Add(Node node)
        {
            nodeList.Add(node);
        }

        public override void Remove(Node node) {  
            nodeList.Remove(node); 
        }

        public override void PrintNodes()
        {
            foreach (var node in nodeList)
            {
                Console.WriteLine(node.Name);
            }
        }



    }
}
