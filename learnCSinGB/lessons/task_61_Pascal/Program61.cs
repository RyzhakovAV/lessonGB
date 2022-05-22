/*
Задача 61: Вывести первые N строк треугольника
Паскаля. Сделать вывод в виде равнобедренного
треугольника
*/

int n = 5;

int[,] array = new int[n, n];
for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
        array[i, j] = 1 + j + i;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j <= i; j++)
        Console.Write($"{array[i, j]} \t");
    Console.WriteLine();

}