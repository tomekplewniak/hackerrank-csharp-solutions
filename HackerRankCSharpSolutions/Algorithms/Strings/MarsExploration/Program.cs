
string s = "SOSOOSOSOSOSOSSOSOSOSOSOSOS";

int result = Result.MarsExploration(s);
Console.WriteLine(result);

class Result
{
    /*
     * Complete the 'marsExploration' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING s as parameter.
     */
    public static int MarsExploration(string s)
    {
        char[] sos = new char[] { 'S', 'O', 'S' };
        
        var length = s.Length;
        var index = 3;
        var globalDiff = 0;

        for (int i = 0; i < length / 3; i++)
        {
            int diff = 0;
            IEnumerable<char> partOfMessage;

            if (index == 3)
            {
                partOfMessage = s.Take(index);    
            }
            else
            {
                partOfMessage = s.Skip(index - 3).Take(index - (index - 3));
            }
            
            index += 3;

            for (int c = 0; c < 3; c++)
            {
                if (sos[c] != partOfMessage.ToArray()[c])
                {
                    diff ++;
                }
            }

            globalDiff += diff;
        }

        return globalDiff;
    }
}
