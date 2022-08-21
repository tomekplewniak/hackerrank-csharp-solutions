List<List<int>> arr = new List<List<int>>();

arr = new List<List<int>>()
{
    new List<int>()
    {
        11, 2, 4
    },
    new List<int>()
    {
        4, 5, 6
    },
        new List<int>()
    {
       10, 8, - 12
    }
};


int result = Result.DiagonalDifference(arr);
Console.WriteLine(result);

class Result
{
    /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */
    public static int DiagonalDifference(List<List<int>> arr)
    {
        int primaryDiagonal = 0;
        int secondaryDiagonal = 0;

        int length = arr.Count();

        for (int i = 0; i < length; i++)
        {
            primaryDiagonal += arr[i][i];
            secondaryDiagonal += arr[i][arr.Count() - i - 1];
        }

        return Math.Abs(primaryDiagonal - secondaryDiagonal);
    }
}
