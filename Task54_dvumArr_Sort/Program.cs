// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
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

int[,] SortRowsMatrix(int[,] matrix)
{
    int lenRow = matrix.GetLength(0);
    int lenCol = matrix.GetLength(1);
    int temp = 0;

    for (int i = 0; i < lenRow; i++)
    {
        for (int k = 0; k < lenCol; k++)
        {
            for (int j = 0; j < lenCol - 1; j++)
            {
                if (matrix[i, j] < matrix[i, j + 1])
                {
                    temp = matrix[i, j];
                    matrix[i, j] = matrix[i, j + 1];
                    matrix[i, j + 1] = temp;
                }
            }
        }
    }
    return matrix;
}

//Получение размера двумерного массива
int m = GetNum("Введите кол-во строк:");
int n = GetNum("Введите кол-во столбцов:");

//Геренерация двумерного массива:
int[,] matrix = GenMatrix(m, n, 0, 99);
ShowMatrix(matrix);
Console.WriteLine("------------------");
int[,] matr = SortRowsMatrix(matrix);
ShowMatrix(matr);
