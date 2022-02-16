// Подсчитать сумму цифр в числе


Console.WriteLine("Введите число, сумму цифр которого вы хотели бы посчитать: ");
string number = Console.ReadLine();
int num = int.Parse(number);



int result = 0;

while (num > 0)
{
    result = result + num % 10;
    num = num / 10;
}

Console.WriteLine($"Сумма цифр в числе = {result}");
