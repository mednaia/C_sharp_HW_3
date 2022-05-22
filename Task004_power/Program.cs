// Возведите число А в натуральную степень B используя цикл
Console.WriteLine("Input A positive integer (that you want to raise to a power) and press Enter: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Input B positive integer (power of a number) and press Enter: ");
int b = int.Parse(Console.ReadLine());
int result = 1;
int i=1;
while(i<=b) 
{
    result=result*a; 
    i++;
}
Console.Write($"Value {a} to the degree {b} is {result}.");