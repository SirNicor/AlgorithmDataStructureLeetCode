public static class Progrmm
{
    public static void Main()
    {
        Console.WriteLine(ReverseDegree(Console.ReadLine()));
    }

    public static int ReverseDegree(string s)
    {
        int res = 0;
        for (int i = 0; i < s.Length; i++)
        {
            int x = 'z' - s[i] + 1;
            res += (i + 1) * x;
        }

        return res;
    }
}