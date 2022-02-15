// 25. Найти сумму чисел от 1 до А

int myNumber(string message)
{
    Console.Write(message);
    string? numberStr = Console.ReadLine();
    int number = int.Parse(numberStr);
    return number;
}

int number = myNumber("Введите число: ");
int sum = 0;

if (number == 0)
{
    Console.Write("Значение 0 недопустимо");
}
else
{
    for (int i = 1; i <= number; i++)
    {
        sum = sum + i;
        //  sum+=i; Эквивалентно sum = sum + 1;
    }
    Console.WriteLine($"Сумма чисел от 1 до {number} = {sum}");
}