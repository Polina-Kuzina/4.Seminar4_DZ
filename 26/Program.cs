// 26. Возведите число А в натуральную степень B используя цикл
Console.WriteLine("Введите число A: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень: ");
int b = int.Parse(Console.ReadLine());
int degree = a;
if (b > 0)
{
    for (int i = 1; i <= b-1; i++)
    {
        degree = degree * a;
    }
    Console.WriteLine(a + $" в степени {b} равно {degree}");
}
else if (b == 0) Console.WriteLine(a + " в степени 0 равно 1");
else Console.WriteLine("Введите значение степени больше 0");