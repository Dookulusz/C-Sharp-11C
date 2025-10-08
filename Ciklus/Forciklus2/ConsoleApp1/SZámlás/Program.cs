int szam = int.Parse(Console.ReadLine());

for (int i = 1; i < szam + 1; i++)
{
    for (int j = 1; j < szam + 1; j++)
    {
        int szorzat = i * j;

        if (szorzat < 10)
        {
            Console.Write(" ");
        }
        Console.Write($"{szorzat} ");

    }
    Console.Write("\n");
    
}