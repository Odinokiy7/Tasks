// 34. Написать программу замену элементов массива на противоположные

Console.Clear();

int[] array = new int[10];
Random number = new Random();

Console.Write("Даны элементы массива: ");
void FillArray(int[] arr)
{
    for (int index = 0; index < arr.Length; index++)
    {
        arr[index] = number.Next(1, 10);
        Console.Write($"{arr[index]} ");
    }
}
FillArray(array);

Console.WriteLine();

Console.Write("Противоположные элементы: ");
void FillArray2(int[] arr)
{
    for (int index = 0; index < arr.Length; index++)
    {
        arr[index] = arr[index] * -1;
        Console.Write($"{arr[index]} ");
    }
}
FillArray2(array);