/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29
*/

uint m = InputValue("Input digit m: ");
uint n = InputValue("Input digit n: ");

Console.WriteLine($"A({m},{n}) = {Akkerman(m,n)}");

uint InputValue (string element) {
    Console.Write(element);
    uint value;
    while(!uint.TryParse(Console.ReadLine(), out value)) {
        Console.Write($"Wrong input. Please. {element}");
    }
    return value;
}

uint Akkerman (uint M, uint N) {
    if (M == 0) {
        return N+1;
    }else if (M > 0 && N == 0) {
        return Akkerman(M-1, 1);
    }else{
        return Akkerman(M-1, Akkerman(M, N-1));
    }
}