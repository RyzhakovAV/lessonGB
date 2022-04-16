int[] arrayNumbers = {1, 67, 34, 90, 2, 156, 1234, 67, 198, 156};
int find = 156;
int n = arrayNumbers.Length;
int index = 0;

while (index < n){
    if (find == arrayNumbers[index]){
        Console.WriteLine(index);
        break;
    }
    index++;
}

