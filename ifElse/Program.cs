Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша") {
    Console.WriteLine("Ура, Маша!!!");
} else {
    Console.WriteLine("Ты еще здесь ");
    Console.WriteLine(username);
}
