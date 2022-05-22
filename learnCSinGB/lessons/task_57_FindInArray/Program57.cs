/*
Задача 57: Составить частотный словарь элементов
двумерного массива. Частотный словарь содержит
информацию о том, сколько раз встречается элемент
входных данных.
*/

int[] array = new int[15];

FillArray(array, 0, 10);
PrintArray(array);
Console.WriteLine();
SelectionSort(array);
FindArray(array);

void FillArray(int[] arr, int min, int max){
    for (int i = 0; i < arr.Length; i++){
        arr[i] = new Random().Next(min, max);
    }
}

void PrintArray(int[] arr){
    for (int i = 0; i < arr.Length; i++){
        Console.Write($"{arr[i]} ");
    }
}

void SelectionSort(int[] arr){
    for (int i = 0; i < arr.Length; i++){
        int minPosition = i;
        for(int j = i+1; j < arr.Length; j++ ){
            if(arr[j] < arr[minPosition]) minPosition = j;
        }

        int temporary = arr[i];
        arr[i] = arr[minPosition];
        arr[minPosition] = temporary;
    }
}

void FindArray(int[] arr){
    int[] counts = new int[arr.Max() + 1];
    for (int i = 0; i < arr.Length; i++)
        if (counts[arr[i]] == 0){
            for (int j = 0; j < arr.Length; j++)
                if (arr[i] == arr[j])
                    counts[arr[i]]++;
            Console.WriteLine(arr[i] + " повторяется " + counts[arr[i]] + " раз");
        }
}