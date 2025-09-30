/* BINÁRIS ÁTVÁTLÓ
 * -kérjünk be egy pozitív egész számot
 */
int deci;
int maradék;

Console.Write("Add meg a számot: ");
deci = int.Parse(Console.ReadLine());

while (deci > 0)
{
    maradék = deci % 2;

    Console.WriteLine(maradék);

    deci = deci - maradék;

    deci = deci / 2;
}





