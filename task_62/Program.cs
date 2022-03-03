// 62. В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.

Console.Clear();
int[,] array = new int[5, 5];
Random number = new Random();

void FillArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = number.Next(100, 1000);
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

(int, int) FindMin()
{
    int minString = 0;
    int minColum = 0;
    int min = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                minString = i;
                minColum = j;
            }
        }
    }
    return (minString, minColum);
}

void PrintResultArray(int str, int colum)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (str != i && colum != j)
                Console.Write($"{array[i, j]}   ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Дан массив:");
FillArray();
PrintArray(array);
Console.WriteLine("Удалены строка и столбец, на пересечении которых расположен наименьший элемент.");
(int minString, int minColum) = FindMin();
PrintResultArray(minString, minColum);