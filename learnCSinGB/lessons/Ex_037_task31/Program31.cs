/*
Задайте массив из 12 элементов, заполненный
случайными числами из промежутка [ 9, 9]. Найдите сумму
отрицательных и положительных элементов массива.
Например, в массиве [3,9,
8,1,0, 7,2, 1,8, 3, 1,6] сумма
положительных чисел равна 29, сумма отрицательных равна
20.
*/
// 1. Создаем массив из 12 элиментов
int[] array = new int[12];
// 2. Заполнить массив случайными числами. Создаем функцию FillArray()
FillArray(array, -9, 9);
//3. Выводим массив. Функция PrintArray()
PrintArray(array);
//4. Найти сумму всех отрицательных чисел
int sumNegative = sumNeg(array);
Console.WriteLine($"Сумма отрицательных элементов массива равна {sumNegative}");
//5. Найти сумму всех положительных чисел
int sumPositive = sumPos(array);
Console.WriteLine($"Сумма положительных элементов массива равна {sumPositive}");


void FillArray(int[] arr, int minValue, int maxValue){
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++){
        arr[i] = random.Next(minValue, maxValue+1);
    }        
}

void PrintArray(int[] arr){
    for(int i =0; i < arr.Length; i++){
        Console.WriteLine($"arr[{i}] = {arr[i]}");
    }
}

int sumNeg(int[]arr){
    int sum = 0;
    for(int i = 0; i < arr.Length; i++){
        if (arr[i] < 0) sum += arr[i];
    }
    return sum;
}

int sumPos(int[]arr){
    int sum = 0;
    for(int i = 0; i < arr.Length; i++){
        if (arr[i] > 0) sum += arr[i];
    }
    return sum;
}