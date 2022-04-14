int a = 1, b = 2, c = 6, d = 8, e = 4;
int max = a;
if (max < b) max = b;
if (max < c) max = c;
if (max < d) max = d;
if (max < e) max = e;
Console.WriteLine("Максимальная гиря = " + max);