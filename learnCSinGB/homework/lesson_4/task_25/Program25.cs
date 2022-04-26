/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
int a, b;
bool exit = true;

void Input(){
    Console.WriteLine("Введите число: ");
    while (!int.TryParse(Console.ReadLine(), out a) )    {
        Console.WriteLine("Ошибка ввода. Пожалуйста, введите число: ");
    }
    Console.WriteLine("Введите cтепень: ");
    while (!int.TryParse(Console.ReadLine(), out b))    {
        Console.WriteLine("Ошибка ввода. Пожалуйста, введите степень: ");
    }
    Console.WriteLine($"{a} в степени {b} равно {Math.Pow(a, b)}");
}

while (exit){
    Input();
    Console.WriteLine("Для выхода из программы введите exit. Для продолжения нажмите Enter");
    string str = Console.ReadLine();
    if (str.Equals("exit")) exit = false;
}