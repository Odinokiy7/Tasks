// 58. Написать программу, которая в двумерном массиве заменяет строки на столбцы.
// Или сообщить, что это невозможно (в случае, если матрица не квадратная).

Console.Clear();
int[,] array = new int[4, 4];
int[,] matrix = new int[4, 4];
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
void MatrixArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            matrix[i, j] = array[j, i];
        }
    }
}
if (array.GetLength(0) != array.GetLength(1) || matrix.GetLength(0) != matrix.GetLength(1))
{
    Console.WriteLine("Матрица не квадратная!");
}
else
{
    Console.WriteLine("Дан массив: ");
    FillArray();
    PrintArray(array);
    Console.WriteLine("Строки заменены на столбцы: ");
    MatrixArray();
    PrintArray(matrix);
}