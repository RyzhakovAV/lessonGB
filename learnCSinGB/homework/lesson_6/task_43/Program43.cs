/*
Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями
y = k1 * x + b1,
y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; - 0,5)
*/

double[] A = new double[2];
double[] B = new double[2];
Console.WriteLine("Введите значения b1 и k1: ");
for (int i = 0; i<2; i++){
    A[i] = Convert.ToDouble(Console.ReadLine());
}
Console.WriteLine("Введите значения b2 и k2: ");
for (int i = 0; i<2; i++){
    B[i] = Convert.ToDouble(Console.ReadLine());
}

double coordx (double[] arrA, double[] arrB){
    double x = (arrB[0] - arrA[0]) / (arrA[1] - arrB[1]);
    return x;
}

double coordy (double[] arrA, double[] arrB){
    double y = arrA[1] * ((arrB[0] - arrA[0]) / (arrA[1] - arrB[1])) + arrA[0];
    return y;
}

Console.Write($"Пересечение двух прямых заданных формулой y=k1*x + b1 и y=k2*x + b2 в точке ({coordx(A, B)};{coordy(A, B)})");