public static class Programm
{
    public static void Main()
    {
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Console.WriteLine(FindSubarrays(nums));
    }
    
    public static bool FindSubarrays(int[] nums) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for (int i = 1; i < nums.Length; i++)
        {
            if (!dict.TryAdd(nums[i - 1] + nums[i], 1))
            {
                return true;
            };
        }

        return false;
    }
}