// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.Clear();
Console.WriteLine("Enter 3-digital number:");
int num = Int32.Parse(Console.ReadLine());
int digit1 = num / 10;
int digit2 = digit1 % 10;
Console.WriteLine(digit2);