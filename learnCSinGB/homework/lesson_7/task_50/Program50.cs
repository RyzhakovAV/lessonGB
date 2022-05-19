/*
Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1,7 -> такого числа в массиве нет
*/

int m = InputValue("число строк ");
int n = InputValue("число столбцов ");

int[,] array = new int[m,n];

FillArray(array, -100, 100);
PrintArray(array);
FindInArray(array);


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
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}

void FindInArray (int[,] arr){
    int x = InputValue("номер строки ");
    int y = InputValue("номер столбца ");
    if (x > arr.GetLength(0) || y > arr.GetLength(1)){
        Console.WriteLine("такого числа в массиве нет");
    }else{
        Console.WriteLine($"число в масиве равно = {arr[x,y]}");
    }
}