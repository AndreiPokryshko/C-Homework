// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetNum(string text)
{
    Console.Write(text);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int RecSumRange(int from, int to)
{
    if (from==to) return to;
    return from +RecSumRange(from+1,to);
}

int numM = GetNum("Введите М: ");
int numN = GetNum("Введите N: ");
Console.Write($"M = {numM}; N = {numN} -> {RecSumRange(numM, numN)}");
