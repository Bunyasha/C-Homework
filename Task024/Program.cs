// Найти кубы чисел от 1 до N
Console.WriteLine("Введите число N (максимальное число для возведения в куб): ");
string numberN = Console.ReadLine();
int n = int.Parse(numberN);

Console.WriteLine($"Таблица кубов от 1 до указанного Вами числа:");

int value = 1;
int power = 3;
while (value <= n)
{
    Console.WriteLine($"{value}^{power} = {value * value * value}");
    value++;
}





