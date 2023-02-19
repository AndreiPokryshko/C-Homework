// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int countPositiv(string nums)
{
    string[] arrStr = nums.Split(',', ' ', StringSplitOptions.RemoveEmptyEntries);
    int[] arrInt = new int[arrStr.Length];
    int count = 0;
    for (int i = 0; i < arrInt.Length; i++)
    {
        arrInt[i] = Convert.ToInt32(arrStr[i]);
        if (arrInt[i] > 0)
        {
            count++;
        }
    }
    return count;
}

Console.Write("Введите цифры через запятые без пробелов: ");
string textInput = Console.ReadLine();
Console.Write($"[{textInput}] -> {countPositiv(textInput)}");
