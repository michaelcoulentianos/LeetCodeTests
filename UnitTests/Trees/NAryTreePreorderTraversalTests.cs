using LeetCodeTests.classes.Tree;

namespace LeetCodeTests.UnitTests.Trees
{
    public class NAryTreePreorderTraversalTests
    {
        [TestCase(ExpectedResult = new int[] { 1, 3, 5, 6, 2, 4 })]
        public IList<int> Simple_Tree_Traversal_Expected_1_3_5_6_2_4()
        {
            Node root = new Node(1), child3 = new(3),
            child2 = new(2), child4 = new(4),
            child5 = new(5), child6 = new(6);

            child3.children = new List<Node> { child5, child6 };
            root.children = new List<Node> { child3, child2, child4 };

            return NAryTreePreorderTraversal.Preorder(root);
        }

        [TestCase(ExpectedResult = new int[] { 1, 3, 5, 6, 2, 4 })]
        public IList<int> Simple_Tree_Traversal_Expected_Empty_Array()
        {
            return NAryTreePreorderTraversal.Preorder(null);
        }
    }
}