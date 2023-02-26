// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
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

int[,] MultiplicatonMatrix(int[,] matrixA, int[,] matrixB)
{
    int lenRowA = matrixA.GetLength(0);
    int lenColA = matrixA.GetLength(1);
    int lenRowB = matrixB.GetLength(0);
    int lenColB = matrixB.GetLength(1);
    int[,] matrixC = new int[lenRowA, lenColB];
    for (int i = 0; i < lenRowA; i++)
    {
        for (int j = 0; j < lenColB; j++)
        {
            matrixC[i, j] = 0;
            for (int k = 0; k < lenColA; k++)
            {
                matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return matrixC;
}

//Получение размера двумерного массива
int m = GetNum("Введите кол-во строк для matrixA: ");
int n = GetNum("Введите кол-во столбцов для matrixA: ");
int c = GetNum("Введите кол-во столбцов для matrixB: ");

//Геренерация двумерного массива:
int[,] matrixA = GenMatrix(m, n, 0, 9);
ShowMatrix(matrixA);
Console.WriteLine();
int[,] matrixB = GenMatrix(n, c, 0, 9);
ShowMatrix(matrixB);
Console.WriteLine("------------------");

int[,] newMatrix = MultiplicatonMatrix(matrixA, matrixB);
ShowMatrix(newMatrix);
