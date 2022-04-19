Console.Write("Введите координату х: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y: ");
int y = Convert.ToInt32(Console.ReadLine());

int q = getQuadrant(x, y);

if (q == 0){
    Console.WriteLine("Эта точка находиться на оси");
}else{
    Console.WriteLine("Эта точка находится в квадранте: " + q);
}

int getQuadrant(int x, int y)       // имя функции getQuadrant которая принимает на вход два значения (int x, int y)
{
    if (x > 0 && y > 0)             // условие
        return 1;                   // возвращает на выходе из фунции 1 и остановка выполнения функции
    else if (x < 0 && y > 0)
        return 2;
    else if (x < 0 && y < 0)
        return 3;
    else if (x > 0 && y < 0)
        return 4;
    else
        return 0;
}