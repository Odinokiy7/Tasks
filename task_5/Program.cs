// Написать программу вычисления значения функции y = f(a)

Console.Clear();

Console.Write("Введите число: ");
string? numberStr = Console.ReadLine();
int a = int.Parse(numberStr);

int y = 0;

y = a * a;
Console.WriteLine($"Если A = {a}, Y = {y}");