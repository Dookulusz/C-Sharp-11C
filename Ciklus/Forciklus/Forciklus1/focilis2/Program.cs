Console.Write("Adj meg egy egész számot: ");
int szam = int.Parse(Console.ReadLine());
int eredmény = 0;
int szamjegy;
szam /= 10;

for (int i = 1;i < 9 ; i++)
{
    szamjegy = szam % 10;

    eredmény += szamjegy;

    szam = szam / 10;
}
Console.WriteLine(eredmény);