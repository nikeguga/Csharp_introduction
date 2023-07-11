

//Task 1 Напишите программу, которая принимает на вход число и проверяет, является ли оно палиндромом. 
/*
bool IsPoly(int num)
{
    int reverse = 0;  // making new veriable to get reversed num
    int sym; // making veriable to get a symbol for the reverse
    int num1 = num; // not to change num for future check
    while(num1 /10 > 0) // setting up cycle to get to the last sym
    {
        sym = num1 % 10; // getting last 
        reverse = reverse * 10 + sym; //making last sym our first (as zero*10 = 0) and then creating reversed number step by step
        num1/=10; // on the last devision we will have num1 with only one char, so the cycle ends, but our reverse is incomplete
    }
    reverse = reverse*10 + num1; //adding last unit to compete reverse
    if(reverse == num) return true;
    else return false;
}

Console.WriteLine("Input a number to be checked for polyndromacy here: ");
int numbre = Convert.ToInt32(Console.ReadLine()); // НУМБРЕ!
Console.WriteLine($"claim that {numbre} is polyndrome is {IsPoly(numbre)}");
*/

//Task 2 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Destination(int a, int b, int c, int a1, int b1, int c1)
{
    double result = Math.Sqrt((a1 - a) * (a1 - a) + (b1 - b) * (b1 - b) + (c1 - c) * (c1 - c));
    return result;
}
Console.WriteLine("Input a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input c: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a1: ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input b: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input c: ");
int c1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Destination(a, b, c, a1, b1, c1));
*/

//Task 3 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void Cubes(int x)
{
    int count = 1;
    while(count <= x )
    {
        Console.WriteLine($"{count} - {count*count*count}");
        count ++;
    }
}

Console.WriteLine ("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());
Cubes(n);
*/