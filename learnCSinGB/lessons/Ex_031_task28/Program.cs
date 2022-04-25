/*
Задача 28: Напишите программу, которая
принимает на вход число N и выдаёт
произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/
int N;
Console.Write("Введите положительное число: ");
while(!int.TryParse(Console.ReadLine(), out N) || N < 1){
    Console.WriteLine("Ошибка ввода.");
    Console.Write("Пожалуйста. Введите положительное число: ");
}
int sum = 1;
for (int i = 1; i<=N; i++){
    sum*=i;
}
Console.WriteLine($"Произведение чисел от 1 до {N} равна {sum}");