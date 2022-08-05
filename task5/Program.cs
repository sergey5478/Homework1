Console.WriteLine("введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if(numberA > numberB)
{
    Console.WriteLine($"Max:{numberA}");
    Console.WriteLine($"Min:{numberB}");
}
else
{
    Console.WriteLine($"Max:{numberB}");
    Console.WriteLine($"Min:{numberA}");
}
