string aTestData = "5 6 7";
string bTestData = "3 6 10";

List<int> a = aTestData.TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
List<int> b = bTestData.TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();
List<int> result = Result.CompareTriplets(a, b);

Console.WriteLine(String.Join(" ", result));

class Result
{
    private static readonly string _alice = "Alice";
    private static readonly string _bob = "Bob";

    /*
     * Complete the 'compareTriplets' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */

    public static List<int> CompareTriplets(List<int> a, List<int> b)
    {
        Dictionary<string, int> points = new Dictionary<string, int>();

        points.Add("Alice", 0);
        points.Add("Bob", 0);

        if (a.Count() != b.Count())
        {
            throw new ArgumentException("The provided data has diffrent length.");
        }

        for (int i = 0; i < a.Count; i++)
        {
            if (a[i] > b[i])
            {
                points[_alice] += 1;
            }
            else
            {
                if (a[i] == b[i])
                {
                    continue;
                }

                points[_bob] += 1;
            }
        }

        return new List<int>()
        {
            points[_alice],
            points[_bob]
        };
    }
}
