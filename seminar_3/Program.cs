// methods on plane surface, coordinates

//Напишите программу, которая по заданному номеру четверти системы координат,
// показывает диапазон возможных координат точек в этой четверти (x и y).
/*
void ShowDip(int quad)
{
    if(quad == 1)
    {
        Console.WriteLine(" x > 0 and y > 0");
    }
    else if(quad == 2)
    {
        Console.WriteLine(" x < 0 and y > 0");
    }
    else if(quad == 3)
    {
        Console.WriteLine(" x < 0 and y < 0");
    }
    else if(quad == 4)
    {
        Console.WriteLine(" x > 0 and y > 0");
    }
    else Console.WriteLine("This is not a quad");
}

Console.WriteLine("User input of the QUAD: ");
int quad = Convert.ToInt32(Console.ReadLine());
ShowDip(quad);
*/

// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
// и выдаёт номер четверти плоскости, в которой находится эта точка.

/*
void Showquad(int x, int y)
{
    if(x > 0 && y > 0)
    {
        Console.WriteLine("first quad");
    }
    else if(x < 0 && y > 0)
    {
        Console.WriteLine("second quad");
    }
    else if(x < 0 && y < 0)
    {
        Console.WriteLine("third quad");
    }
    else if(quad == 4)
    {
        Console.WriteLine(" x > 0 and y < 0");
    }  
    else if Console.WriteLine("fourth quad");
    else return -1;
}

Console.WriteLine("User input x ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("User input y ");
int y = Convert.ToInt32(Console.ReadLine());
Showquad(x, y);
*/
//Напишите программу, которая принимает 
//на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21
//Math.Sqrt() -квадрат от гипотенузы возвращает double  метод на 4 ввода
/*
void SizeOf(int a, int b, int a1, int b1)
{
    Console.Write(Math.Sqrt((a1 - a)*(a1 - a) + (b1 - b)*(b1 - b)));
}

Console.WriteLine ("Input a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input a1: ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
SizeOf(a, b, a1, b1);
*/

//Напишите программу, 
//которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
/*
void Quads(int x)
{
    int count = 0;
    while(count <= x )
    {
        Console.WriteLine($"{count} - {count*count}");
        count ++;
    }
}

Console.WriteLine ("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());
Quads(n); */