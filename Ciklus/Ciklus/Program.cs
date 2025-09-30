/* ELŐTESZTELŐS ciklus
 * 
 * Amíg a feltétel teljesül ismételjük
 * 
 * while (valamilye feltétel)
 *  {
 *      //utasítások
 *  }
 */

Console.Write("Username: ");

string username = string.Empty;

while (username == string.Empty)
{
    Console.Clear();
    Console.Write("Username: ");
    username = Console.ReadLine();
}
Console.WriteLine($"Üdv {username}");



