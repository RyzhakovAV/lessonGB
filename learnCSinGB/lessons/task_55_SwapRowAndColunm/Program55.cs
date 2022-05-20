/*
Задача 55: Задайте двумерный массив. Напишите программу,
которая заменяет строки на столбцы. В случае, если это
невозможно, программа должна вывести сообщение для
пользователя.
*/

int row = InputValue("количесто строк ");
int column = InputValue("количество столбцов "); 

int[,] array = new int[row, column];
FillArray(array, -10, 10);
PrintArray(array);
Console.WriteLine();
SwapPlace(array);


int InputValue(string element) {
    int value;
    Console.Write($"Введите {element}");
    while (!int.TryParse(Console.ReadLine(), out value) || value <= 0) {
        Console.WriteLine($"Ошибка ввода. Введите {element} больше 0: ");
    }
    return value;
}

void FillArray (int[,] arr, int min, int max) {
    for (int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++) {
            arr[i,j] = new Random().Next(min, max);
        }
    }
}

void PrintArray (int[,] arr) {
    for (int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++) {
            Console.Write($"{arr[i,j]}\t");
        }
        Console.WriteLine();
    }
}

void SwapPlace (int[,] arr) {
    if (arr.GetLength(0) != arr.GetLength(1)) {
        Console.WriteLine ("Замена строк на столбцы не возможна.");
    }else{
        int temp, k=0;
        for (int i = 0+k; i < arr.GetLength (0); i++) {
            for (int j = 0+i; j < arr.GetLength(1); j++) {
                temp = arr[i,j];
                arr[i,j] = arr[j,i];
                arr[j,i] = temp;
                k++;
            }
        }
    PrintArray(array);
    }
}