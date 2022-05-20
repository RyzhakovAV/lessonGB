/*
Задача 53: Задайте двумерный массив. Напишите программу,
которая поменяет местами первую и последнюю строку
массива.
*/

int n = InputValue("количество строк: ");
int m = InputValue("количество столбцов: ");

int[,] array = new int[n,m];

FillArray(array, -10, 10);
PrintArray(array);
SwapPlace(array);
Console.WriteLine();
PrintArray(array);

int InputValue (string element){
    int value;
    Console.Write($"Введите {element}");
    while (!int.TryParse(Console.ReadLine(), out value) || value <= 0) {
        Console.WriteLine($"Ошибка ввода. Введите {element}");
    }
    return value;
}

void FillArray (int[,] arr, int min, int max){
    for (int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++) {
            arr[i,j] = new Random().Next(min, max+1);
        }
    }
}

void PrintArray(int[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++) {
            Console.Write($"{arr[i,j]}\t");
        }
        Console.WriteLine();
    }
}

void SwapPlace(int[,] arr){
    int temp;
    for (int i = 0; i < arr.GetLength(1); i++) {
        temp = arr[0, i];
        arr[0, i] = arr[arr.GetLength(0)-1, i];
        arr[arr.GetLength(0)-1, i] = temp;
    }
}