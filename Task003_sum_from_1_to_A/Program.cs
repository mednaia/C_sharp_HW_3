//Найти сумму чисел от 1 до А
Console.WriteLine("Input  positive integer and press Enter: ");
int a = int.Parse(Console.ReadLine());
int sum = a*(a+1)/2;
Console.Write($"Sum of numbers from 1 to {a} = {sum}.");