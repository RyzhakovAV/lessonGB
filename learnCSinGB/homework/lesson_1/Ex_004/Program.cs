/* Задача 4: Напишите программу, которая на вход
принимает число (N), а на выходе показывает все чётные
числа от 1 до N.
*/
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
for (int i=0 ; i<N-1 ; i+=2 ) {
    if (i < N-3){
        Console.Write(i+2 + ", ");
    }else{
        Console.Write(i+2);
    }
}