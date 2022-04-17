/*
Напишите программу, которая принимает на
вход два числа и проверяет, является ли второе
число квадратом первого.
5, 25 -> да
-4, 16 -> да
25, 5 -> нет
8,9 -> нет
*/
Console.Write("Введите первое число: ");
int N1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int N2 = Convert.ToInt32(Console.ReadLine());
if ((N1*N1)==N2){
    Console.WriteLine("да");
}else{
    Console.WriteLine("нет");
}