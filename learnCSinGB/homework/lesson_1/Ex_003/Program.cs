﻿/* Задача 3: Напишите программу, которая на вход принимает число и выдаёт,
является ли число чётным (делится ли оно на два без остатка).
*/
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
if (N % 2 == 0) {
    Console.Write("Число четное");
}else{
    Console.Write("Число нечетное");
}