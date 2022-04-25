/*
Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел
от 1 до А.
*/

int number;
Console.Write("Пожалуйста, введите положительное число: ");

while (!int.TryParse(Console.ReadLine(), out number) || number < 0) {   // проверяем чтобы пользователь ввел число
    Console.WriteLine("Ошибка ввода, попробуйте еще раз");
    Console.Write("Пожалуйста, введите положительное число: ");   
}

int sum = 0;
for (int i = 1; i <= number; i++){
    sum += i;
}

Console.WriteLine($"Сумма числе от 1 до {number} равна {sum}");