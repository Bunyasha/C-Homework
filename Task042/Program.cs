// Определить сколько чисел больше 0 введено с клавиатуры

Console.Write("Введите колличество чисел: ");
int number = int.Parse(Console.ReadLine());
int count = 0;
for (int i = 0; i < number; i++)
{
    Console.Write($"Введите число {i + 1}: ");
    int x = int.Parse(Console.ReadLine());
    if (x > 0)
        count++;
}
Console.WriteLine($"Положительных чисел: {count}");
