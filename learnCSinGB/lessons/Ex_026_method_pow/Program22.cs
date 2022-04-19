Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N != 0){
    WriteNumber(N);
}else{
    Console.WriteLine("На ноль и ответ " + 0);
}

void WriteNumber(int number){
    for (int i = 1; i <= Math.Abs(N); i++){
        if (N >= 0){
            Console.WriteLine($"Для числа {i} квадрат {i * i}");
        }else{
            if (i % 2 == 0){
                Console.WriteLine($"Для числа {-i} квадрат  {i * i}");
            }else{
                Console.WriteLine($"Для числа {-i} квадрат {-i * i}");
            }
        }
    }
}