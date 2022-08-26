var testData = "10 5 20 20 4 5 2 25 1";

List<int> scores = testData.TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();
List<int> result = Result.BreakingRecords(scores);

Console.WriteLine(String.Join(" ", result));

class Result
{
    /*
     * Complete the 'breakingRecords' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY scores as parameter.
     */

    public static List<int> BreakingRecords(List<int> scores)
    {

    }
}