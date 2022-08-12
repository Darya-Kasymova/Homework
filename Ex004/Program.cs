Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int even = 2;

while (number >= even)
{
    Console.WriteLine(even + " ");
    even = even + 2;
}