// Показать таблицу квадратов чисел от 1 до N
Console.WriteLine("Input  positive integer and press Enter: ");
int n = int.Parse(Console.ReadLine());
for(int count = 1; count <= n; count++)
{
    Console.Write($"{count * count} ");
}