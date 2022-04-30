/*
Задача 33: Задайте массив. Напишите программу, которая
определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да
*/
int N;
int[] array = {5, 3, 8, 2, 6, 1, 2, 9};

void PrintArray (int[] arr){
    for (int i = 0; i < arr.Length; i++){
        if (i == 0) Console.Write($"[{arr[i]}, ");
        else if (i == arr.Length-1) Console.Write($"{arr[i]}]");
        else Console.Write($"{arr[i]}, ");
    }
}

void FindInArray (int[] arr, int n){
    int diff = 0;
    for(int i = 0; i < arr.Length; i++){
        if (arr[i] == n){
            diff++;
            break;
        }
    }
    if (diff!=0) Console.Write("Такое число есть в массиве");
    else Console.Write("Такого числа нет в массиве");
}

PrintArray(array);
Console.WriteLine();
Console.Write("Введите число больше или равное 0 для поиска: ");
while(!int.TryParse(Console.ReadLine(), out N) || N < 0){
    Console.Write("Ошибка ввода. Введите число больше или равное 0 для поиска: ");
}
FindInArray(array, N);