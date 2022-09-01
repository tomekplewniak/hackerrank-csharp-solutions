var testData = "5 4 4 2 2 8";

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
        List<int> cutSticks = new List<int> { arr.Count };

        while (arr.GroupBy(x => x).Count() > 1)
        {
            int t = 0;
            int minValue = arr[0];

            List<int> a = new List<int>();

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] <= minValue)
                    minValue = arr[i];

            }

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] - minValue > 0)
                {
                    a.Add(arr[i] - minValue);
                    t++;
                }
            }

            arr = a;
            cutSticks.Add(t);
        }

        return cutSticks;
    }
}
