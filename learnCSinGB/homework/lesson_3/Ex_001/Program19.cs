/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да
*/
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N==0 || Math.Abs(N) < 10){
    Console.Write("число является палиндромом");
}else{
    Polindrom(N);
}

void Polindrom (int number){
    number = Math.Abs(number);
    int n = number;
    int a = 0, diff=0;
    while (n > 0){         //Считаем количество цифр в числе      
        a++;
        n/=10;
    }
    int[] digits = new int[a];          // создаем массив и заполляем цифрами
    for (int i = a-1; i >= 0; i--){
        digits[i] = number % 10;
        number /= 10;
    }

    for (int i = 0; i < a/2; i++){
        if (digits[i] != digits[a-i-1]){
            diff = 0;
            break;
        }else{
            diff++;
        }
    }
    if (diff != 0){
        Console.WriteLine("число является палиндромом");
    }else{
        Console.WriteLine("число не является палиндромом");
    }                     
}