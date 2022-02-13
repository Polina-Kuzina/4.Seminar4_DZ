// 28. Подсчитать сумму цифр в числе
Console.Write("Введите число: ");
int digitCount(int a)
{
    int counter = 0;
    int sum = a % 10;
    while (a > 0)
    {
        counter++;
        a = a / 10;
        sum = sum + a % 10;     
    }
    return sum;
}
string str = Console.ReadLine();
int x = Convert.ToInt32(str);
Console.WriteLine("Сумма цифр в числе равна " + digitCount(x) );
