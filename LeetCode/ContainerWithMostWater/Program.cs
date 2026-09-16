public static class Programm
{
    public static void Main()
    {
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Console.WriteLine(MaxArea(arr));
    }
    
    public static int MaxArea(int[] height) {
        int sMax = 0, left = 0, right = height.Length - 1;
        while (left < right)
        {
            int s = (height[left] < height[right] ? height[left] : height[right]) * (right - left);
            if (s > sMax)
            {
                sMax = s;
            }

            if (height[left] < height[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }
        return sMax;
    }
}