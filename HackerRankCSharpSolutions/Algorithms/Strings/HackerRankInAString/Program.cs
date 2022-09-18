string s = "rhbaasdndfsdskgbfefdbrsdfhuyatrjtcrtyytktjjt";

string result = Result.HackerrankInString(s);
Console.WriteLine(result);

class Result
{
    /*
     * Complete the 'hackerrankInString' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string HackerrankInString(string s)
    {
        const string searchWord = "hackerrank";

        if (string.IsNullOrEmpty(s) || s.Length < searchWord.Length)
            return "NO";

        int matched = 0;

        for (int i = 0, j = 0; i < s.Length; i++)
        {
            if (s[i] == searchWord[j])
            {
                matched++;
                j++;
            }

            if (matched == searchWord.Length)
                return "YES";
        }
        return "NO";
    }
}
