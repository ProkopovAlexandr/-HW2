Console.WriteLine("Введите число:");
string a = Console.ReadLine();

try{
    Console.WriteLine("Третья цифра: " + a[2]);
}
catch (Exception ex)
{
    Console.WriteLine("Третьей цифры нет");
}