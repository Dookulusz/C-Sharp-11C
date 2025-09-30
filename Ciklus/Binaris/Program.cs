/* BINÁRIS ÁTVÁTLÓ
 * -kérjünk be egy pozitív egész számot
 */
int deci;
int maradék;
string bináris = string.Empty;

Console.Write("Add meg a számot: ");
deci = int.Parse(Console.ReadLine());

while (deci > 0)
{
    //számoljuk ki a maradékát
    maradék = deci % 2;

    //fűzzük hozzá az eredményhez trükkfejmókus módon
    bináris = maradék + bináris;

    //(technikailag erre nincs szükség)
    deci = deci - maradék;

    //felezzük meg a számot
    deci = deci / 2;
}
Console.Write(bináris);





