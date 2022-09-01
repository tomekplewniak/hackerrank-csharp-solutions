
int V = Convert.ToInt32(Console.ReadLine().Trim());
int n = Convert.ToInt32(Console.ReadLine().Trim());

List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

int result = Result.introTutorial(V, arr);

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
    public static int introTutorial(int V, List<int> arr)
    {

    }
}
