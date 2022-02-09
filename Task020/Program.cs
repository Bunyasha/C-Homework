// Задать номер четверти, показать диапазоны для возможных координат

Console.WriteLine("Введите номер четверти координатной плоскости: ");
string quarterNumber = Console.ReadLine();
int number = int.Parse(quarterNumber);
if (number == 1)
{
    Console.WriteLine($"В 1 четверти значения X и Y будут больше 0 (или положительными).");
}
else if (number == 2)
{
    Console.WriteLine($"В четверти 2 значения Y будут положительными, а координаты X будут иметь знак минус.");
}
else if (number == 3)
{
    Console.WriteLine($"В четверти 3 обе координаты X и Y будут иметь отрицательные значения.");
}
else if (number == 4)
{
    Console.WriteLine($"В последней 4 четверти значение X будет положительным, а Y - отрицательным.");
}
else if (number == 0)
{
    Console.WriteLine($"Четверти 0 не существует. Если X и Y равны 0, то точка находится на оси координат.");
}
else
{
    Console.WriteLine($"Такой четверти на координатной плоскости не существует.");
}