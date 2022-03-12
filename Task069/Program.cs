// Задача 69: 
//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("Введите натуральное число (значение M): ");
int numberM = int.Parse(Console.ReadLine());

Console.Write("Введите натуральное число (значение N): ");
int numberN = int.Parse(Console.ReadLine());


int NumbersRec(int numberM, int numberN)
{
    //int sum = 0;
    if (numberM <= numberN) return numberM  += NumbersRec(numberM + 1, numberN);
    else return 0;
}

Console.WriteLine($"Сумма натуральных элементов в промежутке от {numberM} до {numberN} равна {NumbersRec(numberM, numberN)}");

