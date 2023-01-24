Console.Clear();
Console.Write("Введите цифру, обозначающую день недели: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a == 6 || a == 7)
    Console.WriteLine("Да, это выходной день!");
else
    Console.WriteLine("Нет, это не выходной день.");
