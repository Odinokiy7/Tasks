// 57. Написать программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.

Console.Clear();
int[,] array = new int[4, 6];
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
void PrintArray(int[,] array)
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
void SortArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int max = j;
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, k] > array[i, max])
                {
                    max = k;
                }
            }
            int value = array[i, j];
            array[i, j] = array[i, max];
            array[i, max] = value;
        }
    }
}
Console.WriteLine("Дан массив:");
FillArray();
PrintArray(array);
Console.WriteLine("Отсортированный массив:");
SortArray();
PrintArray(array);