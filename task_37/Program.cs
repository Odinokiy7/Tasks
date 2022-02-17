// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

Console.Clear();

int[] massiv = new int[123];

void FillArray()
{
    Random number = new Random();
    Console.Write($"Дан массив из чисел: ");
    for (int i = 0; i < massiv.Length; i++)
    {
        massiv[i] = number.Next(1, 200);
        Console.Write($"{massiv[i]}  ");
    }
    Console.WriteLine();
}

void PrintArray()
{
    int count = 0;
    foreach (int item in massiv)
    {
        if (item >= 10 && item <= 99)
            count++;
    }
    Console.WriteLine($"Элементы из отрезка 10 - 99 встречаются {count} раз");
}

FillArray();
PrintArray();