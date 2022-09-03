int n = 4;
int k = 1;

List<int> bill = "3 10 2 9".TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();
int b = 7;

Result.BonAppetit(bill, k, b);

class Result
{
    /*
     * Complete the 'bonAppetit' function below.
     *
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY bill
     *  2. INTEGER k
     *  3. INTEGER b
     */

    public static void BonAppetit(List<int> bill, int k, int b)
    {
        var sharedBill = bill.Sum() - bill[k];

        if ((sharedBill / 2) == b)
        {
            Console.WriteLine("Bon Appetit");
        }
        else
        {
            Console.WriteLine($"{b - (sharedBill / 2)}");
        }
    }
}
