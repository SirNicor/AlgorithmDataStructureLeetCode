using System.CodeDom.Compiler;

public static class Programm
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var result = GenerateParenthesis(n);
        foreach (var item in result)
        {
            Console.Write(item + " ");
        }
    }
    
    public static IList<string> GenerateParenthesis(int n) {
        List<string> result = new List<string>();
        Generate(result, n, 0, 0, "");
        return result;
    }
    
    private static void Generate(List<string> result, int n, int open, int close, string current) {
        if (current.Length == n * 2) {
            result.Add(current);
            return;
        }
        
        if (open < n) {
            Generate(result, n, open + 1, close, current + "(");
        }
        
        if (close < open) {
            Generate(result, n, open, close + 1, current + ")");
        }
    }
}