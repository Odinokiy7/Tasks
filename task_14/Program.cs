// 14. Найти третью цифру числа или сообщить, что её нет

int random = new Random().Next(0, 1000);
Console.WriteLine($"Дано число: {random}");
if (random > 99)
    Console.WriteLine($"Третья цифра = {random % 10}");
else
    Console.WriteLine("Третьей цифры нет");