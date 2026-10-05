using System.IO.Pipes;

public static class Programm
{
    public static void Main()
    {
        var s = Console.ReadLine();
        Console.WriteLine(ScoreOfParentheses(s));
    }
    
    public static int ScoreOfParentheses(string s)
    {
        int depth = 0, score = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
            {
                depth++;
            }
            else
            {
                depth--;
                if (s[i - 1] == '(')
                {
                    score += 1<<depth;
                }
            }
        }
        return score;
    }
}