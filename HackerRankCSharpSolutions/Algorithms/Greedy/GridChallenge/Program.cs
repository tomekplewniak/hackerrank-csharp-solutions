using System.Collections.Immutable;

int t = 5;
List<string> grid = new List<string>
{
    "ebacd",
    "fghij",
    "olmkn",
    "trpqs",
    "xywuv"
};


for (int tItr = 0; tItr < t; tItr++)
{
    string result = Result.GridChallenge(grid);
    Console.WriteLine(result);
}

class Result
{
    /*
     * Complete the 'gridChallenge' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING_ARRAY grid as parameter.
     */

    public static string GridChallenge(List<string> grid)
    {
        var arraysCount = grid.Count;
        var arrayLength = grid[0].Length;
        var arrays = new List<char[]>();
        foreach (var arr in grid.Select(val => val.ToCharArray()))
        {
            Array.Sort(arr);
            arrays.Add(arr);
        }

        for (var i = 0; i < arrayLength; i++)
        {
            var j = 0;
            while (j < arraysCount - 1)
            {
                if (arrays[j][i] > arrays[j + 1][i])
                    return "NO";
                j++;
            }
        }

        return "YES";
    }
}
