/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 4, 9.
5 -> 1, 8, 27, 64, 125
*/
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N != 0){
    WriteNumber(N);
}else{
    Console.WriteLine("На ноль и ответ " + 0);
}

void WriteNumber (int number){
    for (int i = 1; i <= Math.Abs(N); i++){
        if (N > 0){
            Console.WriteLine($"Для число {i} в кубе будет равно {Math.Pow(i, 3)}");
        }else{
            Console.WriteLine($"Для число {-i} в кубе будет равно {Math.Pow(-i, 3)}");
        }
    }
}