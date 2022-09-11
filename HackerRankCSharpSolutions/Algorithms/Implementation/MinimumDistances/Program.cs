var testData = "7 1 3 4 1 7";
List<int> a = testData.TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
int result = Result.MinimumDistances(a);
Console.WriteLine(result);

class Result
{
    /*
     * Complete the 'minimumDistances' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter.
     */
    public static int MinimumDistances(List<int> a)
    {

    }
}
