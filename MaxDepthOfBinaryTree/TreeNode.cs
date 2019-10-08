using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxDepthOfBinaryTree
{
    public class TreeNode
    {
        public Int32 key;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(Int32 item)
        {
            key = item;
            left = right = null;
        }
    }
}
