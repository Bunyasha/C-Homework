// Задача 54: В матрице чисел найти сумму элементов главной диагонали.

int[,] array = new int[5, 5];
int result = 0;

int DiagonalSum()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                result += array[i, j];
            }

        }
    }
    return result;
}


void FillArray()
{
    Random number = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = number.Next(1, 100);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();

    }
}

FillArray();
PrintArray(array);
DiagonalSum();
Console.WriteLine($"Cумма элементов главной диагонали равна {result}");

