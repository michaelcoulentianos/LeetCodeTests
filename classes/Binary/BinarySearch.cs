namespace LeetCodeTests.classes.Binary;

public class BinarySearch
{
    public static int Search(int[] nums, int target)
    {
        if (nums is null) return -1;
        if (!nums.Contains(target)) return -1;

        int length = nums.Length;

        if (length == 1 && nums[0] == target) return 0;

        for (int i = 0, size = (length / 2) + length % 2; i < size; i++)
        {
            var first = nums[i];
            if (first == target) return i;
            var last = nums[--length];
            if (last == target) return length;

            if (i >= length) return -1;
        }

        return -1;
    }
}
