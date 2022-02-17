// Задача 34. 
// Написать программу замену элементов массива на противоположные.

void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(1, 100);
        index++;
    }
}

void PrintArray(int[] arr)
{
    int count = arr.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{arr[position]} ");
        position++;
    }
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);

Console.WriteLine();


int opposite = -1;
int result = 0;

for (int i = 0; i < array.Length; i++)
{
    result = array[i] * opposite;
    Console.Write($"{result} ");
}