/*
Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
double min = -10.0;
double max = 10.0;

int m = InputValue("строк ");
int n = InputValue("столбцов ");

double[,] array = new double[m,n];

FillArray(array, min, max);
PrintArray(array);


int InputValue (string element){
    int value;
    Console.Write($"Введите число {element}");
    while (!int.TryParse(Console.ReadLine(), out value) || value <= 0){
            Console.Write($"Ошибка ввода. Введите число {element} больше 0: ");
    }
    return value;
}

void FillArray(double[,] arr, double minimum, double maximum){
    Random rand = new Random();
    for (int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++) {

            arr[i,j] = rand.NextDouble() * (maximum-minimum) + minimum;
        }
    }
}

void PrintArray(double[,] arr){
    for(int i = 0; i < arr.GetLength(0); i++){
        for(int j = 0; j < arr.GetLength(1); j++){
            Console.Write($"{Math.Round(arr[i,j], 2)} ");
        }
        Console.WriteLine();
    }
}