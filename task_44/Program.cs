// 44. Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

Console.Clear();
Console.Write("Введите координаты k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

double y = 1;
double x = 1;
x = (b2 - b1) / (k1 - k2);
y = k1 * x + b1;

Console.WriteLine($"х = {x}, у = {y}");
if (k1 != k2)
    Console.WriteLine($"Точка пересечения двух прямых = {x}, {y}");
else
    Console.WriteLine("Прямые не пересекаются");
