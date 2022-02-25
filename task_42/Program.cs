// Задача 42: Определить сколько чисел больше 0 введено с клавиатуры

Console.Clear();
string? numberStr = String.Empty;
int number = 1;
Console.WriteLine("Введите число: ");
for (int i = 0; number > 0; i++)
{
    numberStr = Console.ReadLine();
    int.TryParse(numberStr, out number);
    if (number < 1)
    {
        i--;
        Console.WriteLine();
        Console.WriteLine("Введенное число меньше 1, либо не число!");
        break;
    }
    Console.WriteLine($"Количество введенных чисел = {i + 1}");
    Console.Write("Введите следующее число: ");
}