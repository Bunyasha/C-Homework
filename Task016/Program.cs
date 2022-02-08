// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.WriteLine("Введите номер дня недели: ");
string dayNumber = Console.ReadLine();
int day = int.Parse(dayNumber);
if (day <= 5)
{
    Console.WriteLine($"Указан будний день");
}
else
{
    Console.WriteLine($"Вы указали выходной");
}

