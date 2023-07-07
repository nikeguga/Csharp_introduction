// and here we go with the seminar #2
//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. Создаем метод
/*
int CutNumber(int number)
{

    int hundreds = number/ 100;
    int unit = number % 10;
    int res = hundreds*10 + unit;
    return res;
}
*/
// генерируем случайные

/*int random = new Random().Next(100, 1000); // от 100 включая до 1000 не включая её
int ewsult = CutNumber(random);
Console.WriteLine($"new version of {random} is {ewsult}"); //форматированный вывод*/

// Task 2 Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно a и b
/*
bool IsDividable(int num, int a, int b)
{
    if(num % a == 0 && num % b == 0) return true; // и - && или - ||
    else return false;
}

Console.Write("Input for check: ");
int Check = Convert.ToInt32(Console.ReadLine());
Console.Write("First div: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Second div: ");
int b = Convert.ToInt32(Console.ReadLine());
bool result = IsDividable(Check, a, b);
Console.WriteLine(result); */

//Task 3 Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
/*
int LargeNumber(int num)
{
    int a = num % 10;
    int b = num / 10;
    
    if( a > b)
    return a;
    else
    return b;
}

int random1 = new Random().Next(10, 100);
int result = LargeNumber(random1);
Console.WriteLine($"Biggest number from {random1} is {result}");
*/

//Task 4 Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
/*
bool IsSquare(int num1, int num2)
{
    if(num1/num2 == num2 || num2/num1 == num1) return true;
    else return false;
}

Console.Write("Input num1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input num2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
bool result = IsSquare(num1, num2);
Console.WriteLine($"claim that one of {num1} and {num2} is square is {result}");*/


int ThirdNumber(int number)
{
    while (number % 1000 > 0)
    {
        if (number % 100 > 0 && number % 1000 <= 0)
        {
            int result = number % 10;
            return result;
        }
        else
        {
            number /= 10;
        }
    }
    
    return -1; // Возвращаем -1, если третья цифра не найдена.
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = ThirdNumber(number);

if (result > 0)
{
    Console.WriteLine($"Third number of {number} is {result}");
}
else
{
    Console.WriteLine("Try a bigger number");
}