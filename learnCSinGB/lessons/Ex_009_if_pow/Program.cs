// we enter two numbers and check whether the second number is the square of the first
Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
if ((numberA*numberA)==numberB){
    Console.WriteLine("Второе число является квадратом первого");
}else{
    Console.WriteLine("Второе число не является квадратом первого");
}

