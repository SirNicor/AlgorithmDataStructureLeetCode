using System.ComponentModel.Design;

public static class Programm
{
    public static void Main()
    {
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int target = int.Parse(Console.ReadLine());
        Console.WriteLine(MinSumOfLengths(arr, target));
    }
    public static int MinSumOfLengths(int[] arr, int target)
    {
        int left = 0, right = 0, sum = arr[left], minRes = int.MaxValue, length = arr.Length;
        int[] leftRight =  new int[length], rightLeft = new int[length];
        leftRight[0] = 0;
        rightLeft[length - 1] = 0;
        while (right < length - 1)
        {
            if (sum == target)
            {
                int len = right - left + 1;
                if (leftRight[right] != 0)
                {
                    leftRight[right + 1] = len > leftRight[right] ? leftRight[right] : len;
                }
                else
                {
                    leftRight[right + 1] = len;
                }
                sum -= arr[left];
                left++;
            }
            else
            {
                leftRight[right + 1] = leftRight[right];
            }
            if (left == right)
            {
                right++;
                sum += arr[right];
            }
            else if (sum > target)
            {
                sum  -= arr[left];
                left++;
            }
            else
            {
                right++;
                sum += arr[right];
            }
        }
        
        left = length - 1;
        right = length - 1;
        sum = arr[left];
        while (right > 0)
        {
            if (sum == target)
            {
                int len =  left - right + 1;
                if (rightLeft[right] != 0)
                {
                    rightLeft[right-1] = len > rightLeft[right] ? rightLeft[right] : len; 
                }
                else
                {
                    rightLeft[right - 1] = len; 
                }
                sum -= arr[left];
                left--;
            }
            else
            {
                rightLeft[right - 1] = rightLeft[right];
            }
            if (left == right)
            {
                right--;
                sum += arr[right];
            }
            else if (sum > target)
            {
                sum -= arr[left];
                left--;
            }
            else
            {
                right--;
                sum += arr[right];
            }
        }

        for (int i = 0; i < length-1; i++)
        {
            if (leftRight[i+1] == 0 || rightLeft[i] == 0)
            {
                continue;
            }
            minRes = minRes > rightLeft[i] + leftRight[i+1] ? rightLeft[i] + leftRight[i+1] : minRes;
        }

        return minRes == int.MaxValue ? -1 : minRes;
    }
}