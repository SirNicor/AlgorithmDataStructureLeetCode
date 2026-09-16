public static class Programm
{
    public static void Main()
    {
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var res = ThreeSum(nums);
        foreach (var num in res)
        {
            foreach (var num2 in num)
            {
                Console.Write(num2 + " ");
            }
            Console.WriteLine();
        }
    }
    
    public static IList<IList<int>> ThreeSum(int[] nums) {
        nums.Sort();
        IList<IList<int>> result = new List<IList<int>>();
        int length = nums.Length;
        for (int i = 0; i < length-2; i++)
        {
            if (i != 0)
            {
                if (nums[i] == nums[i - 1])
                {
                    continue;
                }
            }
            int left = i + 1, right = length-1, target = -nums[i];
            while (left < right)
            {
                if (nums[left] == nums[left - 1] && i!=left-1)
                {
                    left++;
                    continue;
                }

                if (right != length - 1)
                {
                    if (nums[right] == nums[right + 1])
                    {
                        right--;
                        continue;
                    }
                }
                int subNumber = nums[left] + nums[right];
                if (subNumber == target)
                {
                    result.Add(new List<int>{ nums[i], nums[left], nums[right] });
                    left++;
                    right--;
                    continue;
                }

                if (subNumber > target)
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }
        }
        return result;
    }
}