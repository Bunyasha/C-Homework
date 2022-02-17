// Задача 38. 
//Найти сумму чисел одномерного массива стоящих на нечетной позиции.

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

//int index = 1;
int sum = 0;
for (int i=0; i < array.Length; i = i + 2)
{
    sum += array[i];
}
Console.WriteLine($"Сумма чисел, стоящих на нечетных позициях массива = {sum}.");