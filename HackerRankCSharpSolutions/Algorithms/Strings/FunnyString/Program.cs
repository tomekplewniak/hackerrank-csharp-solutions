var testData = new List<string>
{
    "acxz",
    "bcxz"
};

foreach (var test in testData)
{
    string result = Result.FunnyString(test);

    Console.WriteLine(result);
}


class Result
{
    /*
     * Complete the 'funnyString' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */
    public static string FunnyString(string s)
    {
        for (int i = 0; i < s.Length - 1; i++)
        {
            if (Math.Abs((int)s[i] - s[i + 1]) != Math.Abs((int)s[s.Length - 1 - i] - (int)s[s.Length - 2 - i]))
                return "Not Funny";
        }

        return "Funny";
    }
}
