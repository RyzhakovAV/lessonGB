/*
Задача 37:
Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний
и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] --> 5 8 3
[6 7 3 6] --> 36 21
*/
int n;
Console.Write("Введите количество элементов в массиве: ");
while (!int.TryParse(Console.ReadLine(), out n) || n < 1){
    Console.WriteLine("Ошибка ввода");
    Console.WriteLine("Введите количество элементов в массиве (должно быть число больше 0): ");
}
int[] array = new int[n];

int[] FillArray (int[] arr){
    for (int i = 0; i < arr.Length; i++) {
        arr[i] = new Random().Next(0, 10);
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

int [] SumArray (int[] arr, int N){
    int[] newArray = new int[N];
    if (N%2 == 0){
        newArray = new int[N/2];
    }else{
        newArray = new int[N/2 + 1];
        newArray[N/2] = arr[N/2];
    }
    for (int i = 0; i < arr.Length/2; i ++) {
        newArray[i] = arr[i] * arr[arr.Length - i - 1];
    }

    return newArray;
    
}

array = FillArray(array);
PrintArray(array);
Console.WriteLine();
int[] narray = SumArray(array, n);
PrintArray(narray);