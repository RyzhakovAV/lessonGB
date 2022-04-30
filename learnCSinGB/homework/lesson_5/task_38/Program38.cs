/*
Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным значением элементов массива. Длина массива задается с терминала.
[3 7 22 2 78] -> 76
*/

int width;
Console.Write("Введите длину массива: ");
while(!int.TryParse(Console.ReadLine(), out width) || width < 1){
    Console.WriteLine("Ошибка ввода");
    Console.Write("Введите длину массива: ");
}

float[] array = new float[width];

float[] FillArray (float[] arr){
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++) {
        arr[i] = (float)rand.NextDouble();
    }
    return arr;
}

void PrintArray (float[] arr){
    for (int i = 0; i < arr.Length; i ++) {
        if (i==0) Console.Write($"[{arr[i]}, ");
        else if (i == arr.Length - 1) Console.Write($"{arr[i]}]");
        else Console.Write($"{arr[i]}, ");
    }
}

float MinDigit (float[] arr) {
    float min = arr[0];
    for (int i = 0; i < arr.Length; i ++) {
        if (min > arr[i]) min = arr[i];
    }
    return min;
}

float MaxDigit (float[] arr) {
    float max = arr[0];
    for (int i = 0; i < arr.Length; i ++) {
        if (max < arr[i]) max = arr[i];
    }
    return max;
}


array = FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Разница между максимальным {MaxDigit(array)} и минимальным {MinDigit(array)} значением элементов массива: {MaxDigit(array) - MinDigit(array)}");