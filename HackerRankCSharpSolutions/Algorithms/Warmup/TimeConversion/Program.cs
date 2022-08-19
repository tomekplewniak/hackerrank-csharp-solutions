string s = "07:05:45PM";

string result = Result.TimeConversion(s);
Console.WriteLine(result);

class Result
{
    /*
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */
    public static string TimeConversion(string s)
    {
        DateTime time;
        var result = DateTime.TryParse(s, out time);

        if (result)
        {
            return time.TimeOfDay.ToString();
        }

        throw new ArgumentException("Provided hours in string isn't correct.");
    }
}
