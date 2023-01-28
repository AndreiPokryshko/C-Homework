// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int GetNum(string text)
{
    Console.Write(text); //для записи в функции текста запроса
    int number = int.Parse(Console.ReadLine());
    return number;
}
int GetSum(int number)
{
    int sum = 0;

    while (number >1)
    {
        sum = sum + number % 10;
        number = number / 10;
    }

    return sum;
}
int num=GetNum("Введите число: ");
Console.WriteLine(num + " -> "+GetSum(num));
