using LeetCodeTests.classes.Stacks;

namespace LeetCodeTests.UnitTests.Stacks;

public class MyStackTests
{
    MyStack<string> StringStack;
    MyStack<int> IntStack;

    public MyStackTests()
    {
        StringStack = new MyStack<string>();
        IntStack = new MyStack<int>();
    }

    [TestCase("New Item added to stack", ExpectedResult = "Add ''New Item added to stack'' element to top of the stack")]
    public string Add_Item_To_Stack(string input)
    {
        var result = StringStack.Push(input);
        return result;
    }

    [TestCase(ExpectedResult = "Removed no elements")]
    public string Remove_Item_From_Empty_Stack()
    {
        StringStack = new MyStack<string>();
        var result = StringStack.Pop();
        return result;
    }

    [TestCase("New Item added to stack", ExpectedResult = "Removed first element")]
    public string Add_Then_Remove_Item_From_Stack(string input)
    {
        StringStack.Push(input);
        return StringStack.Pop();
    }

    [TestCase(
        new object[] { "First Item", "Second Item" },
        ExpectedResult = "Second Item,First Item"
    )]
    public string Add_Then_Peek_Elements_On_Stack(object[] input)
    {
        StringStack = new MyStack<string>();
        var list = Array.ConvertAll(input, x => x.ToString());
        foreach (var element in list)
            StringStack.Push(element);

        var result = StringStack.Peek();
        return result;
    }

    [TestCase(new object[] { "First Item", "Second Item" }, ExpectedResult = "First Item")]
    public string Add_Pop_Then_Peek_Elements_On_Stack(object[] input)
    {
        StringStack = new MyStack<string>();
        var list = Array.ConvertAll(input, x => x.ToString());
        foreach (var element in list)
            StringStack.Push(element);

        StringStack.Pop();

        var result = StringStack.Peek();
        return result;
    }

    [TestCase(1, ExpectedResult = "Add ''1'' element to top of the stack")]
    public string Add_Item_To_Stack_Int(int input)
    {
        var result = IntStack.Push(input);
        return result;
    }

    [TestCase(new int[] { 0, 1, 2 }, ExpectedResult = "1,0")]
    public string Add_Pop_Then_Peek_Elements_On_Stack_Int(int[] input)
    {
        IntStack = new MyStack<int>();
        foreach (var element in input)
            IntStack.Push(element);

        IntStack.Pop();

        var result = IntStack.Peek();
        return result;
    }
}
