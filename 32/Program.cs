// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
int[] array = new int [8];

for (int a = 0; a< array.Length;a++)
{
    array[a]= new Random().Next(0, 2);
    Console.Write(array[a]+" ");
    
}
Console.WriteLine();
