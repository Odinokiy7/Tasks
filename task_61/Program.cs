// 61. Найти произведение двух матриц

Console.Clear();
int[,] array = new int[2, 2];
Random number = new Random();

Console.WriteLine("Первая матрица:");
int[,] firstMatrix = FillArray();
PrintArray(firstMatrix);
Console.WriteLine("Вторая матрица:");
int[,] secondMatrix = FillArray();
PrintArray(secondMatrix);
Console.WriteLine("Произведение двух матриц:");
int[,] ProdactMatrix = ProdactTwoMatrix(firstMatrix, secondMatrix);
PrintArray(ProdactMatrix);

int[,] FillArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = number.Next(1, 9);
        }
    }
    return array;
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

int[,] ProdactTwoMatrix(int[,] a, int[,] b)
{
    int[,] c = new int[2, 2];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(0); j++)
        {
            for (int k = 0; k < b.GetLength(1); k++)
            {
                c[i, j] = a[i, k] * b[k, j];
            }
        }
    }
    return c;
}