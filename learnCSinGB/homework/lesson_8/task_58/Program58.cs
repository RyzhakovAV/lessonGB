/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
*/

int m = InputValue ("количество строк первого массива ");
int n = InputValue ("количество столбцов первого массива ");
int r = InputValue ("количество строк второго массива ");
int s = InputValue ("количество столбцов второго массива ");
int[,] FirstArray = new int[m,n];
int[,] SecondArray = new int[r,s];

FillArray(FirstArray, 0, 10);
FillArray(SecondArray, 0, 10);
Console.WriteLine("First array");
PrintArray(FirstArray);
Console.WriteLine("Second array");
PrintArray(SecondArray);
Multiplication(FirstArray, SecondArray);

int InputValue (string element) {
    int value;
    Console.Write($"Введите {element}");
    while(!int.TryParse(Console.ReadLine(), out value) || value <= 0){
        Console.Write($"Ошибка ввода. Введите {element} ");
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

void Multiplication (int[,] Firstarr, int[,] Secondarr){
    if (Firstarr.GetLength(0) != Secondarr.GetLength(0) && Firstarr.GetLength(1) != Secondarr.GetLength(1)) {
        Console.WriteLine("Произведение двух массивов не возможно, массивы должны быть равные");
    }else{
        for(int i = 0; i < Firstarr.GetLength(0); i++) {
            for (int j = 0; j < Firstarr.GetLength(1); j++) {
                Firstarr[i,j] *= Secondarr[i,j];
            }
        }
        Console.WriteLine("Произведение двух матриц");
        PrintArray(Firstarr);
    }
}