//Написать программу, которая из имеющегося массива строк формирует массив, состоящий из
//символов и сток меньше или равных 3-ем.

string[] ArrLess4Words(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < 4)
            count++;
    }
    string[] arrOutput = new string[count];
    int index = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < 4)
        {
            arrOutput[index] = arr[i];
            index++;
        }
    }
    return arrOutput;
}

string[] arrSourceString =
{
    "Куда",
    "куда",
    "вы",
    "удалились.",
    "Там",
    "на",
    "неведомых",
    "дорож",
    "ках",
    "следы",
    "не",
    "мыс",
    "лимых",
    "зве",
    "рей"
};
string[] arrOut = ArrLess4Words(arrSourceString);
Console.Write($"[{String.Join("\", \"", arrSourceString)}] -> ");
Console.Write("[\"");
Console.Write(String.Join("\", \"", arrOut));
Console.Write("\"]");
