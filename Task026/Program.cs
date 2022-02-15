// Возведите число А в натуральную степень B используя цикл

Console.Write("Введите число (A), которое вы хотели бы возводить в степень (B): ");
string numberA = Console.ReadLine();
int A = int.Parse(numberA);

Console.Write("Введите число B (степень числа А): ");
string numberB = Console.ReadLine();
int B = int.Parse(numberB);

int pow = 1;
for (int i = 0; i< B; i++)
{
    pow *= A;
}
Console.WriteLine($"{A} в степени {B} = {pow}");