// 67. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

Console.Write("Задайте значение для M = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте значение для N = ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Все натуральные числа в промежутке от M до N:");
while (m < n + 1)
{
    m++;
    Console.Write($"{m - 1}   ");
}