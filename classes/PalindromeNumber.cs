public class PalindromeNumber
{
    public static bool IsPalindrome(int x)
    {
        //Check if the number is negative then return false;
        if (x < 0) return false;
        //Convert to string
        var number = x.ToString();
        //Check if the digit is length 1 then return true

        //rotate the digits once equal the same then exist or left > right
        var left = 0;
        var right = number.Length - 1;

        while (left <= right)
        {
            var first = number[left];
            var last = number[right];

            if (first != last) 
            return false;

            left++;
            right--;
        }

        return true;
    }
}