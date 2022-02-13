// 22. Найти расстояние между точками в пространстве 2D/3D

string space;
Console.Write("Выберете 2D или 3D?: ");
space = Console.ReadLine();

int GetRandomNumber()
{
    int randomNumber = new Random().Next(1, 10);
    return randomNumber;
}

if (space.ToLower() == "2d")
{
    double x = GetRandomNumber();
    double y = GetRandomNumber();
    Console.WriteLine($"Первая точка: (x = {x}, y = {y})");

    double x1 = GetRandomNumber();
    double y1 = GetRandomNumber();
    Console.WriteLine($"Вторая точка: (x = {x1}, y = {y1})");

    Console.WriteLine($"Расстояние между ними = " + Math.Sqrt(Math.Pow((x1 - x), 2) + Math.Pow((y1 - y), 2)));
}
else if (space.ToLower() == "3d")
{
    double x = GetRandomNumber();
    double y = GetRandomNumber();
    double z = GetRandomNumber();
    Console.WriteLine($"Первая точка: (x = {x}, y = {y}, z = {z})");

    double x1 = GetRandomNumber();
    double y1 = GetRandomNumber();
    double z1 = GetRandomNumber();
    Console.WriteLine($"Вторая точка: (x = {x1}, y = {y1}, z = {z1})");

    Console.WriteLine($"Расстояние между ними = " + Math.Sqrt(Math.Pow((x1 - x), 2) + Math.Pow((y1 - y), 2) + Math.Pow((z1 - z), 2)));
}
else
    Console.WriteLine("Ошибка, повторите dotnet run");