public static class Programm
{
    public static void Main()
    {
        var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var result = ProductExceptSelf(nums);
        foreach (var num in result)
        {
            Console.Write(num + " ");
        }
    }
    
    public static int[] ProductExceptSelf(int[] nums) {
        int[] result = new int[nums.Length];
        int suffix = 1;
        result[0] = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            result[i] = result[i - 1] * nums[i-1];
        }
        
        for (int i = nums.Length-1; i >= 0; i--)
        {
            result[i] *= suffix;
            suffix *= nums[i];
        }

        return result;
    }
}