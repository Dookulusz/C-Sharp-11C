int szam = int.Parse(Console.ReadLine());

int hossz = 0;

while (szam > 0)
{
    szam /= 10; // ugyanaz mint szam = szam / 10;
    hossz++;
}
Console.WriteLine(hossz);