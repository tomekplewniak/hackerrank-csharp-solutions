string testData = "1 2 3 4 10 11";

List<int> ar = testData.TrimEnd().Split(' ')
    .ToList()
    .Select(arTemp => Convert.ToInt32(arTemp))
    .ToList();

int result = Result.SimpleArraySum(ar);
Console.WriteLine(result);

class Result
{
    /*
     * Complete the 'simpleArraySum' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY ar as parameter.
     */

    public static int SimpleArraySum(List<int> ar)
    {
    }
}
