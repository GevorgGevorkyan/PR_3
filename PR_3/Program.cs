int octava = 1;
Console.WriteLine("Вводите буквы, чтобы играть на пианино или выберите от F1 до F8, чтобы сменить октаву:\n");
while (true)
{
    var key = Console.ReadKey(true);
    if (key.Key == ConsoleKey.F2) octava = 2;
    else if (key.Key == ConsoleKey.F1) octava = 1;
    else if (key.Key == ConsoleKey.F3) octava = 3;
    else if (key.Key == ConsoleKey.F4) octava = 4;
    else if (key.Key == ConsoleKey.F5) octava = 5;
    else if (key.Key == ConsoleKey.F6) octava = 6;
    else if (key.Key == ConsoleKey.F7) octava = 7;
    else if (key.Key == ConsoleKey.F8) octava = 8;
    else game(((int)key.Key));
}
void game(int a)
{
    try
    {
        Console.Beep(a*octava, 100);
    }
    catch { }
}