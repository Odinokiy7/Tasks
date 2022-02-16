// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

Console.Clear();

int[] array = new int[8];
void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(0, 2);
        index++;
    }
}

void PrintArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        Console.Write($"{array[index]}");
        index++;
    }
}

FillArray(array);
PrintArray(array);