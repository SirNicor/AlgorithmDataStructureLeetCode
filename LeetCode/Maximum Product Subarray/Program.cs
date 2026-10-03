public static class Programm
{
    public static void Main()
    {
        var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Console.WriteLine(MaxProduct(nums));
    }
    
    public static int MaxProduct(int[] nums)
    {
        int max = Int32.MinValue, currentLess0 = -1, currentMore0 = -1;
        foreach (int num in nums)
        {
            if (currentMore0 < 0)
            {
                currentLess0 *= num;
                currentMore0 = num;
            }
            else
            {
                currentMore0 *= num;
            }
            if (firstLess0)
            {
                if (num < 0)
                {
                    currentLess0 += num;
                    
                }
                else
                {
                    currentMore0 *= num;
                    currentLess0 *= num;
                }
            }
            else
            {
                if (currentMore0 < 0)
                {
                    currentLess0 = currentLess0;
                    currentMore0 = num;
                }
                else
                {
                    currentMore0 *= num;
                }
            }
        }

        return max;
    }
}