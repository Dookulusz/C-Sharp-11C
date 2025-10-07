/*
int szam = 1234567123;
bool isPrime = true;

for (int i = 2; i < szam + 1; i++)
{
    if (szam % i == 0)
    {
        isPrime = false;
        Console.WriteLine($"Ezzel a számmal osztahtó: {i}");
        break;
    }
    Console.WriteLine(i);
}

if (isPrime)
{
    Console.WriteLine("Prím");
}
else
{
    Console.WriteLine("nem pírm");
}
*/
long egyik = 0;
long masik = 0;

for (int i = 0; i < 50; i++)
{
    long következő = egyik + masik;

    egyik = masik;

    masik = következő;
}
Console.WriteLine(egyik);
Console.WriteLine(masik);