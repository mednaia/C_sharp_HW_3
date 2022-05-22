// Возведите число А в натуральную степень B используя цикл
Console.WriteLine("Input A positive integer (that you want to raise to a power) and press Enter: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Input B positive integer (power of a number) and press Enter: ");
int b = int.Parse(Console.ReadLine());
int result = 1;
for(int i=1;i<=b;i++) //for ([действия_до_выполнения_цикла]; [условие]; [действия_после_выполнения])
{
    result *= a; // *= Оператор вначале умножает значение выражения (в правой части оператора) на значение переменной или свойства (в левой части оператора) (слева). Затем оператор присваивает результат этой операции переменной или свойству.
}
Console.Write($"Value {a} to the degree {b} is {result}.");