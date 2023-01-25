// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
int GetNum(string text)
{
    Console.Clear();
    Console.WriteLine(text);
    int num = Int32.Parse(Console.ReadLine());
    return num;
}
int fiveDigitNum = GetNum("Введите пятизначное число число: ");
//Console.WriteLine(fiveDigitNum);
if (fiveDigitNum / 10000 < 10 & fiveDigitNum / 10000 >= 1)
{
    if (fiveDigitNum % 10 == Math.Abs(fiveDigitNum / 10000) & Math.Abs(fiveDigitNum / 10) % 10 == Math.Abs(fiveDigitNum / 1000) % 10)
    {
        Console.WriteLine($"{fiveDigitNum}-> да");
    }
    else
    {
        Console.WriteLine($"{fiveDigitNum}-> нет");
    }
}
else
{
    Console.WriteLine("Введена не 5 знач цифра");
}