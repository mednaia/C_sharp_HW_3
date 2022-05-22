// Показать кубы чисел, заканчивающихся на четную цифру
Console.WriteLine("Input positive integer and press Enter: ");
int a = int.Parse(Console.ReadLine());
if(a%2==0) Console.Write(a*a*a);