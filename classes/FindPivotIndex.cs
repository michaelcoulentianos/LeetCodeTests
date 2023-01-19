namespace tests;

public class FindPivotIndex
{
     public static int PivotIndex(int[] nums) {
        var first = 0;
        var second = 0;

        //loop through nums array
        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];
            var counter = 0;
            var left = 0;
            var right = nums.Length - 1;

            while (left < right)
            {
                if (left != i) first += nums[left];
                if (right != i) second += nums[right];
                if (left < i) left = ++counter;
                if (right > i) right -= 1;
            }

            if (i == 0) first = 0;
            if (first == second) 
            return i;
            else 
            {
                first = 0;
                second = 0;
            }
        }    

        return -1;
    }
}