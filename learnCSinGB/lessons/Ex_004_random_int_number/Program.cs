// Example 003 random two numbers
int numberA = new Random().Next(1,15);
int numberB = new Random().Next(20,50);
Console.WriteLine("First number: " + numberA);
Console.WriteLine("Second number: " + numberB);
Console.WriteLine("Cумма двух чисел: " + (numberA + numberB));
Console.WriteLine("Деление двух чисел (целочисленные): " + (numberB / numberA));
Console.WriteLine("Остаток от деления двух чисел: " + (numberB % numberA));
Console.WriteLine("Произведение двух чисел: " + (numberA * numberB));
Console.WriteLine("Разница двух чисел: " + (numberB - numberA));