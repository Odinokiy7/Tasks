// 63. Сформировать трехмерный массив не повторяющимися двузначными числами.
//     Показать его построчно на экран, выводя индексы соответствующего элемента.

Console.Clear();
int[,,] array = new int[3, 3, 3];
int mean = 20;

void FillPrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = mean;
                mean++;
                Console.Write($"{array[i, j, k]} [{i}, {j}, {k}]   ");
            }
        }
    }
}

Console.Write("Дан массив: ");
FillPrintArray();