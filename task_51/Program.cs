// 51. Задать двумерный массив следующим правилом: Aₘₙ = m+n

Console.Clear();

int[,] array = new int[4, 4];
Random rand = new Random();

void FillArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] MethodSum()
{
    int[,] massiv = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            massiv[i, j] = i + j;
        }
    }
    return massiv;
}

FillArray();
PrintArray(array);
Console.WriteLine("=======");
int[,] massiv = MethodSum();
PrintArray(massiv);