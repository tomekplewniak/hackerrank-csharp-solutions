string aTestData = "5 6 7";
string bTestData = "3 6 10";

List<int> a = aTestData.TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
List<int> b = bTestData.TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();
List<int> result = Result.CompareTriplets(a, b);

Console.WriteLine(String.Join(" ", result));

class Result
{

    /*
     * Complete the 'compareTriplets' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */

    public static List<int> CompareTriplets(List<int> a, List<int> b)
    {

    }

}
