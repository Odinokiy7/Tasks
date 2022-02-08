// Даны два числа. Показать большее и меньшее число

Console.Write("Введите первое число: ");
string numberA = Console.ReadLine();
int number1 = int.Parse(numberA);

Console.Write("Введите второе число: ");
string numberB = Console.ReadLine();
int number2 = int.Parse(numberB);

if (number1 > number2)
    Console.Write($"{number1} больше, чем {number2}");
else
    Console.Write($"{number2} больше, чем {number1}");