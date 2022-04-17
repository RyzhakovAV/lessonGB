/*
Напишите программу, которая принимает на
вход трёхзначное число и на выходе показывает вторую
цифру этого числа
*/
Console.Write("Введите трезначное число: ");
int N = Convert.ToInt32(Console.ReadLine());
while (N/1000 > 0 || N/100 == 0){
    Console.Write("Вы ввели не корректные данные. Пожалуйста введите трезначное число: ");
    N = Convert.ToInt32(Console.ReadLine());
}
int digital = (N / 10) % 10;
Console.Write("вторая цифра в числе: " + digital);