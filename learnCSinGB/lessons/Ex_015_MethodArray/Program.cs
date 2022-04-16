int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int[] arrayNumbers = {1, 67, 34, 90, 2, 156, 1234, 67, 198};

int max =   Max(Max(arrayNumbers[0], arrayNumbers[1], arrayNumbers[2]),
            Max(arrayNumbers[3], arrayNumbers[4], arrayNumbers[5]),
            Max(arrayNumbers[6], arrayNumbers[7], arrayNumbers[8]));
Console.Write(max);