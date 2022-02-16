// 30. Показать кубы чисел, заканчивающихся на четную цифру

Console.Write("Дан массив из чисел:");
int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
int count = array.Length;
for (int i = 0; i < count; i++)
    Console.Write($" {array[i]}");
Console.WriteLine();

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
        Console.WriteLine($"Куб числа {array[i]}: {array[i]} * {array[i]} * {array[i]} = {array[i] * array[i] * array[i]}");
}