﻿
int arrCount = Convert.ToInt32(Console.ReadLine().Trim());
List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
List<int> res = Result.ReverseArray(arr);
Console.WriteLine(String.Join(" ", res));

class Result
{

    /*
     * Complete the 'reverseArray' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY a as parameter.
     */

    public static List<int> ReverseArray(List<int> a)
    {

    }
}
