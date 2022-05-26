/*
Задача 65: Дано натуральное число N. Выведите слово YES, если число N
является точной степенью двойки, или слово NO в противном случае.
Операцией возведения в степень пользоваться нельзя.
N = 5 -> “NO"
N = 4096 -> “YES"
*/

int n = InputValue("Input digit N ");
int digit = 2;

CheckDigit(n, digit);

int InputValue (string element){
    int value;
    Console.Write(element);
    while(!int.TryParse(Console.ReadLine(), out value)|| value < 0){
        Console.WriteLine($"Wrong input. Please. {element}");
    }
    return value;
}

void CheckDigit (int n, int digit) {
    if (n == digit) {
        Console.WriteLine("YES");
    }else if (n < digit || n%2 == 1) {
        Console.WriteLine("NO");
    }else{
        n /= digit;
        Console.Write(n + " ");        
        CheckDigit(n, digit);
    }
}