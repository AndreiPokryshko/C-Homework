﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Console.Clear();
Console.WriteLine("Введите по счету день недели (1-7):");
int num = Int32.Parse(Console.ReadLine());
if (num == 6 || num == 7)
{
    Console.WriteLine("Это выходной день");
}
else
{
    Console.WriteLine("Это рабочий день");
}