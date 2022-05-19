/*
Задайте двумерный массив. Найдите элементы, у
которых оба индекса чётные, и замените эти элементы на их
квадраты.
*/

int n = InputValue ("строк ");
int m = InputValue ("столбцов ");

int[,] array = new int[n,m];

FillArray(array, -15, 15);
PrintArray(array);
QuadrantArray(array);
Console.WriteLine();
PrintArray(array);

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
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}

void QuadrantArray(int[,] arr){
    for (int i = 0; i < arr.GetLength(0); i+=2){
        for (int j = 0; j < arr.GetLength(1); j+=2){
            arr[i,j] = Convert.ToInt32(Math.Pow(arr[i,j], 2));
        }
    }
}