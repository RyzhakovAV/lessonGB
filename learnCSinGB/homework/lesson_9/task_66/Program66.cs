/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int m = InputValue("Input digit M: ");
int n = InputValue("Input digit N: ");

Console.WriteLine(OutSumDigits(m, n));

int InputValue(string element) {
    int value;
    Console.Write(element);
    while (!int.TryParse(Console.ReadLine(), out value) || value <= 0) {
        Console.WriteLine($"Wrong input. Please. {element}");
    }
    return value;
}

int OutSumDigits (int M, int N) { 
    return (M==N) ? M : N + OutSumDigits(M, N-1);
}