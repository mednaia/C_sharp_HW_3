// Подсчитать сумму цифр в числе
Console.WriteLine("Input A positive integer and press Enter: ");
int a = int.Parse(Console.ReadLine());
int sum = 0;
for (int tmp = a; tmp > 0; tmp = tmp /10)
{
    sum = sum + tmp % 10;
}
Console.Write($"The sum of digits of {a} is {sum}.");