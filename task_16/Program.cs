// 16. Дано число, обозначающее день недели. Выяснить, является ли номер дня недели выходным

int random = new Random().Next(1, 8);
Console.Write($"{random} день недели - ");

if (random < 6)
    Console.WriteLine("будний");
else
    Console.WriteLine("выходной");