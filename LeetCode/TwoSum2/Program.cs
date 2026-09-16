public static class Program
{
    public static void Main()
    {
        int[] twoSumArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int target = Convert.ToInt32(Console.ReadLine());
        twoSumArray = TwoSum(twoSumArray, target);
        foreach (int num in twoSumArray)
        {
            Console.WriteLine(num);
        }
    }
    
    public static int[] TwoSum(int[] numbers, int target) {
        int left = 0, right = numbers.Length - 1;
        while (left < right)
        {
            int subTarget = numbers[left] + numbers[right];
            if (subTarget == target)
            {
                return [left + 1, right + 1];
            }

            if (subTarget < target)
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return [-1, -1];
    }
}