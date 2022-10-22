int n = 9;
var testData = "10 20 20 10 10 30 50 10 20";

List<int> ar = testData.Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();
int result = Result.SockMerchant(n, ar);

Console.WriteLine(result);

class Result
{

    /*
     * Complete the 'sockMerchant' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER_ARRAY ar
     */

    public static int SockMerchant(int n, List<int> ar)
    {

    }
}
