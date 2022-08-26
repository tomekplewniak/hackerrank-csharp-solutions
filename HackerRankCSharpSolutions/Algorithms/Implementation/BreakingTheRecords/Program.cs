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
        int highestScore = scores.First();
        int higestScoreChangeCounter = 0;
        int lowestScore = scores.First();
        int lowestScoreChangeCounter = 0;

        foreach (var score in scores)
        {
            if (score > highestScore)
            {
                highestScore = score;
                higestScoreChangeCounter++;
            }

            if (score < lowestScore)
            {
                lowestScore = score;
                lowestScoreChangeCounter++;
            }
        }

        return new List<int>()
        {
            higestScoreChangeCounter,
            lowestScoreChangeCounter
        };
    }
}