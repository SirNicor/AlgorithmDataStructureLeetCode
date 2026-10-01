public static class Programm
{
    public static void Main()
    {
        var s = Console.ReadLine();
        Console.WriteLine(IsValid(s));
    }
    
    public static bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
        Dictionary<char, char> dict = new Dictionary<char, char>()
        {
            {'(', ')'},
            {'{', '}'},
            {'[', ']'}
        };
        foreach (char c in s)
        {
            if (c == '(' || c == '{' || c == '[')
            {
                stack.Push(c);
            }
            else
            {
                if (stack.Count == 0)
                {
                    return false;
                }
                char k = stack.Pop();
                if (dict[k] != c)
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }
}