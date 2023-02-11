// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

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

int arrayCountEven(int[] array)
{
    int size = array.Length;
    int count_even = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] % 2 == 0)
        {
            count_even++;
        }
    }
    return count_even;
}
Console.Clear(); 
Console.WriteLine("Введите количество элементов массива: ");
int kolich= Int32.Parse(Console.ReadLine());
int[] array = GetArray(kolich, 100, 999);
Console.Write("["+String.Join(", ", array)+"]");

int counterEvn = arrayCountEven(array);
Console.Write(" -> "+counterEvn);
