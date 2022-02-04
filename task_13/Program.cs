// Выяснить, кратно ли число заданному, если нет, вывести остаток   
int GetNumber()

{
    int rundomNumber = new Random().Next(20, 100);
    return rundomNumber;
}

void IsMultiple(int firstNumber, int secondNumber)
{
    if (firstNumber > secondNumber) 
    {
        int result = firstNumber % secondNumber;
        if (result == 0)
            Console.WriteLine("Первое число кратно второму ");
        else
        Console.WriteLine($"Остаток: {result} ");
    }
    else
    {
        int result = secondNumber % firstNumber;
        if (result == 0)
            Console.WriteLine("Второе число кратно первому ");
        else
        Console.WriteLine($"Остаток: {result}");
    }
}

int number = GetNumber();
Console.WriteLine($"Первое случайное число: {number}");

int secondNumber = GetNumber();
Console.WriteLine($"Второе случайное число: {secondNumber}");
IsMultiple(number, secondNumber);

