// Найти расстояние между точками в пространстве 2D/3D

Console.WriteLine("Вы хотели бы найти расстояние между точками в двухмерном или трехмерном пространстве?");
Console.WriteLine("Введите 2, если в двухмерном. 3 - если в трехмерном ");
string str1 = Console.ReadLine();
int number = int.Parse(str1);

if (number == 2)
{
    Console.WriteLine("Для того, чтобы найти расстояние между точками в двухмерном пространстве, введите координаты: ");
    Console.Write("X1 = ");
    string strX1 = Console.ReadLine();
    double numX1 = int.Parse(strX1);

    Console.Write("Y1 = ");
    string strY1 = Console.ReadLine();
    double numY1 = int.Parse(strY1);

    Console.Write("X2 = ");
    string strX2 = Console.ReadLine();
    double numX2 = int.Parse(strX2);

    Console.Write("Y2 = ");
    string strY2 = Console.ReadLine();
    double numY2 = int.Parse(strY2);

    double X = Math.Pow((numX2 - numX1), 2);
    double Y = Math.Pow((numY2 - numY1), 2);
    double result = Math.Sqrt(X + Y);

    Console.WriteLine($"Расстояние между точками в пространстве 2D = {result}");
}

else if (number == 3)
{
    Console.WriteLine("Для того, чтобы найти расстояние между точками в треххмерном пространстве, введите координаты: ");
    Console.Write("X1 = ");
    string strX1 = Console.ReadLine();
    double numX1 = int.Parse(strX1);

    Console.Write("Y1 = ");
    string strY1 = Console.ReadLine();
    double numY1 = int.Parse(strY1);

    Console.Write("Z1 = ");
    string strZ1 = Console.ReadLine();
    double numZ1 = int.Parse(strZ1);

    Console.Write("X2 = ");
    string strX2 = Console.ReadLine();
    double numX2 = int.Parse(strX2);

    Console.Write("Y2 = ");
    string strY2 = Console.ReadLine();
    double numY2 = int.Parse(strY2);

    Console.Write("Z2 = ");
    string strZ2 = Console.ReadLine();
    double numZ2 = int.Parse(strZ2);

    double X = Math.Pow((numX2 - numX1), 2);
    double Y = Math.Pow((numY2 - numY1), 2);
    double Z = Math.Pow((numZ2 - numZ1), 2);
    double result3D = Math.Sqrt(X + Y + Z);

    Console.WriteLine($"Расстояние между точками в пространстве 3D = {result3D}");
}







