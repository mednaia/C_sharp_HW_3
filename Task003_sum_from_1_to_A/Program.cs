//Найти сумму чисел от 1 до А
Console.WriteLine("Input  positive integer and press Enter: ");
int a = int.Parse(Console.ReadLine());
int sum = 0;
for (int count = 1; count<=a; count++)
{
    sum = sum + count;
}
Console.Write($"Sum of numbers from 1 to {a} = {sum}.");