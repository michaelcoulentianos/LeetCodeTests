namespace LeetCodeTests.classes.CommonLogic.StringManipulations
{
    public class ReverseString
    {
        public static string Invoke(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}