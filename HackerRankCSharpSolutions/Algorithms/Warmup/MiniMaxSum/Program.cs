var testData = "1 2 3 4 5";
List<int> arr = testData.TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

Result.MiniMaxSum(arr);

class Result
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void MiniMaxSum(List<int> arr)
    {
        long min = arr.Min();
        long max = arr.Max();

        List<long> longArr = arr.ConvertAll(i => Convert.ToInt64(i));
        long sumOfTotalElements = longArr.Sum();
        long minimalSum = sumOfTotalElements - max;
        long maximalSum = sumOfTotalElements - min;

        Console.WriteLine($"{minimalSum} {maximalSum}");
    }
}
