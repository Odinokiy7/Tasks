// 24. Найти кубы чисел от 1 до N

Console.Write("Дан массив из чисел:");
int[] massiv = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
int count = massiv.Length;
for (int i = 0; i < count; i++)
    Console.Write($" {massiv[i]}");
Console.WriteLine();
for (int i = 1; i <= massiv.Length; i++)
    Console.WriteLine($"Куб числа {i}: {i} * {i} * {i} = {i * i * i}");