// 30. Показать кубы чисел, заканчивающихся на четную цифру
Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Кубы чисел, заканчивающихся на четную цифру:");
for (int x = 2; x <= N; x = x + 2)
{
    Console.WriteLine($"{x} в кубе = {x*x*x}");
}

