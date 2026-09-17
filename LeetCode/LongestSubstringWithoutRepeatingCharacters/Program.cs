using System.Text;

public static class Programm
{
    public static void Main()
    {
        string s = Console.ReadLine();
        Console.WriteLine(LengthOfLongestSubstring(s));
    }
    
    public static int LengthOfLongestSubstring(string s) {
        int maxLength = 0,left = 0, right = 0;
        Dictionary<char, int> dict = new Dictionary<char, int>();
        while(right < s.Length)
        {
            if (!dict.TryAdd(s[right], 1))
            {
                dict.Remove(s[left]);
                left++;
                continue;
            }
            maxLength = (maxLength>right-left+1)?maxLength:(right-left+1);
            right++;
        }

        return maxLength;
    }
}