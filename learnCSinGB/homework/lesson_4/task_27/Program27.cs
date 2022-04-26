/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
int N;
while (true)
{
    Console.WriteLine("Введите число: ");
    while (!int.TryParse(Console.ReadLine(), out N))
    {
        Console.WriteLine("Ошибка ввода, пожалуйста введите число: ");
    }
    int sum = Sum(N);
    Console.WriteLine("Сумма чисел равна: " + sum);
}

int Sum(int number)
{
    number = Math.Abs(number);
    int n = number;
    int count = 0, summa = 0;
    while (n > 0)
    {
        count++;
        n /= 10;
    }
    int[] array = new int[count];
    for (int i = count - 1; i >= 0; i--)
    {
        array[i] = number % 10;
        number /= 10;
    }
    for (int i = 0; i < array.Length; i++)
    {
        summa += array[i];
    }
    return summa;
}