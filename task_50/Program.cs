// 50. В двумерном массиве n×k заменить четные элементы на противоположные.

Console.Clear();
int[,] array = new int[10, 10];
Random number = new Random();
Console.WriteLine("Дан массив: ");
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
int[,] MethodSum()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] % 2 == 0)
            {
                array[i, j] = array[i, j] * -1;
            }
        }
    }
    return array;
}

FillArray();
PrintArray(array);
Console.WriteLine("Четные элементы заменены на противоположные числа:");
MethodSum();
PrintArray(array);