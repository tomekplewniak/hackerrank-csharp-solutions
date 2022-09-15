string s = "aaabccddd";
string result = Result.SuperReducedString(s);
Console.WriteLine(result);

class Result
{
    /*
     * Complete the 'superReducedString' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */
    public static string SuperReducedString(string s)
    {
        Stack<char> stack = new Stack<char>();
        foreach (char c in s)
        {
            var last = stack.Any() ? stack.Peek() : char.MinValue;
            if (c == last) 
                stack.Pop();
            else stack.Push(c);
        }
        return stack.Any() ? new string(stack.Reverse().ToArray()) : "Empty String";
    }
}
