// numbers -N...+N
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
int n = N * (-1);
while (n!=N){
    Console.Write(n +", ");
    n++;
}
Console.Write(n);