// 35. Определить, присутствует ли в заданном массиве, некоторое число

Console.Clear();

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = new int[20];
Console.WriteLine("Дан массив: ");



for (int i = 0; i < 20; i++)
{
    array[i] = new Random().Next(0, 10);
    Console.Write($" {array[i]} = ");

    if (array[i] == number)
    {
        Console.WriteLine("True");
    }
    else
    {
        Console.WriteLine("False");
    }
}
