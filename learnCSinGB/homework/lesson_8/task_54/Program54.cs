/*
Задача 54: Задайте двумерный массив.
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
*/
int m = InputValue ("количество строк ");
int n = InputValue ("количество столбцов ");
int[,] array = new int[m,n];

FillArray(array, 0, 20);
PrintArray(array);
Console.WriteLine();
SortInRow(array);
PrintArray(array);

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

void SortInRow (int[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++){
            for (int k = 0; k < arr.GetLength(1); k++) {
                if (arr[i,j] > arr[i,k]){
                    int temp = arr[i,j];
                    arr[i,j] = arr[i,k];
                    arr[i,k] = temp;
                }
            }  
        }
    }
}