var s = "saveChangesInTheEditor";
int result = Result.CamelCase(s);

class Result
{
    /*
     * Complete the 'camelcase' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING s as parameter.
     */

    public static int CamelCase(string s)
    {
        var countWords = (from c in s
                     where char.IsUpper(c)
                     select c)
                     .Count();

        return countWords;
    }
}
