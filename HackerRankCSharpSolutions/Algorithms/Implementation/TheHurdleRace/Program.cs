int n = 5;
int k = 4;

var testData = "1 6 3 5 2";

List<int> height = testData.TrimEnd().Split(' ').ToList()
    .Select(heightTemp => Convert.ToInt32(heightTemp)).ToList();

int result = Result.HurdleRace(k, height);

Console.WriteLine(result);

class Result
{
    /*
     * Complete the 'hurdleRace' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER k
     *  2. INTEGER_ARRAY height
     */

    public static int HurdleRace(int k, List<int> height)
    {
        int drinks = 0;

        var max = height.Max();

        if (max > k)
        {
            drinks = max - k;
        }

        return drinks;
    }
}
