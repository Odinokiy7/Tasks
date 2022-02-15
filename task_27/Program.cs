// 27. Определить количество цифр в числе

int number = new Random().Next(10, 100000);
Console.WriteLine($"Дано число: {number}");

int count = 0;
while (number != 0)
{
    number = number / 10;
    count++;
}
Console.WriteLine($"Количество цифр в числе = {count}");