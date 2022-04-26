/*
Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит их на экран.
Диапазон - любое целое число.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
int[] NewArray (){
    int[] array = new int[8];
    for (int i=0; i<8; i++){
        array[i] = new Random().Next();
    }
    return array;
}

void PrintArray(int[] array){
    for (int i = 0; i<array.Length; i++){
        if (i == 0) Console.Write($"[{array[i]}, ");
        else if (i == array.Length-1) Console.Write($"{array[i]}]");
        else Console.Write($"{array[i]}, ");
    }
}

int[] arr = NewArray();
PrintArray(arr);