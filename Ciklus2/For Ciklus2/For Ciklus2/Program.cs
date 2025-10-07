/*
int col = 8;
int row = 8;
for (row = 0 ; row < 8; row++)
{
    for (col = 0; col < 8; col++)
    {
        if (col % 2 == row % 2)
        {
            Console.Write("■");
        }
        else
        {
            Console.Write(" ");
        }

    }
    Console.WriteLine();
}
*/

string palya = "";
int meret = 64;

for  (int i = 1; i != meret + 1; i++)
{
    if (i % 2 == 0)
    {
        palya += "☺";
    }
    else
    {
        palya += "☻";
    }

    if (i % 8 == 0)
    {

        palya += "\n";
    }
}
Console.Write(palya);
