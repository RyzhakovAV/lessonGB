// алгоритм сортирока методом выбора (мин - макс)
int [] arr = {1, 2, 3, 4, 5, 6, 71, 2, 4, 1, 5, 9, 7};

void PrintArray(int[] array){
    int count = array.Length;

    for (int i=0; i < count; i++){
        Console.Write($"{array[i]} ");
    }
}

void SelectionSort(int[] array){
    for (int i = 0; i < array.Length; i++){
        int minPosition = i;
        for(int j = i+1; j < array.Length; j++ ){
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

SelectionSort(arr);
PrintArray(arr);