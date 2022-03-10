// 71: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 29

Console.Write("Задайте число M = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте число N = ");
int n = Convert.ToInt32(Console.ReadLine());

int A(int m, int n)
{
    if (m == 0)
        return n + 1;
    else
      if ((m != 0) && (n == 0))
        return A(m - 1, 1);
    else
        return A(m - 1, A(m, n - 1));
}
Console.Write("Вычисление функции Аккермана = ");
Console.WriteLine(A(m, n));