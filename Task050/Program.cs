//Задача 50.
// В двумерном массиве n×k заменить четные элементы на противоположные.

Console.Write("Введите параметр N (количество строк): ");
int numberN = int.Parse(Console.ReadLine());

Console.Write("Введите параметр K (количество столбцов): ");
int numberK = int.Parse(Console.ReadLine());

int[,] matrix = new int[numberN, numberK];

Random rnd = new Random();

void FillArray()
{
    for (int i = 0; i < numberN; i++)
    {
        for (int j = 0; j < numberK; j++)
        {
            matrix[i, j] = rnd.Next(-100, 100);

        }

    }
}

void PrintArray()
{
    for (int i = 0; i < numberN; i++)
    {
        for (int j = 0; j < numberK; j++)
        {
            Console.Write($"{matrix[i, j]} ");

        }
        Console.WriteLine();
    }
}

void PrintNewArray()
{
    for (int i = 0; i < numberN; i++)
    {

        for (int j = 0; j < numberK; j++)
        {
            if (matrix[i, j] % 2 == 0)
            {
                matrix[i, j] = matrix[i, j] * -1;

            }
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
FillArray();
PrintArray();
Console.WriteLine("Массив, в котором четные элементы заменены на противоположные");
PrintNewArray();
