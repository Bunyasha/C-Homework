// 61. Найти произведение двух матриц

Console.Write("Введите количество строк для первой матрицы: ");
int numberI = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов для первой матрицы: ");
int numberJ = int.Parse(Console.ReadLine());

Console.Write("Введите количество строк для второй матрицы: ");
int numberM = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов для второй матрицы: ");
int numberN = int.Parse(Console.ReadLine());

if (numberI != numberM || numberJ != numberN)
{
    Console.WriteLine("Умножение матриц невозможно, так как не совпадает количество строк и столбцов");
}

int[,] matrixFirst = new int[numberI, numberJ];
int[,] matrixSecond = new int[numberM, numberN];
int[,] multipledMatrix = new int[numberI, numberJ];

Random rnd = new Random();

void FillArray(int[,] matrix)
{
    for (int i = 0; i < numberI; i++)
    {
        for (int j = 0; j < numberN; j++)
        {
            matrixFirst[i, j] = rnd.Next(1, 100);
            matrixSecond[i, j] = rnd.Next(1, 100);
        }

    }
}

void PrintArray(int[,] matrix)
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

void MultiplyMatrix()
{
    for (int i = 0; i < numberI; i++)
    {
        for (int j = 0; j < numberJ; j++)
        {
            multipledMatrix[i, j] = matrixFirst[i, j] * matrixSecond[i, j];

        }

    }
}


Console.WriteLine("______________");
FillArray(matrixFirst);
FillArray(matrixSecond);
Console.WriteLine("Первая сгенерированная матрица: ");
PrintArray(matrixFirst);
Console.WriteLine("Вторая сгенерированная матрица: ");
PrintArray(matrixSecond);
Console.WriteLine("Произведение двух матриц: ");
MultiplyMatrix();
PrintArray(multipledMatrix);

