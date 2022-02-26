// Задача 52: В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты.

int[,] array = new int[5, 5];
int[,] matrix = new int[5, 5];

void SquaredEvenIndex()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                matrix[i, j] = array[i, j] * array[i, j];
            }
            else{
                matrix[i,j] = array [i,j];
            }
        }
    }
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
SquaredEvenIndex();
Console.WriteLine();
PrintArray(matrix);

