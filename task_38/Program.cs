// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции

Console.Clear();

int[] massiv = new int[10];
Random number = new Random();

Console.Write("Дан массив: ");
void FillArray()
{
    for (int index = 0; index < massiv.Length; index++)
    {
        massiv[index] = number.Next(1, 10);
        Console.Write($"{massiv[index]} ");
    }
}
FillArray();

Console.WriteLine();

int oddIndex = 0;
int sum = 0;

for (int index = 1; index < massiv.Length; index = index + 2)
    oddIndex = oddIndex + massiv[index];
    sum = sum + oddIndex;
Console.WriteLine($"Сумма чисел на нечетных позициях = {sum}");