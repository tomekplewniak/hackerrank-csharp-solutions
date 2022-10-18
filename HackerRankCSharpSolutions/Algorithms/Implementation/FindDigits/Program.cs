int n = 1012;
int result = Result.FindDigits(n);

Console.WriteLine(result);

class Result
{
    /*
     * Complete the 'findDigits' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER n as parameter.
     */
    public static int FindDigits(int n)
    {
        var charArray = n.ToString()
            .ToArray();

        var counter = 0;
        foreach (var c in charArray)
        {
            var number = int.Parse(c.ToString());
            if (number == 0)
            {
                continue;
            }

            if (n % number == 0)
            {
                counter++;
            }
        }

        return counter;
    }
}
