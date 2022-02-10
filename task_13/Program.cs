// Выяснить, кратно ли число заданному, если нет, вывести остаток

int GetRandomNumber()
{
    int randomNumber = new Random().Next(20, 100);
    return randomNumber;
}

int number = GetRandomNumber();
Console.WriteLine($"Первое число: {number}");

int secondNumber = GetRandomNumber();
Console.WriteLine($"Второе число: {secondNumber}");

IsMultiple(number, secondNumber);
void IsMultiple(int number, int secondNumber)
{
    if (number > secondNumber)
    {
        int result = number % secondNumber;
        if (result == 0)
            Console.WriteLine($"{number} кратно {secondNumber}");
        else
            Console.WriteLine($"{number} % {secondNumber} = остаток {result}");
    }
    else
    {
        int result = secondNumber % number;
        if (result == 0)
            Console.WriteLine($"{secondNumber} кратно {number}");
        else
            Console.WriteLine($"{secondNumber} % {number} = остаток {result}");
    }
}