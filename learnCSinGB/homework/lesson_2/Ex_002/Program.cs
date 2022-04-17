/*
Напишите программу, которая выводит
третью цифру заданного числа или сообщает, что третьей
цифры нет.
*/
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N/100 <= 0){
    Console.WriteLine("Третьей цифры нет");
}else if(N/1000 > 0 ){
    while(N/1000 > 0){
        N/=10;
    }
    Console.WriteLine(N%10);
}else{
    Console.WriteLine(N%10);
}