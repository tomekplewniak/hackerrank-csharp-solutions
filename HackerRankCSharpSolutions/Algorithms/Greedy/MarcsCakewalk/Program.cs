var testData = "5 10 7";

List<int> calorie = testData.TrimEnd().Split(' ').ToList().Select(calorieTemp => Convert.ToInt32(calorieTemp)).ToList();

long result = Result.MarcsCakewalk(calorie);
Console.WriteLine(result);

class Result
{
    /*
     * Complete the 'marcsCakewalk' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts INTEGER_ARRAY calorie as parameter.
     */

    public static long MarcsCakewalk(List<int> calorie)
    {
        long result = 0;

        calorie.Sort();
        calorie.Reverse();

        for (int i = 0; i < calorie.Count; i++)
        {
            var calculateCal = Math.Pow(2, i) * calorie[i];
            result += Convert.ToInt64(calculateCal);
        }

        return result;
    }
}