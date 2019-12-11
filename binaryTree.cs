using System; 
  
// C# implementation to find leaf count of a given Binary tree  
  
/* Class containing left and right child of current   
 node and key value*/
namespace ALGORITHMS
{

    public class Node 
    { 
        public int data; 
        public Node left, right; 
    
        public Node(int item) 
        { 
            data = item; 
            left = right = null; 
        } 
    } 
    
    public class BinaryTree 
    { 
        //Root of the Binary Tree  
        public Node root; 
    
        /* Function to get the count of leaf nodes in a binary tree*/
        public int LeafCount 
        { 
            get
            { 
                return getLeafCount(root); 
            } 
        } 
    
        public int getLeafCount(Node node) 
        { 
            if (node == null) 
            { 
                return 0; 
            }
            else
            { 
                return getLeafCount(node.left) + getLeafCount(node.right)+1; 
            } 
        } 

        public int maxHeight(Node node)  
        { 
            if (node == null) 
                return 0; 
            else
            { 
                /* compute the depth of each subtree */
                int lHeight = maxHeight(node.left); 
                int rHeight = maxHeight(node.right); 
    
                /* use the larger one */

                
                if (lHeight > rHeight) 
                    return (lHeight + 1); 
                else
                    return (rHeight + 1); 
            } 
        } 
        
        
    } 
}
  