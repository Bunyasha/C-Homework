// Задача 59: В прямоугольной матрице найти строку с наименьшей суммой элементов.

int[,] array = new int[5, 7];

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

void FindLineSum(int[,] array)
{
    //int minSumLine = int.MinValue;
    //int indexMinLine = 0;
    int i = 0;

    while (i < array.GetLength(0))
    {
        int SumLine = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            SumLine += array[i, j];
            /*if (SumLine < minSumLine)
            {
                minSumLine = SumLine;
                indexMinLine = i;

            }*/

        }
        Console.WriteLine($"Сумма чисел {i + 1} строки равна {SumLine}");
        i++;
    }
}

/* for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = array.GetLength(1) - 1; j > 0; j--)
        {

            for (int k = 0; k < j; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = temp;
                }
            }
        }
    }*/


FillArray();
PrintArray(array);
Console.WriteLine();
FindLineSum(array);