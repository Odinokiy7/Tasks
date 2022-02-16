// 31. Задать массив из 8 элементов и вывести их на экран

Console.Write("Дан массив из чисел: ");
int[] massiv = { 1, 2, 3, 4, 5, 6, 7, 8, };
int count = massiv.Length;
for (int i = 0; i < count; i++)
{
    Console.Write($" {massiv[i]}");
}