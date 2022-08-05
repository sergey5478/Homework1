Console.WriteLine("введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число: ");
int numberC = Convert.ToInt32(Console.ReadLine());
int x;
if (numberA > numberB)
{
    x = numberA;
}
else
{
    x = numberB;
}
if (numberC > x)
{
    x = numberC;
}
Console.WriteLine($"Max:{x}");
