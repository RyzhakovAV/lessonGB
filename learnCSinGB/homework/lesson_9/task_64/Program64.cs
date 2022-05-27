/*
Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> "1, 2, 3, 4, 5"
M = 4; N = 8. -> "4, 6, 7, 8
*/

int m = InputValue ("Input digit M: ");
int n = InputValue ("Input digit N: ");

OutputDigits(m,n);

int InputValue(string element) {
    Console.Write(element);
    int value;
    while (!int.TryParse(Console.ReadLine(), out  value) || value <= 0) {
        Console.WriteLine($"Wrong input. Please. {element}");
    }
    return value;
}

void OutputDigits (int M, int N) {
    if (N == M){
        Console.Write(N + " ");
    }else{
        OutputDigits(M, N-1);
        Console.Write(N + " ");
    }
}