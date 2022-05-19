/*
Решение в группах задачи:
Задача 48: Задайте двумерный массив размера m на n,
каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
Выведите полученный массив на экран.
*/

int m,n;

Console.Write("Введите количество строк (n): ");
while(!int.TryParse(Console.ReadLine(), out n ) || n <= 0){
    Console.Write("Ошибка ввода. Введите количество строк (n), число должно быть больше 0: ");
}
Console.Write("Введите количество столбцов (m): ");
while(!int.TryParse(Console.ReadLine(), out m ) || m <= 0){
    Console.Write("Ошибка ввода. Введите количество строк (m), число должно быть больше 0: ");
}

int[,] arr = new int[m,n];

FillArray(arr);
PrintArray(arr);

void FillArray(int[,] array){
    for (int i =0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            array[i,j] = i + j;
        }
    }
}

void PrintArray(int[,] array){
    for (int i =0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            Console.WriteLine($"array[{i},{j}] = {array[i,j]}");
        }
    }
}