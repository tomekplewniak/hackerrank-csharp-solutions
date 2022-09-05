string s1 = "and";
string s2 = "art";
string result1 = Result.TwoStrings(s1, s2);
Console.WriteLine(result1);

string s3 = "be";
string s4 = "cat";
string result2 = Result.TwoStrings(s3, s4);
Console.WriteLine(result2);

class Result
{
    /*
     * Complete the 'twoStrings' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. STRING s1
     *  2. STRING s2
     */

    public static string TwoStrings(string s1, string s2)
    {
        var array1 = s1.ToArray();
        var array2 = s2.ToArray();

        var result = array1.Intersect(array2);

        if (result.Any())
        {
            return "YES";
        }

        return "NO";
    }
}
