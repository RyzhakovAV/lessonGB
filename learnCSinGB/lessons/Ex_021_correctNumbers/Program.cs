/*
Напишите программу, которая будет принимать
на вход два числа и выводить, является ли второе
число кратным первому. Если число 2 не кратно числу
1, то программа выводит остаток от деление.
34, 5 -> не кратно, остаток 4
16, 4 -> кратно
*/
Console.WriteLine("Введите первое число: ");
int N1 = Convert.ToInt32(Console.ReadLine());
while (N1 == 0){
    Console.WriteLine("Ошибка ввода. Введите первое число, которое не равно 0: ");
    N1 = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Введите второе число: ");
int N2 = Convert.ToInt32(Console.ReadLine());
while (N2 == 0 || N2 > N1){
    Console.WriteLine("Ошибка ввода. Введите второе число, которое не равно 0 и меньше 1 введенного: ");
    N2 = Convert.ToInt32(Console.ReadLine());
}
if (N1%N2 == 0){
    Console.WriteLine("Число кратное");
}else{
    Console.WriteLine("Число не кратное, остаток: " + N1%N2);
}