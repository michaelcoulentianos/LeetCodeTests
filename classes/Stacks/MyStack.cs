namespace LeetCodeTests.classes.Stacks;

public class MyStack<T>
{
    List<T> stack;

    public MyStack()
    {
        stack = new List<T>();
    }

    public string Push(T input)
    {
        stack?.Insert(0, input);
        return $"Add ''{input}'' element to top of the stack";
    }

    public string Pop()
    {
        if (stack != null && stack.Count != 0)
        {
            stack.RemoveAt(0);
            return "Removed first element";
        }
        else
            return "Removed no elements";
    }

    public string Peek()
    {
        var result = "";
        foreach (var item in stack)
        {
            if (result == "")
                result = $"{item}";
            else
                result += $",{item}";
        }
        return $"{result}";
    }
}
