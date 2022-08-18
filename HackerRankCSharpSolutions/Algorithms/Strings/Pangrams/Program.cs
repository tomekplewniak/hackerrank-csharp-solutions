using System;

string firstTestData = "We promptly judged antique ivory buckles for the next prize";
string secondTestData = "All of the letters of the alphabet are present in the string.";

string firstResult = Result.Pangrams(firstTestData);
string secondResult = Result.Pangrams(secondTestData);

Console.WriteLine(firstResult);
Console.WriteLine(secondResult);

class Result
{
    /*
     * Complete the 'pangrams' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string Pangrams(string s)
    {
        var letters = s.ToUpper()
            .Distinct();

        var count = 0;

        foreach(char c in letters)
        {
            if(c >= 65 && c <= 90)
            {
                count++;
            }
        }

        if (count == 26)
        {
            return "pangram";
        }

        return "not pangram";
    }
}
