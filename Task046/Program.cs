// Написать программу масштабирования фигуры

string strValue = "(0,0) (2,0) (2,2) (0,2)";
Console.WriteLine("Введите множитель: ");
int k = int.Parse(Console.ReadLine());

strValue = strValue.Replace("(", "").Replace(")", "").Replace(",", " ");

// разбиваем строку на массив. разделитель в данном случае - пробел.
string[] strArray = strValue.Split(" ");

string result = string.Empty;

foreach (var item in strArray)
{
    Console.Write($"{item} ");
}
Console.WriteLine();

for (int i = 0; i < strArray.Length - 1; i = i + 2)
{
    int x = k * int.Parse(strArray[i]);
    int y = k * int.Parse(strArray[i + 1]);

    Console.WriteLine($"X = {x}, Y = {y}");

    result = result + $"({x}, {y}) ";
}

Console.WriteLine("_________________");
Console.WriteLine(result);