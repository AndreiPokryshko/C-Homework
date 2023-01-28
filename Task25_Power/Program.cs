// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int GetNum(string text)
{
    Console.Write(text); //для записи в функции текста запроса
    int number = int.Parse(Console.ReadLine());
    return number;
}

int GetPowered(int num, int stepen)
{
    int result = num;
    for (int i = 1; i < stepen; i++)
    {
        result = result * num;
    }
    return result;
}
Console.Clear();
int numA = GetNum("Число А: ");
int numB = GetNum("Число B: ");
int numC = GetPowered(numA, numB);
Console.Write($"{numA}, {numB} -> {numC}");