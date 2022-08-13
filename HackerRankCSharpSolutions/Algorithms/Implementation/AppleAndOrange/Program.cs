using System;

string[] firstMultipleInput = "7 11".TrimEnd().Split(' ');
int s = Convert.ToInt32(firstMultipleInput[0]);
int t = Convert.ToInt32(firstMultipleInput[1]);

string[] secondMultipleInput = "5 15".TrimEnd().Split(' ');
int a = Convert.ToInt32(secondMultipleInput[0]);
int b = Convert.ToInt32(secondMultipleInput[1]);

string[] thirdMultipleInput = "3 2".TrimEnd().Split(' ');
int m = Convert.ToInt32(thirdMultipleInput[0]);
int n = Convert.ToInt32(thirdMultipleInput[1]);

List<int> apples = "-2 2 1".TrimEnd().Split(' ').ToList().Select(applesTemp => Convert.ToInt32(applesTemp)).ToList();
List<int> oranges = "5 -6".TrimEnd().Split(' ').ToList().Select(orangesTemp => Convert.ToInt32(orangesTemp)).ToList();

Result.CountApplesAndOranges(s,
    t,
    a,
    b,
    apples,
    oranges);


class Result
{
    /*
     * Complete the 'countApplesAndOranges' function below.
     *
     * The function accepts following parameters:
     *  1. INTEGER s
     *  2. INTEGER t
     *  3. INTEGER a
     *  4. INTEGER b
     *  5. INTEGER_ARRAY apples
     *  6. INTEGER_ARRAY oranges
     */

    public static void CountApplesAndOranges(int s,
        int t, 
        int a, 
        int b, 
        List<int> apples, 
        List<int> oranges)
    {
        var applesCount = 0;
        var orangesCount = 0;

        foreach (var apple in apples)
        {
            var position = a + apple;
            if (position >= s && position <= t)
            {
                applesCount++;
            }
        }

        foreach(var orange in oranges)
        {
            var position = b + orange;
            if (position >= s && position <= t)
            {
                orangesCount++;
            }
        }

        Console.WriteLine(applesCount);
        Console.WriteLine(orangesCount);
    }
}