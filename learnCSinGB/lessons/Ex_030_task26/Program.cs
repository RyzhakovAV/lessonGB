/*
Напишите программу, которая принимает
на вход число и выдаёт количество цифр в числе.
*/
int number;
Console.Write("Введите число: ");
while(!int.TryParse(Console.ReadLine(), out number)) {
    Console.WriteLine("Ошибка ввода");
    Console.Write("Введите число: ");
}

int i = 0;
number=Math.Abs(number);
while(number>0){
    i++;
    number/=10;
}

Console.WriteLine("Вы ввели: " + i + " значное число");