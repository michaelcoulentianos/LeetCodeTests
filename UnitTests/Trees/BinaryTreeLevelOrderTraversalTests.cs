using LeetCodeTests.classes.CommonLogic.Nodes;
using LeetCodeTests.classes.Tree;

namespace LeetCodeTests.UnitTests.Trees
{
    public class BinaryTreeLevelOrderTraversalTests
    {
        [TestCase]
        public void Simple_Binary_Tree_Traversal_Expected_3_9_20_15_7()
        {
            // Create the nodes
            TreeNode node1 = new TreeNode(3);
            TreeNode node2 = new TreeNode(9);
            TreeNode node3 = new TreeNode(20);
            TreeNode node4 = new TreeNode(15);
            TreeNode node5 = new TreeNode(7);

            // Link the nodes together to form the tree
            node1.left = node2;
            node1.right = node3;
            node3.left = node4;
            node3.right = node5;

            BinaryTreeLevelOrderTraversal.LevelOrder(node1);
        }

        [TestCase]
        public void Simple_Binary_Tree_Traversal_Expected_3_9_20_13_15_7()
        {
            // Create the nodes
            TreeNode node1 = new TreeNode(3);
            TreeNode node2 = new TreeNode(9);
            TreeNode node3 = new TreeNode(20);
            TreeNode node4 = new TreeNode(13);
            TreeNode node5 = new TreeNode(15);
            TreeNode node6 = new TreeNode(7);

            // Link the nodes together to form the tree
            node1.left = node2;
            node1.right = node3;
            node1.right.right = node4;
            node3.left = node5;
            node3.right = node6;

            BinaryTreeLevelOrderTraversal.LevelOrder(node1);
        }

        [TestCase]
        public void Simple_Binary_Tree_Traversal_Expected_Empty()
        {
            BinaryTreeLevelOrderTraversal.LevelOrder(null);
        }

        [TestCase]
        public void Simple_Binary_Tree_Traversal_Expected_1()
        {
            TreeNode node1 = new(1);
            BinaryTreeLevelOrderTraversal.LevelOrder(node1);
        }
    }
}
