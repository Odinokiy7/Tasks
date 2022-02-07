// Удалить вторую цифру трехзначного числа

int random = new Random().Next(100, 999);
Console.WriteLine($"Трехзначное число: {random}");

int myNumber = random / 100;
int myNumber2 = random % 10;
Console.WriteLine($"Вторая цифра удалена: {myNumber} {myNumber2}");