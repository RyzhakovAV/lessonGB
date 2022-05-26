/*
Задача 63: Задайте значение N. Напишите программу, которая выведет
все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/

int N;

Console.Write("Введите переменную N: ");
while (!int.TryParse(Console.ReadLine(), out N) || N <=0) {
    Console.WriteLine("Ошибка ввода. Введите положительное число N: ");
}

NaturalDigits(N);

void NaturalDigits (int n) {
    if (n == 1){
        Console.Write(n + " ");
    }else{
        NaturalDigits(n-1);
        Console.Write(n + " ");
    }
}