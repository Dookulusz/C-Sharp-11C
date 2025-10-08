using System.Diagnostics;
using System.Net.WebSockets;

int szam = int.Parse(Console.ReadLine());
int prime = 0;


for (int i = 2; i < szam; i++)
{

    if (szam % i == 0)
    {
        Console.WriteLine($"{i}-vel/val oszahtó");
        prime++;
    }

}
Console.WriteLine(prime);
if (prime == 0)
{
    Console.WriteLine("Prím");
}
else
{
    Console.WriteLine("Nem prím");
}



