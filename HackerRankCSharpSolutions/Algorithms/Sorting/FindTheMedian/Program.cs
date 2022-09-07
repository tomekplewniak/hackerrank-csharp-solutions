var testData = "0 1 2 4 6 5 3";
List<int> arr = testData.TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
int result = Result.FindMedian(arr);
Console.WriteLine(result);

class Result
{
    /*
     * Complete the 'findMedian' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */
    public static int FindMedian(List<int> arr)
    {
        var count = arr.Count();
        arr.Sort();

        var mediana = arr[count / 2];
        return mediana;
    }
}
