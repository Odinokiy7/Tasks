﻿// 28. Подсчитать сумму цифр в числе

Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

double sum = 0;
while (number > 0)
{
    sum = sum + number % 10;
    number = number / 10;
}
Console.WriteLine($"Сумма цифр = {sum}");