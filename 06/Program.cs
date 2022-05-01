// Дано число из отрезка [10, 99].Показать наибольшую цифру числа
Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine());

if ( a >=10 && a <= 99)
{
    Console.Write("Наибольшее цифра числа:");
    int second = (a % 10);
    int first = a / 10;
    if (first > second)
    {
        Console.WriteLine(first);
    }
    else
    {
        Console.WriteLine(second);
    }

}
else
{
    Console.WriteLine("Введен неверный диапазон!");
}