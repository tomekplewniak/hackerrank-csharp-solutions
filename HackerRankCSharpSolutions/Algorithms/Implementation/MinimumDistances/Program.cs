List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
int result = Result.minimumDistances(a);
Console.WriteLine(result);

class Result
{
    /*
     * Complete the 'minimumDistances' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter.
     */
    public static int minimumDistances(List<int> a)
    {

    }
}
