
Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
string username2 = "маша";
if(username.ToLower() == username2.ToLower())
{
    Console.WriteLine("Ура, это же Маша! ");
} 
else 
{
    Console.Write("Привет, " + username);
}