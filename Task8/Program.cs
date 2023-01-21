// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.Clear();
Console.WriteLine("Введите число от 1:");
int num = Int32.Parse(Console.ReadLine());
int count = 0;
Console.WriteLine($"Все четные от 1 до {num}: ");
while (count < num)
{
    count++;
    if (count % 2 == 0)
    {

        Console.Write($"{count}, ");


    }
}