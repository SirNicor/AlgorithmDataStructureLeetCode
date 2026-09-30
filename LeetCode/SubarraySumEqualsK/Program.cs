using System.Runtime.InteropServices.ComTypes;

public static class Programm
{
    public static void Main()
    {
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine(SubarraySum(nums, k));
    }
    
    public static int SubarraySum(int[] nums, int k)
    {
        int count = 0, prefixSum = 0;
        Dictionary<int, int> dict = new Dictionary<int, int>();
        dict.Add(0, 1);
        foreach (var t in nums)
        {
            prefixSum += t;
            int diff = prefixSum - k;
            if (dict.TryGetValue(diff, out int value))
            {
                count += value;
            }

            if (!dict.TryAdd(prefixSum, 1))
            {
                dict[prefixSum]++;
            }
        }
        return count;
    }
}