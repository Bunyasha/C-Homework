// Задача 36. 
//Задать массив, заполнить случайными положительными трёхзначными числами. 
//Показать количество нечетных\четных чисел.

void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(100, 1000);
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

int countEven = 0;
int countOdd = 0;
int index = 0;
do
{
    if (array[index] % 2 == 0)
    {
        countEven = countEven + 1;
        index++;
    }

    else
    {
        countOdd = countOdd + 1;
        index++;
    }

}
while (index < array.Length);

Console.WriteLine($"Количество четных чисел в массиве: {countEven}.");
Console.WriteLine($"Количество нечетных чисел в массиве: {countOdd}.");

