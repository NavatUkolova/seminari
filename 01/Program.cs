// По двум заданным числам проверить является ли первое квадратом второго
Console.Write("Введите число а:");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число b:");
int b = int.Parse(Console.ReadLine());
if (a == b*b)
{
    Console.WriteLine("Является");
}
else
{
    Console.WriteLine("Не является");
}

