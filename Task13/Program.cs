// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Clear();
Console.WriteLine("Для вывода 3й цифры введите число:");
int num = Math.Abs(Int32.Parse(Console.ReadLine()));
int dig = 0;
int digit3 = -1;
//Console.Write("Значения  разрядов: ");
while (num > 0)
{
    dig++;
    num = num / 10;
    if (dig == 2) digit3 = num % 10;
//    Console.Write(num + ", ");
}
if (dig < 3)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
//    Console.WriteLine("кол-во разрадов: " + dig);
    Console.WriteLine("Третья цифра: " + digit3);
}