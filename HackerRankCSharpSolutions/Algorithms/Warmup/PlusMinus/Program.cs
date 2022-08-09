var testData = "-4 3 -9 0 4 1";
List<int> arr = testData.TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
Result.PlusMinus(arr);

class Result
{
    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */
    public static void PlusMinus(List<int> arr)
    {
        var positive = 0;
        var negative = 0;
        var zeros = 0;
        var count = arr.Count();

        foreach (var item in arr)
        {
            switch (item)
            {
                case > 0:
                    positive++;
                    break;
                case < 0:
                    negative++;
                    break;
                case 0:
                    zeros++;
                    break;
            }
        }

        double positiveRatio = Convert.ToDouble(positive) / count;
        double negativeRatio = Convert.ToDouble(negative) / count;
        double zeroRatio = Convert.ToDouble(zeros) / count;

        Console.WriteLine($"{Math.Round(positiveRatio, 6)}");
        Console.WriteLine($"{Math.Round(negativeRatio, 6)}");
        Console.WriteLine($"{Math.Round(zeroRatio, 6)}");
    }
}
