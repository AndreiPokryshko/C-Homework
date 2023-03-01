// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int GetNum(string text)
{
    Console.Write(text);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int RecAkker(int m, int n)
{
    if (m == 0)
        return n + 1;
    if ((n == 0) && (m != 0))
        return RecAkker(m - 1, 1);
    else
        return RecAkker(m - 1, RecAkker(m, n - 1));
}

int numM = GetNum("Введите М: ");
int numN = GetNum("Введите N: ");
Console.Write($"M = {numM}; N = {numN} -> A(M,N) = {RecAkker(numM, numN)}");
