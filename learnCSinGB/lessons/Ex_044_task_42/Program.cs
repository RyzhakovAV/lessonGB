/*
Задача 42: Напишите программу, которая будет преобразовывать
десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/

int N, number = 0, count = 1;

Console.Write("Введите число: ");
while (!int.TryParse(Console.ReadLine(), out N)){
    Console.WriteLine("Ошибка ввода");
    Console.WriteLine("Введите число: ");
}
int n = N;
while (N > 0){
    number += (N%2)*count;
    N /= 2;
    count *= 10;
}

Console.Write($"число {n} в двоичном представлении равно {number}");
