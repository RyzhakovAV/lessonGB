/*
Задача 32: Напишите программу замена элементов
массива: положительные элементы замените на
соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/
int[] array = new int[6];

void FillArray(int[] arr){
    for(int i =0; i < arr.Length; i++){
        arr[i] = new Random().Next(-9, 10);
    }
}
void PrintArray(int[] arr){
    for(int i = 0; i < arr.Length; i++){
        if (i==0) Console.Write($"[{arr[i]}, ");
        else if (i==arr.Length-1) Console.Write($"{arr[i]}]");
        else Console.Write($"{arr[i]}, ");
    }
}

int[] ReplaceArray(int[] arr){
    for(int i = 0; i < arr.Length; i++){
        arr[i] = - arr[i];
    }
    return arr;
}

FillArray(array);
PrintArray(array);
Console.WriteLine();
int[] Array = ReplaceArray(array);
PrintArray(Array);