// 54. В матрице чисел найти сумму элементов главной диагонали.

Console.Clear();
int[,] array = new int[5, 5];
Random number = new Random();
void FillArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = number.Next(10, 100);
        }
    }
}
void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}     ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Дана матрица чисел:");
FillArray();
PrintArray();

int sum = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (i == j)
            sum = sum + array[i, j];
    }
}
Console.WriteLine($"Сумма элементов главной диагонали = {sum}");