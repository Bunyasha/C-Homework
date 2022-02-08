// Даны два числа. Показать большее и меньшее число

int firstNumber = new Random().Next(1, 100);
Console.WriteLine($"Первое число: {firstNumber}");
int secondNumber = new Random().Next(1, 100);
Console.WriteLine($"Второе число: {secondNumber}");
// int randomizer = new Random().Next(1,100);
if (firstNumber > secondNumber)
{
    Console.WriteLine($"Большее число: {firstNumber}");
    Console.WriteLine($"Меньшее число: {secondNumber}");
}
else
{
    Console.WriteLine($"Большее число: {secondNumber}");
    Console.WriteLine($"Меньшее число: {firstNumber}");
}



