// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

Console.Clear();

int[] massiv = new int[10];
Random number = new Random();

Console.Write("Дан массив: ");
for (int i = 0; i < 10; i++)
{
    massiv[i] = number.Next(100, 1000);
    Console.Write($"{massiv[i]} ");
}
Console.WriteLine();

int max = massiv[0];
int min = massiv[0];

for (int i = 0; i < massiv.Length; i++)
{
    if (max >= massiv[i])
        min = massiv[i];
    else
        max = massiv[i];
}
Console.WriteLine($"Максимальный элемент массива = {max}");

for (int j = 0; j < massiv.Length; j++)
{
    if (min > massiv[j])
        min = massiv[j];

}
Console.WriteLine($"Минимальный элемент массива = {min}");

int sum = max - min;
Console.WriteLine($"Разница между {max} и {min} = {sum}");