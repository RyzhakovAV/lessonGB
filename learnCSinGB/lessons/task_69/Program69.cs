/*
Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/

int A = InputValue ("Input number: ");
int B = InputValue ("Input number: ");

Console.WriteLine($"Число {A} в степени {B} = {PowerNumber(A, B)}");

int InputValue (string element) {
    int value;
    Console.Write($"Please. {element}");
    while (!int.TryParse(Console.ReadLine(), out value)) {
        Console.Write($"Wrong input. Please. {element}");
    }
    return value;
}

int PowerNumber (int a, int b) {
    if (b == 0){
        return 1;
    }else if (b == 1){
        return a;
    }else{
        return a * PowerNumber(a, b-1);
    } 
}