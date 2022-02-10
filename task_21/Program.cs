// 21. Программа проверяет пятизначное число на палиндромом.

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool valueOne = number % 10 == number / 10000;
bool valueTwo = (number % 100) / 10 == (number / 1000) % 10;

if (valueOne && valueTwo)
    Console.Write("Число является палиндромом");
else
    Console.Write("Число не является палиндромом");