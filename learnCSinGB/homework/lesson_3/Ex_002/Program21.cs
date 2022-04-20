/*
Задача 21: Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
int[] A = new int[3];
int[] B = new int[3];
Console.WriteLine("Введите координаты точки А: ");
for (int i = 0; i<3; i++){
    A[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Введите координаты точки B: ");
for (int i = 0; i<3; i++){
    B[i] = Convert.ToInt32(Console.ReadLine());
}

double distant = AB (A, B);
Console.Write("расстояние между точками A и B = " + Math.Round(distant, 2));

double AB (int[] a, int[] b){
    double result;
    result = Math.Sqrt(Math.Pow(b[0]-a[0], 2)+Math.Pow(b[1]-a[1], 2)+Math.Pow(b[2]-a[2], 2));
    return result;
}