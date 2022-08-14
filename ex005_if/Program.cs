// Приветсивие  по условию
Console.WriteLine("Введите имя пользователя ");
string username = Console.ReadLine();

if (username.ToLower() == "tati")
{
    Console.WriteLine("Yep!! Tati is here");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}
