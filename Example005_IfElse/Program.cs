System.Console.WriteLine("Введите имя пользователя:");
string userName = Console.ReadLine();
if(userName.ToLower() == "karina")
{
System.Console.WriteLine("Приветик, Карина)");
}
else
{
System.Console.WriteLine($"Привет, {userName}");
}
