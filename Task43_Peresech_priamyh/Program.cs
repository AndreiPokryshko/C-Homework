// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
double GetNum(string text)
{
    Console.Write(text); //для записи в функции текста запроса
    double number = Convert.ToInt32(Console.ReadLine());
    return number;
}
double calcX(double k1, double k2, double b1, double b2)
{
    double x = 0;
    x = (-b2 + b1) / (-k1 + k2);
    return x;
}

double calcY(double k1, double k2, double b1, double b2)
{
    double y = 0;
    y = k1 * ((b2 - b1) / (k1 - k2)) + b1;
    return y;
}

//запрос четырех постоянных:
double k1 = GetNum("Введите к1: ");
double k2 = GetNum("Введите к2: ");
double b1 = GetNum("Введите в1: ");
double b2 = GetNum("Введите в2: ");
if (k1 == k2)
{
    Console.Write("Упс.. Сорян, прямые параллельны. :)");
}
else
{
    //вывод расчета
    double resultX = calcX(k1, k2, b1, b2);
    double resultY = calcY(k1, k2, b1, b2);
    Console.Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({resultX};{resultY})");
}
