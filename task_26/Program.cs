// 26. Возведите число А в натуральную степень B используя цикл

Console.Clear();

Console.WriteLine("Возводим число A в натуральную степень B");
Console.Write("a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("b = ");
int b = Convert.ToInt32(Console.ReadLine());

if (b > 0)
{
    double result = Math.Pow(a, b);
    Console.WriteLine($"{a} в степени {b} = {result}");
}
else
    Console.WriteLine("Ошибка!");