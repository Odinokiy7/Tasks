// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int number = new Random().Next(10, 100);
Console.WriteLine($"Дано число: {number}");

int firstNumber = number / 10;
int secondNumber = number % 10;
int max;

if (firstNumber > secondNumber)
    max = firstNumber;
else
    max = secondNumber;
Console.WriteLine($"Максимальная цифра: {max}");