// Показать четные числа от 1 до N
Console.WriteLine("Введите число:");
int max = int.Parse(Console.ReadLine());

int x = 1;

while (x <= max)
{
    if (x % 2 == 0)
    {
        Console.Write(" " + x);
    }
    x++;
}


