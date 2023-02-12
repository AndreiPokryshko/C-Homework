// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

//Генерация массива
int[] GetArray(int size, int start, int finish)
{
    int[] emptyArray = new int[size];
    for (int index = 0; index < size; index++)
    {
        emptyArray[index] = new Random().Next(start, finish + 1);
    }
    return emptyArray;
}

int arrDiffMaxMin(int[] arr)
{
    int size=arr.Length;
    int diff=0;
    int max=arr[0];
    int min=arr[0];
    for (int i = 1; i < size; i++)
    {
        if (max<arr[i]) max=arr[i];
        if (min>arr[i]) min=arr[i];
    }
    diff=max-min;
    return diff;
}

Console.Clear(); 
Console.WriteLine("Введите количество элементов массива: ");
int kolich= Int32.Parse(Console.ReadLine());
int[] array = GetArray(kolich, 1, 99);
Console.Write("["+String.Join(", ", array)+"]");

int diff = arrDiffMaxMin(array);
Console.Write(" -> "+diff);