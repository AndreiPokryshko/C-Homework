// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int GetNum(string text)
{
    Console.WriteLine(text); //для записи в функции текста запроса
    int number = int.Parse(Console.ReadLine());
    return number;
}

string[,,] GenMatrix(int rows, int columns, int depth, int from, int to)
{
    string[,,] result = new string[rows, columns, depth];
    int num = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int z = 0; z < depth; z++)
            {
                num = new Random().Next(from, to + 1);
                result[i, j, z] = $"{num}({i},{j},{z})";
            }
        }
    }
    return result;
}

// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
void ShowMatrix(string[,,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int depth = matrix.GetLength(2);
    for (int z = 0; z < depth; z++)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(String.Format(" {0,3}", matrix[i, j, z])); //выравнивание вправо
            }
            Console.WriteLine();
        }
    }
}

//Получение размера 3d массива
int m = GetNum("Введите кол-во строк m:");
int n = GetNum("Введите кол-во столбцов n:");
int k = GetNum("Введите глубину:");

//Геренерация 3d массива:
string[,,] matrix = GenMatrix(m, n, k, 10, 99);
ShowMatrix(matrix);
