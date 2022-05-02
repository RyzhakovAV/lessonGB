/*
Задача 44: Не используя рекурсию, выведите первые N чисел
Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/
int number, Fibonachi = 1;
int n1=0, n2;
Console.Write("Введите положительное число: ");
while (!int.TryParse(Console.ReadLine(), out number) || number < 1){
    Console.WriteLine("Ошибка ввода");
    Console.WriteLine("Введите положительное число: ");
}
Console.WriteLine($"{0}");
for (int i = 0; i < number-1; i++){
    Console.WriteLine($"{Fibonachi}");
    n2 = Fibonachi;
    Fibonachi += n1;
    n1 = n2;

}