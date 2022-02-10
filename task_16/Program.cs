// 16. Дано число, обозначающее день недели. Выяснить, является ли номер дня недели выходным

// Первый вариант 
/*
int random = new Random().Next(1, 8);
Console.Write($"{random} день недели - ");

if (random < 6)
    Console.WriteLine("будний");
else
    Console.WriteLine("выходной");
*/

// Второй вариант
int random = new Random().Next(1, 8);
Console.Write($"{random} день: ");

string[] day = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

if (random < 6)
    Console.WriteLine($"{day [random - 1]} - будний день");
else
    Console.WriteLine($"{day [random - 1]} - выходной день");