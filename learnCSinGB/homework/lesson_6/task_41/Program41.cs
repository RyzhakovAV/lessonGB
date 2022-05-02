/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/
int stop, N, count = 0;
string str = "";

int Input(){
    Console.WriteLine("Введите число, для выхода из программы введите exit: ");
    str = Console.ReadLine()!;
    if (str.Equals("exit")){
        return 666;
    }else{
        while(!int.TryParse(str, out N)){
            Console.WriteLine("Ошибка ввода, введите число или exit: ");
            str = Console.ReadLine()!;
            if (str.Equals("exit")){
                return 666;
            }
        }                
    }
    N = int.Parse(str); 
    if (N > 0) return 1;
    else return 0;
}

while (true) {
    stop = Input();
    if (stop != 666) count += stop;
    else break;
}
Console.WriteLine($"Вы ввели {count} числа которые больше 0");