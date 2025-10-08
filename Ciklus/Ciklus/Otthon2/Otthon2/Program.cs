
int hanyszor = int.Parse(Console.ReadLine());
int összeg = 0;
int összegmin = hanyszor;
int szamok = 0;
Console.Clear();
/*
for (int i = 1; i <= hanyszor; i++)
{
    összeg += i;
    Console.WriteLine(összeg);
}
Console.WriteLine(összeg);
*/

for  (int j = hanyszor; j >= 1; j--)
{
    szamok += 1;
}
összegmin -= szamok;
Console.WriteLine(összegmin);