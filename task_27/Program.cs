// 27. Определить количество цифр в числе

int number = new Random().Next(1, 999999);
Console.WriteLine($"Дано число: {number}");

int count = 0;
while (number != 0)
{
    number = number / 10;
    count++;
}
Console.WriteLine($"Количество цифр в числе = {count}");