//
Console.WriteLine("Введите число N, число не должно быть равно 0");
double N = Convert.ToDouble(Console.ReadLine());
while (N == 0){
    Console.WriteLine("Ошибка ввода. Введите число N, число не должно быть равно 0");
    N = Convert.ToDouble(Console.ReadLine());
}
Console.WriteLine(1 / N);