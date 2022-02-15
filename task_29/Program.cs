// 29. Написать программу вычисления произведения чисел от 1 до N

int insertNumber(string message)
{
    Console.Write(message);
    string? numberStr = Console.ReadLine();
    int number = int.Parse(numberStr);
    return number;
}

int number = insertNumber("Введите число от 1 до N: ");
int sum = 1;

if (number == 0)
{
    Console.Write($"Введите число больше 0");
}
else
{
    for (int i = 1; i <= number; i++)
    {
        sum *= i; // Равнозначно sum = sum * i;
    }
    Console.WriteLine($"Произведение чисел от 1 до {number} = {sum}");
}