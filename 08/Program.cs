// Выяснить, кратно ли число заданному, если нет, вывести остаток
Console.WriteLine("Введите проверяемое число:");
int numX = int.Parse(Console.ReadLine());
Console.Write("Введите число, кратно которому должно быть проверяемое:");
int numY  = int.Parse(Console.ReadLine());
if ((numX  % numY) == 0)
{
    Console.WriteLine("$ Число {numX} кратно числу {numY}!");
}

else
{
    Console.WriteLine("$ Число {numX} не кратно числу {numY}, остаток равен {numX % numY}"!);
}