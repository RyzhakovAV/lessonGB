Console.Write("Введите квандратн 1-4: ");
int j = Convert.ToInt32(Console.ReadLine());

while (j <= 0 || j> 4){
    Console.Write("Ошибка ввода. Введите квандратн 1-4: ");
    j = Convert.ToInt32(Console.ReadLine());
}

getStart (j);

void getStart (int number)
{
    if (number == 1)
    Console.WriteLine("В первом квандранте числа могут быть x > 0 и y > 0");
    if (number == 2)
    Console.WriteLine("В первом квандранте числа могут быть x < 0 и y > 0");
    if (number == 3)
    Console.WriteLine("В первом квандранте числа могут быть x < 0 и y < 0");
    if (number == 4)
    Console.WriteLine("В первом квандранте числа могут быть x > 0 и y < 0");
}