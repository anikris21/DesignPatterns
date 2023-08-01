// See https://aka.ms/new-console-template for more information
using CompositePattern;

Console.WriteLine("Hello, World!");

CompositeNode root = new CompositeNode("root", null);

CompositeNode n1 = new("node1", root);
CompositeNode n11 = new("node11", root);

root.Add(n1);
root.Add(n11);
LeafNode l1 = new("leaf", root);
root.Add(l1);


root.PrintNodes(); // use bfs to print the tree

