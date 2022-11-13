var testData = "20 3 6 85";
string[] firstMultipleInput = testData.TrimEnd().Split(' ');

int p = Convert.ToInt32(firstMultipleInput[0]);
int d = Convert.ToInt32(firstMultipleInput[1]);
int m = Convert.ToInt32(firstMultipleInput[2]);
int s = Convert.ToInt32(firstMultipleInput[3]);

int answer = Result.HowManyGames(p, d, m, s);
Console.WriteLine(answer);

class Result
{
    /*
     * Complete the 'howManyGames' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER p
     *  2. INTEGER d
     *  3. INTEGER m
     *  4. INTEGER s
     */

    public static int HowManyGames(int p, int d, int m, int s)
    {
        int c = 0;
        while (s >= p)
        {
            c++;
            s -= p;
            p = p - d > m ? p - d : m;
        }
        return c;
    }
}

