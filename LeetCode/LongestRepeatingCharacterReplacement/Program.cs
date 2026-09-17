public static class Programm
{
    public static void Main()
    {
        var s = Console.ReadLine();
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine(CharacterReplacement(s, k));
    }

    public static int CharacterReplacement(string s, int k)
    {
        int count = 1, maxChar = 1, maxCount = 1, left = 0, right = 0;
        Dictionary<char, int> dict = new Dictionary<char, int>();
        dict.Add(s[0], 1);
        while (right < s.Length-1)
        {
            right++;
            count++;
            char c = s[right];
            if (!dict.TryAdd(c, 1))
            {
                dict[c]++;
            }
            maxChar = maxChar > dict[c] ?  maxChar : dict[c];
            if (count - maxChar > k)
            {
                dict[s[left]]--;
                left++;
                count--;
            }
            maxCount = maxCount > count ? maxCount : count;
        }
        return maxCount;
    }
}