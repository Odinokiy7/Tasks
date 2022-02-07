// Выяснить является ли число чётным

/*int random = new Random().Next(1, 100);
Console.Write($"Число {random}");

if (random % 2 == 0)
Console.Write(" чётное");
else
Console.Write(" нечётное");*/

Console.Write("Введите число: ");
string numberString = Console.ReadLine();
int number = int.Parse(numberString);

if (number % 2 == 0)
Console.WriteLine("Данное число чётное!");
else
Console.WriteLine("Данное число нечётное!");