public static class Programm
{
    public static void Main()
    {
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int target = int.Parse(Console.ReadLine());
        Console.WriteLine(ThreeSumClosest(nums, target));
    }
    
    public static int ThreeSumClosest(int[] nums, int target)
    {
        int minAround = int.MaxValue, length = nums.Length, sumRes = 0;
        nums.Sort();
        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (i != 0)
            {
                if (nums[i] == nums[i - 1])
                {
                    continue;
                }
            }

            int left = i + 1, right = length - 1;
            while (left < right)
            {
                int subsum = nums[i] + nums[left] + nums[right];
                int differenceAbs = Math.Abs(subsum - target);
                if(differenceAbs < minAround)
                {
                    minAround = differenceAbs;
                    sumRes = subsum;
                    if (minAround == 0)
                    {
                        break;
                    }
                }

                if (subsum > target)
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }
            if (minAround == 0)
            {
                break;
            }
        }

        return sumRes;
    }
}