public static class Programm
{
    public static void Main()
    {
        var s = Console.ReadLine();
        Console.WriteLine(LongestValidParentheses(s));
    }

    public static int LongestValidParentheses(string s)
    {
        if (s.Length == 0 || s.Length == 1)
        {
            return 0;
        }

        int open = 0, close = 0, maxLength = 0;
        foreach (var c in s)
        {
            if (c == '(')
            {
                open++;
            }
            else
            {
                close++;
            }

            if (open == close)
            {
                maxLength = maxLength > open*2 ? maxLength : open*2;
            }
            else if(close > open)
            {
                open = close = 0;
            }
        }

        open = close = 0;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] == ')')
            {
                close++;
            }
            else
            {
                open++;
            }

            if (open == close)
            {
                maxLength = maxLength > close*2 ? maxLength : close*2;
            }
            else if (open > close)
            {
                open = close = 0;
            }
        }
        
        return maxLength;
    }
}