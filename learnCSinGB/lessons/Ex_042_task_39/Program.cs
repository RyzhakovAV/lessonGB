int[] array = {10, 25, 32, 47, 58, 90, 145, 321, 455};

//int[] tmp = ReverseArray(array);

//CopyArray(tmp, array);
ReverseArrayInPlace(array);
PrintArray(array);

void ReverseArrayInPlace(int[] arr){
    for (int i = 0; i < arr.Length/2; i++) {
        int tmp = array[i];
        arr[i] = arr[arr.Length-1-i];
        array[array.Length-1-i] = tmp;
    }
}

int[] ReverseArray(int[] arr){
    int[] result = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++) {
        result[arr.Length - 1 - i] = arr[i];
    }
    return result;
}

void CopyArray(int[] source, int[] dest){
    if (source.Length != dest.Length) return;
    for (int i = 0; i < source.Length; i++){
        dest[i] = source[i];
    }
}

void PrintArray (int[] arr){
    for (int i = 0; i < arr.Length; i ++) {
        if (i==0) Console.Write($"[{arr[i]}, ");
        else if (i == arr.Length - 1) Console.Write($"{arr[i]}]");
        else Console.Write($"{arr[i]}, ");
    }
}
