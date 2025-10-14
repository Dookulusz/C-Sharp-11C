// A pálya adatai
int width = 8;
int height = 8;

Console.BackgroundColor = ConsoleColor.Green;
Console.ForegroundColor = ConsoleColor.Red;

Console.Clear();

Console.WindowWidth = width;
Console.WindowHeight = height;


// játékos adatai
int row = 0; 
int col = 0;


// állítható a pozíció?


// a kurzort el is lehet rejteni
Console.CursorVisible = false;

Console.Write("☻");
var mitnyomottmeg = Console.ReadKey(true);

while (mitnyomottmeg.Key != ConsoleKey.Escape)
{
    mitnyomottmeg = Console.ReadKey(true);

    Console.Clear();

    Console.CursorLeft = col;
    Console.CursorTop = row;

    Console.Write("☻");
    if (mitnyomottmeg.Key == ConsoleKey.W && row > 0)
    {
        row -= 1;
    }
    if (mitnyomottmeg.Key == ConsoleKey.S && row < 8)
    {
        row += 1;
    }
    if (mitnyomottmeg.Key == ConsoleKey.D && col < 8)
    {
        col += 1;
    }
    if (mitnyomottmeg.Key == ConsoleKey.A && col > 0)
    {
        col -= 1;
    }
}
Console.WriteLine("Thanks\n for\n playing");