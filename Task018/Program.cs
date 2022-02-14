// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

Console.Write($"¬(X ⋁ Y) = ¬X ⋀ ¬Y");

bool X = false;
bool Y = true;

if (!(X || Y) == (!X) && (!Y));
Console.WriteLine("При Х = false и Y = true утвержение - истинно" );
else
{
Console.WriteLine("При Х = true и Y = true утвержение - ложно" );
}
bool X = false;
bool Y = false;

if (!(X || Y) == (!X) && (!Y));
Console.WriteLine("При Х = false и Y = false утвержение - истинно" ); 
else
{
Console.WriteLine("При Х = false и Y = false утвержение - ложно" );
}
    

bool X = true;
bool Y = true;

if (!(X || Y) == (!X) && (!Y));
Console.WriteLine("При Х = true и Y = true утвержение - истинно" );
else
{
Console.WriteLine("При Х = true и Y = true утвержение - ложно" );
}
    

bool X = false;
bool Y = true;

if (!(X || Y) == (!X) && (!Y));
Console.WriteLine("При Х = true и Y = false утвержение - истинно" );
else
{
Console.WriteLine("При Х = true и Y = true утвержение - ложно" );
}