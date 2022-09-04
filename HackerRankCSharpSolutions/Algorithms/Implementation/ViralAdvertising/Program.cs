int n = 3;
int result = Result.ViralAdvertising(n);
Console.WriteLine(result);

class Result
{
    /*
     * Complete the 'viralAdvertising' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER n as parameter.
     */
    public static int ViralAdvertising(int n)
    {
        int shared = 5;
        int liked = 0;

        for (int i = 0; i < n; i++)
        {
            var likedPerDay = shared / 2;
            shared = likedPerDay * 3;
            liked += likedPerDay;
        }

        return liked;
    }
}
