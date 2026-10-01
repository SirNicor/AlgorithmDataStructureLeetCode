using System.Diagnostics.SymbolStore;

public static class Programm
{
    public static void Main()
    {
        var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var k = int.Parse(Console.ReadLine());
        Console.WriteLine(NumSubarrayProductLessThanK(nums, k));
    }

    public static int NumSubarrayProductLessThanK(int[] nums, int k)
    {
        int count = 0, left = 0;
        long product = 1;
        for(int right = 0; right<nums.Length; right++)
        {
            bool check = false;
            product *= nums[right];
            while (product >= k)
            {
                if (left == right)
                {
                    check = true;
                    break;
                }
                product /= nums[left];
                left++;
            }

            if (check)
            {
                continue;
            }
            count += right - left + 1;
        }
        return count;
    }
}