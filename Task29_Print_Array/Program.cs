// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
int[] fillArr()
{
    int[] array = new int[8];
    for (int i = 0; i < 8; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}

void PrintArr(int[] arr)
{
    int size = arr.Length;
    Console.Write("[");
    for (int i = 0; i < size - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[size - 1] + "]");
}

int[] myarray = fillArr();
PrintArr(myarray);
