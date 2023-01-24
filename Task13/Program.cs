//Task13
Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 100)
    Console.WriteLine("Третьей цифры нет");
else
{
    while (a >= 999)
    {
        a = a / 10;
    }
    Console.WriteLine($"Третьей цифрой числа является: {a % 10}");
}