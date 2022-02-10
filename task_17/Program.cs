// 17. По двум заданным числам проверять является ли одно квадратом другого

int number(string message)
{
    Console.Write(message);
    string? numberStr = Console.ReadLine();
    int numberA = int.Parse(numberStr);
    return numberA;
}

int numberOne = number("Введите первое число: ");
int numberTwo = number("Введите второе число: ");

if (numberOne == numberTwo * numberTwo)
    Console.WriteLine($"{numberOne} является квадратом {numberTwo}");
else if (numberTwo == numberOne * numberOne)
    Console.WriteLine($"{numberTwo} является квадратом {numberOne}");
else
    Console.WriteLine("Ни одно из чисел не является квадратом другого");