// Найти максимальное из трех чисел.

int GetRandom()
{
    int number = new Random().Next(0, 1000);
    return number;
}

int a = GetRandom();
int b = GetRandom();
int c = GetRandom();
Console.WriteLine($"Даны числа: {a}, {b}, {c}");

int max = a;
if (b > max) max = b;
if (c > max) max = c;
Console.WriteLine($"Максимальное из них: {max}");