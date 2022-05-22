//Найти сумму чисел от 1 до А
Console.WriteLine("Input  positive integer and press Enter: ");
int a = int.Parse(Console.ReadLine());
int count = 1;
int sum = 0;
while (count <= a)
{
    sum = sum + count;
    count++;
}
Console.Write($"Sum of numbers from 1 to {a} = {sum}.");