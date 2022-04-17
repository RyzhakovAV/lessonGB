/*
Напишите программу, которая принимает на
вход число и проверяет, кратно ли оно
одновременно 7 и 23
*/
Console.WriteLine("Введите первое число: ");
int N1 = Convert.ToInt32(Console.ReadLine());
while (N1 == 0){
    Console.WriteLine("Ошибка ввода. Введите первое число, которое не равно 0: ");
    N1 = Convert.ToInt32(Console.ReadLine());
}
if (N1%7 == 0 && N1%23 == 0){
    Console.WriteLine("Число кратное");
}else{
    Console.WriteLine("Число не кратное");
}