public static class Progrmm
{
    public static void Main()
    {
        var s = Console.ReadLine();
        Console.WriteLine(CheckValidString(s));
    }
    
    public static bool CheckValidString(string s)
    {
        int open = 0, close = 0, other = 0;
        foreach (char c in s)
        {
            if (c == '(')
            {
                open++;
            }
            else if (c == ')')
            {
                close++;
            }
            else
            {
                other++;
            }

            if (close > open + other)
            {
                return false;
            }
        }

        open = 0;
        close = 0; 
        other = 0;
        for (int i = s.Length-1; i >= 0; i--)
        {
            if (s[i] == '(')
            {
                open++;
            }
            else if (s[i] == ')')
            {
                close++;
            }
            else
            {
                other++;
            }
            
            if (open > close + other)
            {
                return false;
            }
        }

        return true;
    }
}