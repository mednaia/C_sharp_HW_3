// Показать кубы чисел, заканчивающихся на четную цифру
// Console.WriteLine("Input positive integer and press Enter: ");
// int a = int.Parse(Console.ReadLine());
// if(a%2==0) Console.Write(a*a*a);

//Показать кубы чисел, заканчивающиеся на чётную цифру
Console.WriteLine("Input  positive integer and press Enter: ");
int n = int.Parse(Console.ReadLine());
for(int count = 1; count <= n; count++)
{
    int result = count * count * count;
    if(result%2==0) Console.Write($"{result} ");
}