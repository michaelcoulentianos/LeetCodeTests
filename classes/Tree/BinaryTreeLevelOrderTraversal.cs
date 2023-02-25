using LeetCodeTests.classes.CommonLogic.Nodes;

namespace LeetCodeTests.classes.Tree;

/*
    In computer science, a binary tree is a k-ary k=2 tree data structure
    in which each node has at most two children, which are referred to as
    the left child and the right child.
*/

public class BinaryTreeLevelOrderTraversal
{
    public static IList<IList<int>> LevelOrder(TreeNode root)
    {
        List<IList<int>> result = new();
        if (root == null)
            return result;
        Queue<TreeNode> queue = new();
        queue.Enqueue(root);

        while (queue.Count is not 0)
        {
            List<int> curLevel = new();
            for (int i = 0, size = queue.Count(); i < size; i++)
            {
                TreeNode node = queue.Dequeue();
                curLevel.Add(node.val);
                if (node.left != null)
                    queue.Enqueue(node.left);
                if (node.right != null)
                    queue.Enqueue(node.right);
            }
            result.Add(curLevel);
        }
        return result;
    }
}
