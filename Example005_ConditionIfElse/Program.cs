Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "ниночка")
{
    Console.WriteLine("Приветствуем Ниночку-картиночку!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
    }