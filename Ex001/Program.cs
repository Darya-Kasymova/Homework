Console.WriteLine("Введите 2 числа: ");
Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());
if (numberA > numberB)
{
    Console.WriteLine("Число " + numberA + " большее");
    Console.Write("Число " + numberB + " меньшее");
}

else
{
    Console.WriteLine("Число " + numberB + " большее");
    Console.WriteLine("Число " + numberA + " меньшее");
}
