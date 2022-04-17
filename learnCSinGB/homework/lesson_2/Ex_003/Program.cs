/*
Напишите программу, которая принимает на
вход цифру, обозначающую день недели, и проверяет,
является ли этот день выходным.
*/
Console.WriteLine("Введите число от 1-7: ");
int day = Convert.ToInt32(Console.ReadLine());
while (day <= 0 || day > 7){
    Console.WriteLine("Введите число от 1-7: ");
    day = Convert.ToInt32(Console.ReadLine());
}
if (day == 6 || day == 7){
    Console.WriteLine("Выходной день");
}else{
    Console.WriteLine("Будни");
}