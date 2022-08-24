
string[] xyz = "1 2 3".Split(' ');

int x = Convert.ToInt32(xyz[0]);
int y = Convert.ToInt32(xyz[1]);
int z = Convert.ToInt32(xyz[2]);

string result = CatAndMouse(x, y, z);

Console.WriteLine(result);


static string CatAndMouse(int x, int y, int z)
{
    var catA = 0;
    var catB = 0;

    catA = Math.Abs(x - z);
    catB = Math.Abs(y - z);

    if (catA < catB)
    {
        return "Cat A";
    }
    else
    {
        if (catA == catB)
        {
            return "Mouse C";
        }

        return "Cat B";
    }
}