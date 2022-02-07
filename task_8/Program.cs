// Показать четные числа от 1 до N

int random = new Random().Next(2, 20);
Console.Write($"Чётные числа от 1 до {random}:");

int min = 2;
while (min < random)
{
    if (min % 2 == 0)
        Console.Write($" {min},");
    min++;
}