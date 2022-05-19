/*
Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3
*/

int m = InputValue("число строк ");
int n = InputValue("число столбцов ");

int[,] array = new int[m,n];

FillArray(array, 0, 100);
PrintArray(array);
Console.WriteLine();
EqualsArray(array);


int InputValue (string element){
    int value;
    Console.Write($"Введите {element}");
    while (!int.TryParse(Console.ReadLine(), out value) || value <= 0){
            Console.Write($"Ошибка ввода. Введите {element}: ");
    }
    return value;
}

void FillArray(int[,] arr, int min, int max){
    Random rand = new Random();
    for (int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++) {

            arr[i,j] = rand.Next(min, max + 1);
        }
    }
}

void PrintArray(int[,] arr){
    for(int i = 0; i < arr.GetLength(0); i++){
        for(int j = 0; j < arr.GetLength(1); j++){
            Console.Write($"array[{i}, {j}] = {arr[i,j]} \t");
        }
        Console.WriteLine();
    }
}

void EqualsArray (int[,] arr){
    for (int i = 0; i < arr.GetLength(1); i++){
        double sum = 0;
        for (int j = 0; j < arr.GetLength(0); j++){
            sum += arr[j,i];
        }
        Console.WriteLine($"Среднее арифметическое столбца {i}: {Math.Round(sum/arr.GetLength(1), 1)}");
    }
}