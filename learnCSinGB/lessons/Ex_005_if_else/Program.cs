// example 005 learn if-else
Console.WriteLine("Введите ваше имя.");
string username = Console.ReadLine();
if (username.ToLower() == "Александр"){
    Console.WriteLine("Я рад видеть вас Александр!");
}else{
    Console.WriteLine("Привет " + username);
}