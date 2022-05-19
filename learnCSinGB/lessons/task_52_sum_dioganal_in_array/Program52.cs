/*
Задача 51: Задайте двумерный массив. Найдите сумму элементов,
находящихся на главной диагонали.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/

int n = InputValue ("строк ");
int m = InputValue ("столбцов ");

int[,] array = new int[n,m];

FillArray(array,0, 100);
PrintArray(array);
Console.WriteLine();
Console.Write($"Сумма элементов главной диагонали: {SummaDigionalArray(array)}");

int InputValue (string element){
    int value;
    Console.Write($"Введите число {element}");
    while (!int.TryParse(Console.ReadLine(), out value) || value <= 0){
            Console.Write($"Ошибка ввода. Введите число {element} больше 0: ");
    }
    return value;
}

void FillArray (int[,] arr, int min, int max){
    Random rnd = new Random();
    for(int i = 0; i < arr.GetLength(0); i++){
        for(int j = 0; j < arr.GetLength(1); j++){
            array[i,j] = rnd.Next(min, max+1);
        }
    }
}

void PrintArray(int[,] arr){
    for(int i = 0; i < arr.GetLength(0); i++){
        for(int j = 0; j < arr.GetLength(1); j++){
            Console.Write($"{arr[i,j]} \t");
        }
        Console.WriteLine();
    }
}

int SummaDigionalArray(int[,] arr){
    int sum = 0;
    for (int i = 0, j = 0; i < arr.GetLength(0) &&  j < arr.GetLength(1)  ; i++, j++){
            sum += arr[i,j];
    }
    return sum;
}