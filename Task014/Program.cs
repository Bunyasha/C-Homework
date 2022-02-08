// Найти третью цифру числа или сообщить, что её нет

int GetRandom()
{
    int number = new Random().Next(1, 1000);
    return number;
}
int randomizer = GetRandom();
Console.WriteLine($"Сгенерированное число - {randomizer}");
if (randomizer > 100 || randomizer == 100)
{
    int result = randomizer % 10;
    Console.WriteLine($"Третья цифра числа - {result}");
}
else
{
    Console.WriteLine($"Число состоит из двух цифр");
}