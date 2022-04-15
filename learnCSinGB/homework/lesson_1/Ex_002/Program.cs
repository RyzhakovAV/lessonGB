// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int c = Convert.ToInt32(Console.ReadLine());
if (a > b && a > c){
    Console.WriteLine($"max = {a}");
}else if (b > a && b > c){
    Console.WriteLine($"max = {b}");
}else{
    Console.WriteLine($"max = {c}");
}