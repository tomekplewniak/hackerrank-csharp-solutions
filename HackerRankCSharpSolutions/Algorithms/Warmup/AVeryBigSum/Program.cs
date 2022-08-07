string testData = "1000000001 1000000002 1000000003 1000000004 1000000005";

List<long> ar = testData.TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt64(arTemp)).ToList();

var result = Result.AVeryBigSum(ar);
Console.WriteLine(result);

var resultViaLinq = Result.AVeryBigSumViaLinq(ar);
Console.WriteLine(resultViaLinq);

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
        long sum = 0;
        foreach (long a in ar)
        {
            sum += a;
        }

        return sum;
    }

    public static long AVeryBigSumViaLinq(List<long> ar)
    {
        return ar.Sum();
    }
}
