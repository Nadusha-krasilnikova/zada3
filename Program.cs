// найти максимальное из трех чисел
Console.WriteLine("введите три числа");
int a=int.Parse(Console.ReadLine());
int b=int.Parse(Console.ReadLine());
int c=int.Parse(Console.ReadLine());
int max=a;
if (a>max) max=a;
if (b>max) max=b;
if (c>max) max=c;
Console.WriteLine("максимальное число ");
Console.Write (max);
