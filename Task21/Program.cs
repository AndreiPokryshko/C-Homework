// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
int GetNum(string text)
{
    Console.WriteLine(text);//для записи в функции текста запроса
    int number = int.Parse(Console.ReadLine());
    return number;
}

void Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    Console.Write("Расстояние между точками в 3D пространстве: ");
    double result = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)) + ((z2 - z1) * (z2 - z1)));
    result = Math.Round(result, 2);
    Console.Write(result);
}

int x1 = GetNum("Для точки А введите х ");
int y1 = GetNum("Для точки А введите y ");
int z1 = GetNum("Для точки А введите z ");
int x2 = GetNum("Для точки В введите х ");
int y2 = GetNum("Для точки В введите y ");
int z2 = GetNum("Для точки В введите z ");
Distance(x1, y1, z1, x2, y2, z2);