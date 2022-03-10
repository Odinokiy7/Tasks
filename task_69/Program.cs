// Задача 69: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("Задайте число M = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте число N = ");
int n = Convert.ToInt32(Console.ReadLine());

int count = m;

while (m < n)
{
    m++;
    count = count + m;
}
Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N = {count}");