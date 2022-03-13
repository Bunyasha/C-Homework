// Задача 71: 
// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Write("Введите неотрицательное число (значение M): ");
int numberM = int.Parse(Console.ReadLine());

Console.Write("Введите неотрицательное число (значение N): ");
int numberN = int.Parse(Console.ReadLine());

int AckermanFunction(int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberM > 0 && numberN == 0) return AckermanFunction(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return AckermanFunction(numberM - 1, AckermanFunction(numberM, numberN - 1));
    return AckermanFunction(numberM, numberN);
}

Console.WriteLine($"Функция Аккермана для чисел M {numberM} и N {numberN} равна {AckermanFunction(numberM, numberN)}");

