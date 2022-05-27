/*
Задача 67: Напишите программу, которая будет принимать на вход число и
возвращать сумму его цифр.
453 -> 12
45 -> 9
*/

uint N = InputValue ("Input number: ");

Console.WriteLine($"Сумма чисел в цифре {N} = {AdditionDigitis(N)}");

uint InputValue (string element) {
    uint value;
    Console.Write($"Please. {element}");
    while (!uint.TryParse(Console.ReadLine(), out value)) {
        Console.Write($"Wrong input. Please. {element}");
    }
    return value;
}

uint AdditionDigitis (uint n) {
    return (n < 10) ? n : n%10 + AdditionDigitis(n/10); 
}