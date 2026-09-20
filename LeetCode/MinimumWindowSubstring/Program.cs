using System.Text;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine(MinWindow(Console.ReadLine(), Console.ReadLine()));
    }

    public static string MinWindow(string s, string t)
    {
        int lengthS = s.Length, lengthT = t.Length, left = 0, right = 0, minLength = int.MaxValue, leftRes = -1, rightRes = -1;
        if (lengthT > lengthS)
        {
            return "";
        }
        Dictionary<char, int> needDict = new Dictionary<char, int>(), formDict = new Dictionary<char, int>();
        foreach (char c in t)
        {
            if (!needDict.TryAdd(c, 1))
            {
                needDict[c]++;
            }
            else
            {
                formDict.Add(c, 0);
            }
        }

        int formCount = formDict.Count;
        if (formDict.TryGetValue(s[right], out var value))
        {
            formDict[s[right]] = ++value;
            if (formDict[s[right]] == needDict[s[right]] && formCount != 0)
            {
                formCount--;
            }
        }
        while (right < lengthS) 
        {
            if (formCount == 0)
            {
                if (minLength > right - left + 1)
                {
                    minLength = right - left + 1;
                    leftRes = left;
                    rightRes = right;
                    if (minLength == 1)
                    {
                        break;
                    }
                }

                if (formDict.TryGetValue(s[left], out var countChar))
                {
                    formDict[s[left]] = --countChar;
                    if (formDict[s[left]] < needDict[s[left]] )
                    {
                        formCount++;
                    }
                }
                left++;
            }
            else
            {
                right++;
                if (right == lengthS)
                {
                    break;
                }
                if (formDict.TryGetValue(s[right], out var countChar))
                {
                    formDict[s[right]] = ++countChar;
                    if (formDict[s[right]] == needDict[s[right]] && formCount != 0)
                    {
                        formCount--;
                    }
                }
            }
        }

        if (leftRes == -1 || rightRes == -1)
        {
            return "";
        }
        return s.Substring(leftRes, rightRes - leftRes + 1); 
    }
}