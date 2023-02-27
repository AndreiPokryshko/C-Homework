// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void ShowMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            //Console.Write(matrix[i, j] + "\t"); //выравнивание по умолчанию влево
            Console.Write(String.Format(" {0,3:D2}", matrix[i, j])); //выравнивание вправо
        }
        Console.WriteLine();
    }
}
int[,] GenMatrix4X4()
{
    int[,] matrix = new int[4, 4];
    int lenRow = matrix.GetLength(0);
    int lenCol = matrix.GetLength(1);
    int n = 1;
    for (int j = 0; j < lenCol; j++) //1
    {
        matrix[0, j] = n;
        n++;
    }
    for (int i = 1; i < lenRow; i++) //2
    {
        matrix[i, 3] = n;
        n++;
    }
    for (int j = 2; j > -1; j--) //3
    {
        matrix[3, j] = n;
        n++;
    }
    for (int i = 2; i > 0; i--) //4
    {
        matrix[i, 0] = n;
        n++;
    }
    for (int j = 1; j < 3; j++) //5
    {
        matrix[1, j] = n;
        n++;
    }
    for (int j = 2; j > 0; j--) //6
    {
        matrix[2, j] = n;
        n++;
    }
    return matrix;
}

//Вывод массива, заполненного спирально
int[,] matr4X4 = GenMatrix4X4();
ShowMatrix(matr4X4);
