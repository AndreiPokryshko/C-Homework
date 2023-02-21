// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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

double[] AvgOnColumnMatrix(int[,] matrix)
{
    int lenRow = matrix.GetLength(0);
    int lenCol = matrix.GetLength(1);
    double[] avgColumn = new double[lenCol];
    for (int i = 0; i < lenCol; i++)
    {
        double sum = 0;
        for (int j = 0; j < lenRow; j++)
        {
            sum = sum + matrix[j, i];
        }
        avgColumn[i] = Math.Round(sum / lenRow,2);
    }
    return avgColumn;
}

//Получение размера двумерного массива
int m = GetNum("Введите кол-во строк:");
int n = GetNum("Введите кол-во столбцов:");

//Геренерация двумерного массива:
int[,] matrix = GenMatrix(m, n, 0, 10);
ShowMatrix(matrix);
Console.WriteLine();
Console.Write("Среднее арифметическое каждого столбца: " + String.Join("; ", AvgOnColumnMatrix(matrix)));
