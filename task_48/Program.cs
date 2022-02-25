// 48. Показать двумерный массив размером m×n заполненный целыми числами.

Console.Clear();
int[,] massiv = new int[4, 10];
Random number = new Random();
Console.WriteLine("Дан двумерный массив: ");
void FillArray()
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            massiv[i, j] = number.Next(1, 10);
        }
    }
}
void PrintArray()
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            Console.Write($"{massiv[i, j]}  ");
        }
        Console.WriteLine();
    }
}
FillArray();
PrintArray();