using System;

namespace ALGORITHMS
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree(); 
            tree.root = new Node(1); 
            tree.root.left = new Node(2); 
            tree.root.right = new Node(3); 
            tree.root.left.left = new Node(4); 
            tree.root.left.right = new Node(5); 
            tree.root.left.right.right = new Node(6); 
            tree.root.left.right.right.left = new Node(7); 
    
            /* get leaf count of the abve tree */
            Console.WriteLine("The leaf count of binary tree is : " + tree.LeafCount); 

            Console.WriteLine("Height of tree is : " +  tree.maxHeight(tree.root)); 
        }
    }
}
