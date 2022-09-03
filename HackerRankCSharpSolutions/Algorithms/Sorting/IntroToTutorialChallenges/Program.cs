int v = 4;
List<int> arr = "1 4 5 7 9 12".TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

int result = Result.IntroTutorial(v, arr);
Console.WriteLine(result);

class Result
{
    /*
     * Complete the 'introTutorial' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER V
     *  2. INTEGER_ARRAY arr
     */
    public static int IntroTutorial(int v, List<int> arr)
    {
        var index = arr.IndexOf(v);

        return index;
    }
}
