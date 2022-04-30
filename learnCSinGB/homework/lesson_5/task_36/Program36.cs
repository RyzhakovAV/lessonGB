/*
Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях. Длина массива задается с терминала.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int width, min = 0, max = 99999;

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

int SumInArray (int[] arr) {
    int sum=0;
    for (int i = 0; i < arr.Length; i ++) {
        if (i%2 != 0) sum += arr[i];
    }
    return sum;
}

array = FillArray(array, min, max);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Сумма элементов на нечетных позициях в масиве равно: {SumInArray(array)}");