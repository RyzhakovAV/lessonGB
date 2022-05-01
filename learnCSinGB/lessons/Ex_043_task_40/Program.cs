/*
Задача 40: Напишите программу, которая принимает на вход три
числа и проверяет, может ли существовать треугольник с
сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника
меньше суммы двух других сторон.
*/
int[] array = new int[3];
int number;



for (int i =0; i <=2; i++){
    Console.Write($"Введите {i+1} число: ");
    while (!int.TryParse(Console.ReadLine(), out number)){
            Console.WriteLine($"Ошибка ввода");
            Console.WriteLine($"Введите {i+1} число: "); 
    }
    array[i] = number;
}

if ((array[0] < array[1]+array[2]) && (array[1] < (array[0]+array[2])) && (array[2] < (array[1]+array[0]))){
    Console.WriteLine("Такой треугольник существует");
}else{
    Console.WriteLine("Такого треугольника не существует");   
}