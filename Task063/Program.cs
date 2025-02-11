﻿// Задача 63
// Сформировать трехмерный массив не повторяющимися двузначными числами 
//показать его построчно на экран выводя индексы соответствующего элемента

int[,,] array = new int[3, 3, 2];
List<int> numbers = new List<int>();
Random number = new Random();

int CheckNumbers()
{

    while (true)
    {
        int newNumber = number.Next(10, 100);
        if (!numbers.Contains(newNumber))
        {
            numbers.Add(newNumber);
            return newNumber;
        }
    }
}


void FillArray()
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = CheckNumbers();

            }

        }
    }
}

void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}, индекс элемента {i}, {j}, {k}   ");
                Console.WriteLine();
            }

        }
        Console.WriteLine();

    }
}

FillArray();
PrintArray();

