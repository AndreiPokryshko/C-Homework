// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
int GetNum(string text)
{
    Console.WriteLine(text); //для записи в функции текста запроса
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,] GenMatrix(int rows, int columns, int from, int to)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(from, to + 1);
        }
    }
    return result;
}

void ShowMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(String.Format(" {0,3}", matrix[i, j])); //выравнивание вправо
        }
        Console.WriteLine();
    }
}

int PrintValue(int[,] matrix, int raw, int col)
{
    return matrix[raw-1, col-1];
}

//Получение размера двумерного массива
int m = GetNum("Введите кол-во строк в массиве:");
int n = GetNum("Введите кол-во столбцов:");

//Запрос индекса илемента массива
int raw = GetNum("Введите на какой строке искать:");
int column = GetNum("И в каком столбце:");
if (raw > m || column > n)
{
    Console.Write($"Для индекса {raw},{column} -> такого числа в массиве нет");
}
else
{
    //Геренерация и вывод двумерного массива:
    int[,] matrix = GenMatrix(m, n, -100, 100);
    ShowMatrix(matrix);
    Console.WriteLine();
    //вывод элемента массива
    int val = PrintValue(matrix, raw, column);
    Console.Write($"По индексу: {raw},{column} элемент матрицы имеет значение: {val}");
}
