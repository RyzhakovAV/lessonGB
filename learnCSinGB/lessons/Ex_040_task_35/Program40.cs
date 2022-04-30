﻿/*
Задача 35:
Задайте одномерный массив из 123 случайных
неотрицательных чисел. Найдите количество элементов массива,
значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] --> 1
[1, 2, 3, 6, 2] --> 0
[10, 11, 12, 13, 14] --> 5
*/
int[] array = new int[123];
int min = 10, max = 99;

int[] FillArray (int[] arr){
    for (int i = 0; i < arr.Length; i++) {
        arr[i] = new Random().Next(0, 100);
    }
    return arr;
}

void PrintArray (int[] arr){
    for (int i = 0; i < arr.Length; i++) {
        if (i == 0) Console.Write($"[{arr[i]}, ");
        else if (i == arr.Length-1) Console.Write($"{arr[i]}]");
        else Console.Write($"{arr[i]}, ");
    }
}

int FindInArray(int[] arr, int min, int max){
    int count =0;
    for (int i = 0; i < arr.Length; i++) {
        if (arr[i] >= min && arr[i] <= max)  count++;
    }
    return count;
}

array = FillArray(array);
PrintArray(array);
int count = FindInArray(array, min, max);
Console.WriteLine();
Console.Write($"Количество элементов в массиве от {min} до {max} равна {count}");