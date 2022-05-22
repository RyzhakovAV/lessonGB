/*
Задача 59: Задайте двумерный массив из целых чисел.
Напишите программу, которая удалит строку и столбец, на
пересечении которых расположен наименьший элемент
массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим
следующий массив:
9 4 2
2 2 6
3 4 7
*/

int[,] array = new int[4,4];
int[,] narray = new int[array.GetLength(0),array.GetLength(1)];

FillArray(array, 0, 10);
PrintArray(array);
Console.WriteLine();
DeleteRowAndColumn(array);

void FillArray (int[,] arr, int min, int max){
    for (int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++) {
            arr[i,j] = new Random().Next(min, max+1);
        }
    }
}

void PrintArray (int[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++) {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}

void DeleteRowAndColumn (int[,] arr){
    int[,] newarray = new int[arr.GetLength(0)-1, arr.GetLength(1)-1];
    int min = arr[0,0];
    int k = 0, l = 0;
    for (int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++){
            if (min > arr[i,j]){
                min = arr[i,j];
                k = i;
                l = j;
            }
        }
    }
    Console.WriteLine($"Min digit {min} in row = {k} and column = {l}");

    for (int i = 0; i < newarray.GetLength(0); i++){
        if (i < k){
            for (int j = 0; j < newarray.GetLength(1); j++) {
                if (j < l){
                    newarray[i,j] = arr[i,j];
                }else{
                    newarray[i,j] = arr[i,j+1];
                }
            }
        }else{
            for (int j = 0; j < newarray.GetLength(1); j++) {
                if (j < l){
                    newarray[i,j] = arr[i+1,j];
                }else{
                    newarray[i,j] = arr[i+1,j+1];
                }
            }
        }
    }
    PrintArray(newarray);
}