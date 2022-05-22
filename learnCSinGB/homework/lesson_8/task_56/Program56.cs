/*
Задача 56: Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
*/

int m = InputValue ("количество строк ");
int n = InputValue ("количество столбцов ");
int[,] array = new int[m,n];

FillArray(array, 0, 10);
PrintArray(array);
Console.WriteLine();
Summa(array);

int InputValue (string element) {
    int value;
    Console.Write($"Введите {element}");
    while(!int.TryParse(Console.ReadLine(), out value) || value <= 0){
        Console.Write($"Ошибка ввода. Введите {element}");
    }
    return value;
}

void FillArray (int[,] arr, int min, int max) {
    for (int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++) {
            arr[i,j] = new Random().Next(min, max + 1);
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

void Summa (int[,] arr){
    int Summa = 0, Row = 0;
    for (int j = 0; j <arr.GetLength(1); j++) {
            Summa += arr[0,j];
            Row = 0;
    }
    Console.WriteLine($"В ряду 0 = {Summa}");
    for (int i = 1; i < arr.GetLength(0); i++) {
        int Sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++) {
            Sum += arr[i,j];
        }
        Console.WriteLine($"В ряду {i} = {Sum}");
        if (Summa < Sum) {
            Summa = Sum;
            Row = i;
            Sum = 0;
        }
    }
    Console.WriteLine($"Строка {Row} с наибольшей суммой {Summa}");
}