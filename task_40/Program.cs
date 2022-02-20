// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

Console.Clear();

double[] massiv = new double[10];
Random number = new Random();

Console.Write("Дан массив: ");
for (int i = 0; i < massiv.Length; i++)
{
    //massiv[i] = number.NextDouble() * 100; 
    massiv[i] = Math.Round(number.NextDouble()*100, 2);
    Console.Write($"{massiv[i]} ");
}

Console.WriteLine();
Console.WriteLine();

double max = 0;
double min = 0;

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

Console.WriteLine();

double sum = max - min;
Console.WriteLine($"Разница между ними = {sum}");