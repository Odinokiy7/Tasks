// По двум заданным числам проверять является ли первое квадратом второго.

Console.Write("Введите первое число: ");
string numberA = Console.ReadLine();
int number1 = int.Parse(numberA);

Console.Write("Введите второе число: ");
string numberB = Console.ReadLine();
int number2 = int.Parse(numberB);

Console.WriteLine();
if (number1 == number2 * number2)
    Console.Write($"{numberA} является квадратом {numberB}");
else
    Console.Write($"{numberA} не является квадратом {numberB}");