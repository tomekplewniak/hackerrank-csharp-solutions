var testData = "1 2 3 4 3 3 2 1";

List<int> arr = testData.TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
List<int> result = Result.CutTheSticks(arr);

Console.WriteLine(String.Join("\n", result));

class Result
{
    /*
     * Complete the 'cutTheSticks' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static List<int> CutTheSticks(List<int> arr)
    {
        1 2 3 4 3 3 2 1
    }
}
