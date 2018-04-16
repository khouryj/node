using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dulanclaymold
{
    public enum TraverseOrder
    {
        InOrder,
        PreOrder,
        PostOrder
    }

    public class ADSTree
    {
        private ADSNode root;

        public sealed class ADSNode
        {
            public ADSNode left;
            public ADSNode right;
            public int key;
            public int cardinality;  //  Increment each time duplicates are added
            public int height; // Height of this node

            public ADSNode(int val)
            {
                key = val;
            }
        }

        public ADSTree()
        {
            root = null;
        }

        // Return the node where value is located
        public ADSNode find(int value)
        {
            if (value == root.key)
            {
                return root;
            }
            ADSNode current = root;
            while (value != current.key)
            {
                if (value < current.key)
                {
                    current = current.left;
                }
                else
                {
                    current = current.right;
                }
            }
            if (value != current.key)
            {
                return null;
            }
            return current;
        }

        // Inserts a node into the tree and maintains it's balance
        public void insert(int value)
        {
            if (root == null)
            {
                root = new ADSNode(value);
                root.height = 0;
            }
        }

        // Print the tree in a particular order
        public void printTree(TraverseOrder order)
        {
        }
    }
}
