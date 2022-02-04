// По заданному номеру дня недели вывести его название

Console.Write("Введите номер дня недели: ");
string weekdays = Console.ReadLine();
int weekday = int.Parse(weekdays);

if (weekday == 1)
{
    Console.WriteLine("Понедельник");
}
if (weekday == 2)
{
    Console.WriteLine("Вторник");
}
if (weekday == 3)
{
    Console.WriteLine("Среда");
}
if (weekday == 4)
{
    Console.WriteLine("Четверг");
}
if (weekday == 5)
{
    Console.WriteLine("Пятница");
}
if (weekday == 6)
{
    Console.WriteLine("Суббота");
}
if (weekday == 7)
{
    Console.WriteLine("Воскресенье");
}