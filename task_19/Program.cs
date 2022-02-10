// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

int number(string message)
{
    Console.Write(message);
    string? numberStr = Console.ReadLine();
    int numberA = int.Parse(numberStr);
    return numberA;
}

int x = number("Введите координаты x: ");
int y = number("Введите координаты y: ");

void Method(int x, int y)
{
    if (x > 0 && y > 0)
        Console.WriteLine("Точка в I четверти");
    else if (x < 0 && y > 0)
        Console.WriteLine("Точка в II четверти");
    else if (x < 0 && y < 0)
        Console.WriteLine("Точка в III четверти");
    else if (x > 0 && y < 0)
        Console.WriteLine("Точка в IV четверти");
    else
        Console.WriteLine("Точка в начале координат");
}
Method(x, y);