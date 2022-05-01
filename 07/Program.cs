// Удалить вторую цифру 3-х значного числа
Console.WriteLine("Введите 3-х значное число:");
int a = int.Parse(Console.ReadLine());

if (a > 99 && a < 1000)
{
    int b = a / 100;
    int c = a % 10;
    Console.WriteLine(b * 10 + c);
}
else
{
    Console.WriteLine("Число не 3-х значное!");
}
