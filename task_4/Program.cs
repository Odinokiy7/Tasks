// Найти максимальное из трех чисел.

int a = 54;
int b = 89;
int c = 73;
Console.WriteLine($"Даны три числа: {a}, {b}, {c}");

int max = a;
if (b > max) max = b;
if (c > max) max = c;
Console.WriteLine("Максимальное число: " + max);