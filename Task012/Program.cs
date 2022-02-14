// Удалить вторую цифру трёхзначного числа

int GetRandom()
{
    int number = new Random().Next(100, 1000);
    return number;
}
int randomizer = GetRandom();
Console.WriteLine($"Сгенерированное число - {randomizer}");
int result1 = randomizer / 100;
int result2 = randomizer % 10;
Console.WriteLine($"Число с удаленной второй цифрой - {result1}_{result2}");
