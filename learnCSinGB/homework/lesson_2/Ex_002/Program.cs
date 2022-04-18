/*
Напишите программу, которая выводит
третью цифру заданного числа или сообщает, что третьей
цифры нет.
*/
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
N = Math.Abs(N);
if (N < 100){
    Console.WriteLine("Третьей цифры нет");
}else if(N >= 999){
    while(N >= 999){
        N/=10;
    }
    Console.WriteLine(N%10);
}else{
    Console.WriteLine(N%10);
}