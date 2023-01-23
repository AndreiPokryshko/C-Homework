// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
int GetNum(string text)
{
    Console.WriteLine(text);//для записи в функции текста запроса
    int number = int.Parse(Console.ReadLine());
    return number;
}

void MakeСube(int number)
{
    int i=1;
    while (i<number)
    {
        Console.Write(i + "=" + Math.Pow(i, 3)+", ");
        i++;
    }
    Console.Write(number + "=" + Math.Pow(number, 3)+", ");
}
int num= GetNum("Введите число чтобы получить куб всех чисел по него:");
MakeСube (num);