// string[,] table = new string[2,5];
// table[1,2] = "word";
// for (int rows = 0; rows < 2; rows++){
//     for (int columns = 0; columns <5; columns++){
//         Console.WriteLine($"- {table[rows, columns]} -");
//     }
// }


void PrintArray(int[,]matr){
    for (int i = 0; i < matr.GetLength(0); i++) {    // matrix.GetLength(номер массива. В нашем случае 0 это для 3, 1 это для 4)
        for (int j = 0; j < matr.GetLength(1); j++){
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr){
     for (int i = 0; i < matr.GetLength(0); i++) {
        for (int j = 0; j < matr.GetLength(1); j++){
            matr[i,j] = new Random().Next(0, 10);
        }
    }
}

int [,] matrix = new int[3,4];
PrintArray(matrix);
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);

