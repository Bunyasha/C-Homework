// Задача 48.
// Показать двумерный массив размером m×n заполненный целыми числами.

Console.Write("Введите параметр М (количество строк): ");
int numberM = int.Parse(Console.ReadLine());

Console.Write("Введите параметр N (количество столбцов): ");
int numberN = int.Parse(Console.ReadLine());

int[,] matrix = new int[numberM, numberN];

Random rnd = new Random();

void FillArray()
{
    for (int i = 0; i < numberM; i++)
    {
        for (int j = 0; j < numberN; j++)
        {
            matrix[i, j] = rnd.Next(-100, 100);

        }

    }
}

void PrintArray()
{
    for (int i = 0; i < numberM; i++)
    {
        for (int j = 0; j < numberN; j++)
        {
            Console.Write($"{matrix[i, j]} ");

        }
        Console.WriteLine();
    }
}


FillArray();
PrintArray();