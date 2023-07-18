// task 1  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//first way // basic while
/*
int Degree(int a, int b)

{
    int i = 1; // we don't need 0 degree here
    int result = a;
    while (i < b )  // as we already have a in 1st degree 
    {
        result = result * a;
        i++;
    }
    return result;
}
*/

//second way, I presume it is the intended way
/*
int Degree(int a, int b)
{
    int result = a; //again, getting veriable to maintain "a" constant
    for(int i = 1; i < b; i++) // setting our degrees, we don't needzero and we already have first degree in veriable "result"
    result = result * a;  //or result *= a;
    return result;
}

Console.Write("Input a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{a} in {b} degree is {Degree(a, b)}");
*/

//third way  as was once mentioned during one of seminars, we can use Math.Pow 
/*
Console.Write("Input a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{a} in {b} degree is {Math.Pow(a, b)}");
*/

// and fourth way,  we can even make methods to make main programm easier to call (my favourite).
/*
int[] Degree()
{
    Console.Write("Input a: ");
    int a = Convert.ToInt32(Console.ReadLine());  //setting first item of massive
    Console.Write("Input b: ");
    int b = Convert.ToInt32(Console.ReadLine()); // setting second item
    int[] result = new int[2]{a, b}; // setting massive
    return result; //getting massive as result
}

void IsDegree(int[] array) // as we are getting array withonly two items - it will work nicely and if we will get a bigger one it will be easy to tune
{
    Console.WriteLine($"{array[0]} in {array[1]} degree is {Math.Pow(array[0], array[1])}");
}
//and the program will be like:

int [] array = Degree(); 
IsDegree(array);
*/

// task 2 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. // I will keep one way for the rest
/*
int DigitSum(int num) // as in palindrome case
{
    int sum = 0; // we initialize our result veriable
    int num1 = num; // we clone our number to kill them both, but in a different way
    while (num / 10 > 0) // we set up cycle to separate the numbers
    {
        num1%=10; // we get last number
        sum += num1; // we put it in result
        num /= 10; //we change the devision
    }
    sum +=num1; //as the last digit stayed in cycle but not added to sum
    return sum;
}

Console.WriteLine("Input: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Sum of digits in {num} is {DigitSum(num)}");
*/


// task 3 Напишите программу, которая задаёт массив из m элементов и выводит их на экран. Разработать метод CreateArray(int size), генерирующий массив на основе данных, вводимых пользователем, размер массива также определяется пользователем
/*
int[] Array()
{
    Console.Write("Input length: ");
    int length = Convert.ToInt32(Console.ReadLine());
    int[] result = new int[length]; //setting up length first, we will need it later
    for (int i = 0; i < length; i++) //setting up cycle
    {
        Console.Write("Input an item: "); //requesting numbers
        int number = Convert.ToInt32(Console.ReadLine());
        result[i] = number; //we increase i from zero, each number gets it spot
    }

    return result; //getting massive as result
}
void ShowArr(int[] array)
{
    Console.Write("And your array is [ "); //this will be executed before cycle
    for (int i = 0; i < array.Length; i++)
    {
        
        Console.Write(array[i] + " ");
        
    }
    Console.Write("]"); //this will make an array look like an array
}

int[] array = Array();
ShowArr(array);
*/