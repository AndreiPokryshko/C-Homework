// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int GetNum(string text)
{
    Console.WriteLine(text); //для записи в функции текста запроса
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

string RecOutputNums(int num)
{
    if (num == 1)
        return num.ToString();
    return num + ", " + RecOutputNums(num - 1);
}

// void OutputNum(int num)
// {
//     if (num==0) return;
//     Console.Write(num);
//     OutputNum(num-1);
// }

int N = GetNum("Введите число N: ");
Console.Write($"N = {N} -> \"{RecOutputNums(N)}\"");

// OutputNum(N);
