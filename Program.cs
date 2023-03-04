//сгенерировать двумерный массив вещественных чисел размером m на n элементов
Console.WriteLine("Введите кол-во элементов по горизонтали в массиве:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во элементов по вертикали в массиве:");
int n = Convert.ToInt32(Console.ReadLine());
float [ , ] mas = new float [m,n];
Random rnd = new Random();
for (int count1 = 0; count1 < m; count1++)
{
    for (int count2 = 0; count2 < n; count2++)
    {
        mas[count1,count2] = rnd.Next(-32654, 32654);
        Console.Write(" " + mas[count1,count2] + " ");
    }
    Console.WriteLine();
}

