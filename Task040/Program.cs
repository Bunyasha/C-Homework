// Задача 40.
// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом.




void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(0, 100);
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

// Считается ли читерством, использование методов Max и Min?
int max = array.Max();
Console.WriteLine($"Максимальное число массива: {max}.");
int min = array.Min();
Console.WriteLine($"Минимальное число массива: {min}.");
int result = max - min;
Console.WriteLine($"Разница между максимальным и минимальным числом массива составляет: {result}");
