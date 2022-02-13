// 20. Задать номер четверти, показать диапазоны для возможных координат

Console.Write("Введите номер четверти: ");
string? numberStr = Console.ReadLine();
int numberQuarter = int.Parse(numberStr);

void Method(int numberQuarter)
{
    if (numberQuarter == 1)
        Console.WriteLine("Диапазоны: x > 0, y > 0");
    else if (numberQuarter == 2)
        Console.WriteLine("Диапазоны: x < 0, y > 0");
    else if (numberQuarter == 3)
        Console.WriteLine("Диапазоны: x < 0, y < 0");
    else if (numberQuarter == 4)
        Console.WriteLine("Диапазоны: x > 0, y < 0");
    else
        Console.WriteLine("Данная четверть не найдена");
}
Method(numberQuarter);