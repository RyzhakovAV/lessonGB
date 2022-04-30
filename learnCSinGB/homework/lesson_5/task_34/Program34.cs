/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве. Длина массива задается с терминала.
[345, 897, 568, 234] -> 2
*/

int width, min = 100, max = 999;

Console.Write("Введите длину массива: ");
while(!int.TryParse(Console.ReadLine(), out width) || width < 1){
    Console.WriteLine("Ошибка ввода");
    Console.Write("Введите длину массива: ");
}

int[] array = new int[width];

int[] FillArray (int[] arr, int min, int max){
    for (int i = 0; i < arr.Length; i++) {
        arr[i] = new Random().Next(min, max+1);
    }
    return arr;
}

void PrintArray (int[] arr){
    for (int i = 0; i < arr.Length; i ++) {
        if (i==0) Console.Write($"[{arr[i]}, ");
        else if (i == arr.Length - 1) Console.Write($"{arr[i]}]");
        else Console.Write($"{arr[i]}, ");
    }
}

int CountInArray (int[] arr) {
    int count=0;
    for (int i = 0; i < arr.Length; i ++) {
        if (arr[i]%2 == 0) count ++;
    }
    return count;
}

array = FillArray(array, min, max);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в масиве равно: {CountInArray(array)}");