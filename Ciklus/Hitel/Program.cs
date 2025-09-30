int egyenleg = 10_000;
int kalap = 2;
int felvétel;

Console.WriteLine("Pénzfelvétel");

while (egyenleg > 0)
{
    Console.Write("Mennyi összeget szertnél levenni?");
    felvétel = int.Parse(Console.ReadLine());

    if (felvétel > egyenleg)
    {
        Console.WriteLine("Túl sok az felvevendő pénz");
        break;
    }

    egyenleg = egyenleg - felvétel;
    kalap = kalap - 1;

    if (kalap >= 0)
    {
        Console.WriteLine($"Még ennyi ingyenes pénzfelvtélel maradt {kalap}");
    }
    else
    {
        Console.WriteLine("100Ft kezelési költséget levontunk");
        egyenleg = egyenleg - 100;
    }

    Console.WriteLine($"Jelenlegi egyenleged: {egyenleg}");
}
Console.WriteLine("Elfogyott a pénzed :(");