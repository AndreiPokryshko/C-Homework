// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
Console.Clear();
//int num=new Random().Next(1,100)
Console.Write("Введите число:");
int num = Int32.Parse(Console.ReadLine());
if (num%2==0) 
{
    Console.Write(" -> да, чет!");
}
else
{
    Console.Write(" -> нет, нечет");
}