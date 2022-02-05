// Найти максимальное из трех чисел
int firstNumber = new Random().Next(1, 100);
Console.WriteLine($"Первое число: {firstNumber} ");

int randomizer = new Random().Next(1, 100);

int secondNumber = randomizer;
Console.WriteLine($"Второе число: {secondNumber} ");

int thirdNumber = new Random().Next(1, 100);
Console.WriteLine($"Третье число: {thirdNumber} ");

int max = firstNumber;

if (max < secondNumber) max = secondNumber;
if (max < thirdNumber) max = thirdNumber;
Console.WriteLine($"Наибольшее из трех чисел -  {max} ");