// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

Console.Clear();

int[] massiv = new int[10];
Random number = new Random();

Console.Write("Дан массив: ");
void FillArray(int[] arr)
{
    for (int index = 0; index < arr.Length; index++)
    {
        arr[index] = number.Next(100, 1000);
        Console.Write($"{arr[index]} ");
    }
}
FillArray(massiv);

Console.WriteLine();

int evenNumber = 0;
int oddNumber = 0;

for (int index = 0; index < massiv.Length; index++)
{
    if (massiv[index] % 2 == 0)
    {
        evenNumber++;
    }
    else
    {
        oddNumber++;
    }
}

Console.WriteLine($"Четных чисел = {evenNumber} ");
Console.WriteLine($"Нечетных чисел = {oddNumber} ");