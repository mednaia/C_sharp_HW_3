// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
int[] a=new int[8];
Random rand = new Random();
for (int i=0; i <8; i++)
{
    a[i] = rand.Next(0,2);
    Console.Write(" " + a[i]);
}