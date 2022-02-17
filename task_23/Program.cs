// 23. Показать таблицу квадратов чисел от 1 до N 

Console.Clear();

Console.WriteLine("Даны числа: ");
int[] massiv = { 1, 2, 3, 4, 5, 6, 7, 8, };
int count = massiv.Length;

for (int i = 0; i < count; i++)
{
    Console.Write($"Число {massiv[i]} - ");
    Console.WriteLine($"квадрат числа {massiv[i] * massiv[i]}");
}