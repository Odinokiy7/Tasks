// 52. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты.

Console.Clear();
double[,] array = new double[4, 5];
Random number = new Random();
void FillArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = number.Next(1, 10);
        }
    }
}
void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}   ");
        }
        Console.WriteLine();
    }
}
void PrintSearch()
{
    for (int i = 0; i < array.GetLength(0); i = i + 2)
    {
        for (int j = 0; j < array.GetLength(1); j = j + 2)
        {
            array[i, j] = array[i, j] * array[i, j];
            Console.Write($"{array[i, j]}   ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Дан массив:");
FillArray();
PrintArray();
Console.WriteLine("Квадраты элементов с чётными индексами строк и столбцов:");
PrintSearch();