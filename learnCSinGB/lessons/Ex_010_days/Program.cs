// day in week
Console.WriteLine("Введите день недели от 1 до 7");
int day = Convert.ToInt32(Console.ReadLine());
while (day <= 0 || day > 7){
    Console.WriteLine("Вы ввели некорректное значение. Введите день недели от 1 до 7");
    day = Convert.ToInt32(Console.ReadLine());
}
switch (day){
    case 1:
    Console.WriteLine("Понедельник");
    break;
    case 2:
    Console.WriteLine("Вторник");
    break;
    case 3:
    Console.WriteLine("Среда");
    break;
    case 4:
    Console.WriteLine("Четверг");
    break;
    case 5:
    Console.WriteLine("Пятница");
    break;
    case 6:
    Console.WriteLine("Суббота");
    break;
    case 7:
    Console.WriteLine("Воскресенье");
    break;
}
Console.WriteLine(day);