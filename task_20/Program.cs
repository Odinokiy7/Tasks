// 20. Задать номер четверти, показать диапазоны для возможных координат

Console.WriteLine("Введите номер четверти от 1 до 4: ");
string? numberStr = Console.ReadLine();
int numberQuarter = int.Parse(numberStr);

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