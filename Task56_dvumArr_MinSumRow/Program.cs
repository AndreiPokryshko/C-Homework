// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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
            //Console.Write(matrix[i, j] + "\t"); //выравнивание по умолчанию влево
            Console.Write(String.Format(" {0,3}", matrix[i, j])); //выравнивание вправо
        }
        Console.WriteLine();
    }
}

int RowMinSumMatrix(int[,] matrix)
{
    int lenRow = matrix.GetLength(0);
    int lenCol = matrix.GetLength(1);
    int[] arrTemp = new int[lenRow];
    int RowMinSum = -1;
    for (int i = 0; i < lenRow; i++)
    {
        int sum = 0;
        for (int j = 0; j < lenCol; j++)
        {
            sum += matrix[i, j];
            arrTemp[i] = sum;
        }
    }
    for (int k = 0; k < arrTemp.Length; k++)
    {
        int minSum = arrTemp[0];
        if (arrTemp[k] < minSum)
        {
            minSum = arrTemp[k];
            RowMinSum = k + 1;
        }
    }
    return RowMinSum;
}

//Получение размера двумерного массива
int m = GetNum("Введите кол-во строк:");
int n = GetNum("Введите кол-во столбцов:");

//Геренерация двумерного массива:
int[,] matrix = GenMatrix(m, n, 0, 9);
ShowMatrix(matrix);
Console.WriteLine("------------------");
int minRow = RowMinSumMatrix(matrix);
//Console.Write(String.Join(", ", matr));
//Вывод номера строки
Console.WriteLine("Номер строки с минимальной суммой элементов: " + minRow);
