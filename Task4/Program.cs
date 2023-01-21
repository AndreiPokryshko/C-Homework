// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.Clear();
int num1 = new Random().Next(0, 100);
int num2 = new Random().Next(0, 100);
int num3 = new Random().Next(0, 100);
int numMax=num1;
    if (numMax<num2) numMax=num2;
    if (numMax<num3) numMax=num3;
Console.WriteLine(num1);
Console.WriteLine(num2);
Console.WriteLine(num3);
Console.WriteLine($"maximum: {numMax}");