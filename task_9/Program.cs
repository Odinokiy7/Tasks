// 9. Показать последнюю цифру трёхзначного числа

Console.Clear();

int number = new Random().Next(100, 1000);
Console.Write($"Дано число: {number}. ");

number = number % 10;
Console.WriteLine($"Последняя цифра: {number}");