// Показать вторую цифру трёхзначного числа

int GetRandom()
{
    int number = new Random().Next(100, 1000);
    return number;
}
int randomizer = GetRandom();
Console.WriteLine($"Сгенерированное число - {randomizer}");
int result = randomizer % 100 / 10;
Console.WriteLine($"Вторая цифра числа - {result}");



