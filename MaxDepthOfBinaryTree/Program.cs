using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxDepthOfBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(9);
            root.right = new TreeNode(20);
            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(7);
            Console.WriteLine(MaxDepth(root));
            Console.ReadLine();
        }
        private static Int32 MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            int leftDepth = MaxDepth(root.left);
            int rightDepth = MaxDepth(root.right);

            return Math.Max(leftDepth, rightDepth)+1;
        }
    }
}
