/*
Задача 62: Заполните спирально массив 4 на 4.
1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7
*/
int n = InputValue("количество строк ");
int m = InputValue("количество столбцов ");

int[,] array = new int[n,m];
FillArray(array);
PrintArray(array);

int InputValue (string element) {
    int value;
    Console.Write($"Введите {element}");
    while(!int.TryParse(Console.ReadLine(), out value) || value <= 0){
        Console.Write($"Ошибка ввода. Введите {element} ");
    }
    return value;
}

void FillArray (int[,] arr){
    int row = 0, col = 0;
    int dx = 1, dy = 0;
    int dirChanges = 0;
    int visits = arr.GetLength(1);
 
    for (int i = 0; i < arr.Length; i++) {
        arr[row, col] = i + 1;
        if (--visits == 0) {
            visits = arr.GetLength(1) * (dirChanges %2) + n * ((dirChanges + 1) %2) - (dirChanges/2 - 1) - 2;
            int temp = dx;
            dx = -dy;
            dy = temp;
            dirChanges++;
        }
        col += dx;
        row += dy;
    }
}

void PrintArray (int[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++) {
            Console.Write($"{arr[i,j]}\t");
        }
        Console.WriteLine();
    }
}