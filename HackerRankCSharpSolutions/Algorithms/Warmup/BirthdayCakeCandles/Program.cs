var testData = "3 2 1 3";
List<int> candles = testData.TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

int result = Result.BirthdayCakeCandles(candles);
Console.WriteLine(result);

class Result
{

    /*
     * Complete the 'birthdayCakeCandles' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY candles as parameter.
     */
    public static int BirthdayCakeCandles(List<int> candles)
    {

    }

}