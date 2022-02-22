// 23. Показать таблицу квадратов чисел от 1 до N 

Console.Clear();

Console.WriteLine("Введите число от 1 до N: ");
string? s1 = Console.ReadLine();
int number1 = Convert.ToInt32(s1);
string? s2 = Console.ReadLine();
int number2 = Convert.ToInt32(s2);
string? s3 = Console.ReadLine();
int number3 = Convert.ToInt32(s3);
string? s4 = Console.ReadLine();
int number4 = Convert.ToInt32(s4);
string? s5 = Console.ReadLine();
int number5 = Convert.ToInt32(s5);

Console.WriteLine();
Console.WriteLine($"{number1} * {number1} = {number1 * number1}");
Console.WriteLine($"{number2} * {number2} = {number2 * number2}");
Console.WriteLine($"{number3} * {number3} = {number3 * number3}");
Console.WriteLine($"{number4} * {number4} = {number4 * number4}");
Console.WriteLine($"{number5} * {number5} = {number5 * number5}");