string testData = "1000000001 1000000002 1000000003 1000000004 1000000005";

List<long> ar = testData.TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt64(arTemp)).ToList();

long result = Result.AVeryBigSum(ar);
Console.WriteLine(result);

class Result
{
    /*
     * Complete the 'aVeryBigSum' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts LONG_INTEGER_ARRAY ar as parameter.
     */

    public static long AVeryBigSum(List<long> ar)
    {
        throw new NotImplementedException();
    }
}
