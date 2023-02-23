namespace LeetCodeTests.classes.Tree;
public class NAryTreePreorderTraversal
{
    public static IList<int> Preorder(Node root)
    {
        if (root is null) return new List<int>(){};
        List<int> result = new();
        result.Add(root.val);
        result = Recursive(root,result);
        return result;
    }

    public static List<int> Recursive(Node root, List<int> list)
    {
        if (root.children == null) return list;
        foreach (var item in root.children)
        {
            list.Add(item.val);
            list = Recursive(item, list);
        }

        return list;
    }
}