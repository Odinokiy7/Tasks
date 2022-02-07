// Показать вторую цифру трехзначного числа.

int random = new Random().Next(100, 999);
Console.WriteLine($"Трехзначное число: {random}");

int myNumber = random % 100 / 10;
Console.WriteLine($"Вторая цифра = {myNumber}");