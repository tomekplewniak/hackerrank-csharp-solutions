int n = Convert.ToInt32(Console.ReadLine().Trim());
Result.Staircase(n);

class Result
{

    /*
     * Complete the 'staircase' function below.
     *
     * The function accepts INTEGER n as parameter.
     */

    public static void Staircase(int n)
    {
        string staircase = "";
        string mark = "#";
        for (int i = 0; i <= n - 1; i++)
        {
            staircase += mark;
            Console.WriteLine(staircase.PadLeft(n));
        }
    }

}