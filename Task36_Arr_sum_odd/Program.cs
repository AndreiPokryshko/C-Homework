// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int arrSumOdd(int[] arr)
{
    int size=arr.Length;
    int sum=0;
    for (int i = 1; i < size; i+=2)
    {
        sum=sum+arr[i];
    }
    return sum;
}

Console.Clear(); 
Console.WriteLine("Введите количество элементов массива: ");
int kolich= Int32.Parse(Console.ReadLine());
int[] array = GetArray(kolich, -9, 99);
Console.Write("["+String.Join(", ", array)+"]");

int sumOdd = arrSumOdd(array);
Console.Write(" -> "+sumOdd);