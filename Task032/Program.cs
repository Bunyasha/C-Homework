﻿// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(0, 2);
                index++;
    }
}

void PrintArray(int[] arr)
{
    int count = arr.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(arr[position]);
        position++;
    }
}

int[] array = new int[8];

FillArray(array);
PrintArray(array);

