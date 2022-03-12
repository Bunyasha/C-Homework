// Задача 67: 
//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

Console.Write("Введите натуральное число (значение M): ");
int numberM = int.Parse(Console.ReadLine());

Console.Write("Введите натуральное число (значение N): ");
int numberN = int.Parse(Console.ReadLine());

string NumbersRec(int numberM, int numberN)
{
    if (numberM <= numberN) return $"{numberM} " + NumbersRec(numberM + 1, numberN);
    else return string.Empty;
}

Console.WriteLine(NumbersRec(numberM, numberN));