// Дополнительная задача
Console.Clear();
Console.WriteLine("Введите числа:");
int a = Convert.ToInt32(Console.ReadLine()), max1 = a, max2 = 0;
while (a != 0)
{
        a = Convert.ToInt32(Console.ReadLine());
        if (a > max1)
        {
            max2 = max1;
            max1 = a;
        }
        else if (a > max2)
        max2 = a;
}
Console.WriteLine($"Второе по величене число: {max2}");