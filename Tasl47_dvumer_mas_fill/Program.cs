// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
int GetNum(string text)
{
    Console.WriteLine(text); //для записи в функции текста запроса
    int number = int.Parse(Console.ReadLine());
    return number;
}

double[,] GenMatrix(int rows, int columns, int from, int to)
{
    double[,] result = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(from, to+1);
        }
    }
    return result;
}

void ShowMatrix(double[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            //Console.Write(matrix[i, j] + "\t"); //выравнивание по умолчанию влево
            Console.Write(String.Format(" {0,3}", matrix[i,j]));//выравнивание вправо
        }
        Console.WriteLine();
    }
}

//Получение размера двумерного массива
int m = GetNum("Введите кол-во строк m:");
int n = GetNum("Введите кол-во столбцов n:");

//Геренерация двумерного массива:
double[,] matrix = GenMatrix(m, n, -9, 9);
ShowMatrix(matrix);